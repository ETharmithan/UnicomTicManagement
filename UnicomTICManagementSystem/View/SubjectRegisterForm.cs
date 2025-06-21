using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.View
{
    public partial class cs_lecturer : Form
    {
        Subject subject = new Subject();
        SubjectController subjectController = new SubjectController();
        
        public cs_lecturer()
        {
            InitializeComponent();
        }
        private void LoadDepartment()
        {
            DepartmentController departmentController = new DepartmentController();
            cs_department.DataSource = departmentController.GetAllDepartments();
            cs_department.DisplayMember = "Name";
            cs_department.ValueMember = "ID";

        }
        private void LoadCoursesByDepartment(int departmentid)
        {
            CourseController courseController = new CourseController();
            var courses = courseController.GetCoursesByDepartment(departmentid);
            cs_course.DataSource = courses;
            cs_course.DisplayMember = "Name";
            cs_course.ValueMember = "ID";
        }
        private void cs_lecturer_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void ts_name_TextChanged(object sender, EventArgs e)
        {
            subject.Name = ts_name.Text;
        }

        private void ts_credit_TextChanged(object sender, EventArgs e)
        {
            subject.Credit = ts_credit.Text;
        }
        private void bs_addtodepartment_Click(object sender, EventArgs e)
        {
            DepartmentRegister departmentRegister = new DepartmentRegister();
            departmentRegister.ShowDialog();
        }

        private void bs_addtocourse_Click(object sender, EventArgs e)
        {
            CourseRegisterForm courseRegisterform = new CourseRegisterForm();
            courseRegisterform.ShowDialog();
        }
        public void ClearField()
        {
            ts_name.Clear();
            ts_credit.Clear();
        }

        private void bs_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private int GetLastInsertedSubjectId()
        {
            using (SQLiteConnection conn = DatabaseManager.DatabaseConnect())
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT last_insert_rowid();", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void bs_add_Click(object sender, EventArgs e)
        {
            if (!(cs_department.SelectedItem is Department selectedDepartment))
            {
                MessageBox.Show("Please select a department.");
                return;
            }

            if (!(cs_course.SelectedValue is int courseId))
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            subject.DepartmentsID = selectedDepartment.ID;

            int subjectId = subjectController.CreateSubject(subject);
            if (subjectId == -1) return;

            CourseSubjectController courseSubjectController = new CourseSubjectController();
            courseSubjectController.AssignSubjectToCourse(courseId, subjectId);

            ClearField();
        }

        private void cs_department_TextChanged(object sender, EventArgs e)
        {

        }

        private void cs_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cs_department.SelectedItem is Department selectedDepartment)
            {
                int selectedDepartmentId = selectedDepartment.ID;
                LoadCoursesByDepartment(selectedDepartmentId);
            }
        }

        private void bs_back_Click(object sender, EventArgs e)
        {

        }
    }
}
