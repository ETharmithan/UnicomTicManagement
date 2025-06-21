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
    public partial class CourseRegisterForm : Form
    {
        
        Course course = new Course();
        CourseController courseController = new CourseController();
        public CourseRegisterForm()
        {
            InitializeComponent();
        }
        private void LoadDepartment() 
        {
            DepartmentController departmentController = new DepartmentController();
            cc_department.DataSource = departmentController.GetAllDepartments();
            cc_department.DisplayMember = "Name";
            cc_department.ValueMember = "ID";
        }
        private void bc_addtodepartment_Click(object sender, EventArgs e)
        {
            DepartmentRegister departmentRegister = new DepartmentRegister();
            departmentRegister.ShowDialog();
        }

        private void CourseRegisterForm_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        //Save Name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            course.Name = textBox1.Text;
            //lc_name.Text = null;
        }
        
        //Save Description
        private void tc_description_TextChanged(object sender, EventArgs e)
        {
            course.Description = tc_description.Text;
            //lc_description.Text = null;
        }

        //Save Duration
        private void tc_duration_TextChanged(object sender, EventArgs e)
        {
            course.Duration = tc_duration.Text;
            //lc_duration.Text = null;
        }
        //Create Clear Method
        public void ClearField()
        {
            textBox1.Clear();
            tc_description.Clear();
            tc_duration.Clear();
        }
        //Clear Details
        private void bc_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void bc_back_Click(object sender, EventArgs e)
        {
            
        }
        private void bc_addtosubject_Click(object sender, EventArgs e)
        {
            course.DepartmentsID =Convert.ToInt32(cc_department.SelectedValue);
            courseController.CreateCourse(course);
            ClearField();
        }
        private void cc_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bcr_addtosubject_Click(object sender, EventArgs e)
        {
            cs_lecturer subject = new cs_lecturer();
            subject.ShowDialog();
        }
    }
}
