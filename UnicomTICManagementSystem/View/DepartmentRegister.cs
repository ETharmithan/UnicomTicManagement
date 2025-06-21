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
    public partial class DepartmentRegister : Form
    {
        Department department = new Department();
        DepartmentController departmentController = new DepartmentController();
        public DepartmentRegister()
        {
            InitializeComponent();
        }
        //Save Name
        private void td_name_TextChanged(object sender, EventArgs e)
        {
            department.Name= td_name.Text;
            ld_name.Text = null;
        }
        //Save Description
        private void td_description_TextChanged(object sender, EventArgs e)
        {
            department.Description= td_description.Text;
            ld_description.Text = null;
        }
        //Create CLear Methode
        public void ClearField()
        {
            td_name.Clear();
            td_description.Clear();
        }
        //Clear Details
        private void bd_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        //Add Details
        private void bd_add_Click(object sender, EventArgs e)
        {
            if (departmentController.CheckedName(department) == false) { ld_name.Text = "Enter the Department Name"; }
            if (departmentController.CheckedDescription(department) == false) { ld_description.Text = "Enter the Department Description"; }
            departmentController.CreateDepartment(department);
            ClearField();
        }

        private void bd_addtocourse_Click(object sender, EventArgs e)
        {
            CourseRegisterForm courseRegisterForm = new CourseRegisterForm();
            courseRegisterForm.ShowDialog();
        }
    }
}
