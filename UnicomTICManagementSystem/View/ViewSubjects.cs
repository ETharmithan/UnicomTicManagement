using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class ViewSubjects : Form
    {
        public ViewSubjects()
        {
            InitializeComponent();
        }

        // Load department details into combo box
        private void LoadDepartmentsToComboBox()
        {
            DepartmentController departmentController = new DepartmentController();
            List<Department> departmentlist = departmentController.GetAllDepartments();
            ca_department.DataSource = departmentlist;
            ca_department.DisplayMember = "Name";
            ca_department.ValueMember = "ID";
            ca_department.SelectedIndex = -1;
            ca_course.Enabled = false;
            ca_subject.Enabled = false;
        }

        // On form load, populate the departments
        private void ViewSubjects_Load(object sender, EventArgs e)
        {
            LoadDepartmentsToComboBox();
        }

        // When a department is selected, load the related courses
        private void ca_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ca_department.SelectedItem is Department selectedDepartment)
            {
                if (ca_department.SelectedIndex > 0)
                {
                    ca_course.Enabled = true;
                    int selectedDepartmentId = selectedDepartment.ID;

                    CourseController courseController = new CourseController();
                    List<Course> courseList = courseController.GetCoursesByDepartment(selectedDepartmentId);

                    ca_course.DataSource = courseList;
                    ca_course.DisplayMember = "Name";
                    ca_course.ValueMember = "Id";
                    ca_course.SelectedIndex = -1;
                    ca_subject.Enabled = false;
                }
                else
                {
                    // No department selected, disable and clear the course combo box
                    ca_course.Enabled = false;
                    ca_course.DataSource = null;
                    ca_course.Items.Clear();
                }
            }
        }

        // When a course is selected, load the related subjects
        private void ca_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ca_course.SelectedItem is Course selectedCourse)
            {
                if (ca_course.SelectedIndex > -1)
                {
                    ca_subject.Enabled = true;
                    int selectedCourseId = selectedCourse.Id;

                    CourseController courseController = new CourseController();
                    List<Subject> subjectList = courseController.GetSubjectsByCourseId(selectedCourseId);

                    ca_subject.DataSource = subjectList;
                    ca_subject.DisplayMember = "Name";
                    ca_subject.ValueMember = "Id";
                    ca_subject.SelectedIndex = -1;
                }
                else
                {
                    // No course selected, disable and clear the subject combo box
                    ca_subject.Enabled = false;
                    ca_subject.DataSource = null;
                    ca_subject.Items.Clear();
                }
            }
        }

        private void ca_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Currently not implemented – placeholder for future use
        }

        // Close (Back) button
        private void ba_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Search button logic
        private void ba_search_Click(object sender, EventArgs e)
        {
            if (ca_department.SelectedItem is Department selectedDepartment &&
                ca_course.SelectedItem is Course selectedCourse &&
                ca_subject.SelectedItem is Subject selectedSubject)
            {
                // Prepare selected data into table
                var data = new
                {
                    Department = selectedDepartment.Name,
                    Course = selectedCourse.Name,
                    Subject = selectedSubject.Name,
                    Credit = selectedSubject.Credit
                };

                DataTable table = new DataTable();
                table.Columns.Add("DepartmentID", typeof(int));
                table.Columns.Add("Department", typeof(string));
                table.Columns.Add("CourseID", typeof(int));
                table.Columns.Add("Course", typeof(string));
                table.Columns.Add("SubjectID", typeof(int));
                table.Columns.Add("Subject", typeof(string));
                table.Columns.Add("Credit", typeof(string));

                table.Rows.Add(
                    selectedDepartment.ID,
                    selectedDepartment.Name,
                    selectedCourse.Id,
                    selectedCourse.Name,
                    selectedSubject.Id,
                    selectedSubject.Name,
                    selectedSubject.Credit
                );

                dacs_view.DataSource = table;
                dacs_view.Columns["DepartmentID"].Visible = false;
                dacs_view.Columns["CourseID"].Visible = false;
                dacs_view.Columns["SubjectID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Please select department, course and subject.");
            }
        }

        // Open the department registration form
        private void ba_adddepartment_Click(object sender, EventArgs e)
        {
            DepartmentRegister departmentRegister = new DepartmentRegister();
            departmentRegister.ShowDialog();
        }

        // Update data from the grid
        private void ba_update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dacs_view.Rows)
            {
                if (row.IsNewRow) continue;

                // Extract data from each row
                int deptId = Convert.ToInt32(row.Cells["DepartmentID"].Value);
                string deptName = row.Cells["Department"].Value.ToString();

                int courseId = Convert.ToInt32(row.Cells["CourseID"].Value);
                string courseName = row.Cells["Course"].Value.ToString();

                int subjectId = Convert.ToInt32(row.Cells["SubjectID"].Value);
                string subjectName = row.Cells["Subject"].Value.ToString();
                string credit = row.Cells["Credit"].Value.ToString();

                // Update Department
                DepartmentController deptCtrl = new DepartmentController();
                deptCtrl.UpdateDepartment(new Department { ID = deptId, Name = deptName });

                // Update Course
                CourseController courseCtrl = new CourseController();
                courseCtrl.UpdateCourse(new Course { Id = courseId, Name = courseName, DepartmentsID = deptId });

                // Update Subject
                SubjectController subCtrl = new SubjectController();
                subCtrl.UpdateSubjectWithCourse(new Subject { Id = subjectId, Name = subjectName, Credit = credit, DepartmentsID = deptId }, courseId);
            }

            MessageBox.Show("Updated successfully.");
        }

        // Delete the selected row
        private void ba_delete_Click(object sender, EventArgs e)
        {
            if (dacs_view.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dacs_view.SelectedRows[0];

                int deptId = Convert.ToInt32(row.Cells["DepartmentID"].Value);
                int courseId = Convert.ToInt32(row.Cells["CourseID"].Value);
                int subjectId = Convert.ToInt32(row.Cells["SubjectID"].Value);

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this subject, course, and department?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    SubjectController subCtrl = new SubjectController();
                    CourseController courseCtrl = new CourseController();
                    DepartmentController deptCtrl = new DepartmentController();

                    // 1. Delete Course-Subject mapping
                    subCtrl.DeleteCourseSubjectMapping(subjectId);

                    // 2. Delete Subject
                    subCtrl.DeleteSubject(subjectId);

                    // 3. Delete Course (only if there are no more subjects under it)
                    if (!courseCtrl.HasSubjects(courseId))
                        courseCtrl.DeleteCourse(courseId);

                    // 4. Delete Department (only if there are no more courses under it)
                    if (!deptCtrl.HasCourses(deptId))
                        deptCtrl.DeleteDepartment(deptId);

                    MessageBox.Show("All records have been successfully deleted.");
                    dacs_view.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
