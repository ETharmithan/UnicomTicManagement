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
    public partial class MarkRegister : Form
    {
        Mark mark = new Mark();
        CourseController courseController = new CourseController();
        ExamController examController = new ExamController();
        DepartmentController departmentController = new DepartmentController();
        StudentController studentController = new StudentController();
        public MarkRegister()
        {
            InitializeComponent();
        }



        private void tm_score_TextChanged(object sender, EventArgs e)
        {
            mark.Score = tm_score.Text;
        }

        private void tm_grade_TextChanged(object sender, EventArgs e)
        {
            mark.Grade = tm_grade.Text;
        }

        private void bm_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadDepartment()
        {
            var departments = departmentController.GetAllDepartments();
            cm_department.DataSource = departments;
            cm_department.DisplayMember = "Name";
            cm_department.ValueMember = "Id";
            cm_course.Enabled = false;
            cm_subject.Enabled = false;
            cm_exam.Enabled = false;
            cm_student.Enabled = false;
        }

        private void cm_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cm_department.SelectedValue is int selectedDepartmentId)
            {
                cm_course.Enabled = true;
                var courses = courseController.GetCoursesByDepartment(selectedDepartmentId);
                cm_course.DisplayMember = "Name";
                cm_course.ValueMember = "Id";
                cm_course.DataSource = courses;
                cm_subject.Enabled = false;
                cm_exam.Enabled = false;
                cm_student.Enabled = false;
            }
        }
        private void cm_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cm_course.SelectedValue is int selectedCourseId)
            {
                cm_subject.Enabled = true;
                var subjects = courseController.GetSubjectsByCourseId(selectedCourseId);
                cm_subject.DisplayMember = "Name";
                cm_subject.ValueMember = "Id";
                cm_subject.DataSource = subjects;
                cm_exam.Enabled = false;

                cm_student.Enabled = true;
                var students = studentController.GetStudentsByCourseId(selectedCourseId);
                cm_student.DisplayMember = "LastName";
                cm_student.ValueMember = "Id";
                cm_student.DataSource = students;
            }
        }
        private void MarkRegister_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }


        private void cm_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cm_subject.SelectedValue is int subjectId)
            {
                cm_exam.Enabled = true;
                var exams = examController.GetExamsBySubjectId(subjectId);
                cm_exam.DataSource = exams;
                cm_exam.DisplayMember = "ExamName";
                cm_exam.ValueMember = "ID";
                
            }
        }
        private void tm_add_Click(object sender, EventArgs e)
        {
            // Validate input (optional but recommended)
            if (string.IsNullOrWhiteSpace(tm_score.Text) || string.IsNullOrWhiteSpace(tm_grade.Text))
            {
                MessageBox.Show("Score and Grade are required.");
                return;
            }

            // Get selected values
            int studentId = (int)cm_student.SelectedValue;
            int subjectId = (int)cm_subject.SelectedValue;
            int examId = (int)cm_exam.SelectedValue;

            // Create mark object
            Mark mark = new Mark
            {
                StudentsID = studentId,
                SubjectsID = subjectId,
                ExamsID = examId,
                Score = tm_score.Text,
                Grade = tm_grade.Text
            };

            // Save to database
            MarkController markController = new MarkController();
            bool success = markController.SaveMark(mark);

            if (success)
            {
                MessageBox.Show("Mark added successfully!");
                // Optionally clear form or refresh
            }
            else
            {
                MessageBox.Show("Failed to save mark.");
            }
        }
        private void tmr_student_TextChanged(object sender, EventArgs e)
        {

        }

        private void tm_search_Click(object sender, EventArgs e)
        {
            if(cm_department.SelectedValue == null || cm_course.SelectedValue == null ||
        cm_subject.SelectedValue == null || cm_exam.SelectedValue == null)
    {
                MessageBox.Show("Please select Department, Course, Subject and Exam.");
                return;
            }

            int deptId = Convert.ToInt32(cm_department.SelectedValue);
            int courseId = Convert.ToInt32(cm_course.SelectedValue);
            int subjectId = Convert.ToInt32(cm_subject.SelectedValue);
            int examId = Convert.ToInt32(cm_exam.SelectedValue);

            MarkController markController = new MarkController();
            var marks = markController.GetMarks(deptId, courseId, subjectId, examId);

            dm_view.DataSource = marks;

            // Optional: Set DataGridView column headers
            dm_view.Columns["ID"].Visible = false;
            dm_view.Columns["StudentsID"].Visible = false;
            dm_view.Columns["SubjectsID"].Visible = false;
            dm_view.Columns["ExamsID"].Visible = false;
            if (dm_view.Columns.Contains("CoursesID"))
            {
                dm_view.Columns["CoursesID"].Visible = false;
            }


            dm_view.Columns["StudentName"].HeaderText = "Student";
            dm_view.Columns["SubjectName"].HeaderText = "Subject";
            dm_view.Columns["ExamName"].HeaderText = "Exam";
            dm_view.Columns["Score"].HeaderText = "Score";
            dm_view.Columns["Grade"].HeaderText = "Grade";
        }
        private int selectedMarkId = -1;
        private void dm_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dm_view.Rows[e.RowIndex];

                selectedMarkId = Convert.ToInt32(row.Cells["ID"].Value);
                tm_score.Text = row.Cells["Score"].Value.ToString();
                tm_grade.Text = row.Cells["Grade"].Value.ToString();
            }
            
        }

        private void tm_update_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            string newScore = tm_score.Text;
            string newGrade = tm_grade.Text;

            MarkController markController = new MarkController();
            bool updated = markController.UpdateMark(selectedMarkId, newScore, newGrade);

            if (updated)
            {
                MessageBox.Show("Mark updated successfully.");
                // Optionally refresh DataGridView
                tm_search.PerformClick();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void tm_delete_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this mark?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                MarkController markController = new MarkController();
                bool deleted = markController.DeleteMark(selectedMarkId);

                if (deleted)
                {
                    MessageBox.Show("Mark deleted successfully.");
                    selectedMarkId = -1;
                    tm_score.Clear();
                    tm_grade.Clear();
                    tm_search.PerformClick(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete mark.");
                }
            }
        }
    }
}
