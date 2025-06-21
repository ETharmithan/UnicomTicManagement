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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.View
{
    public partial class StudentRegisterForm1 : Form
    {
        Student student = new Student();
        StudentController studentController = new StudentController();
        public StudentRegisterForm1()
        {
            InitializeComponent();
        }
        //FirstName
        private void tst_firstname_TextChanged(object sender, EventArgs e)
        {
            student.FirstName = tst_firstname.Text.Trim();
            lst_firstname = null;
        }
        //LastName
        private void tst_lastname_TextChanged(object sender, EventArgs e)
        {
            student.LastName = tst_lastname.Text.Trim();
            lst_lastname = null;
        }
        //DateofBirth
        private void dst_dateofbirth_ValueChanged(object sender, EventArgs e)
        {
            student.DateOfBirth=dst_dateofbirth.Value;
            lst_dateofbirth = null;
        }
        //Natioality
        private void tst_nationality_TextChanged(object sender, EventArgs e)
        {
            student.Nationality = tst_nationality.Text.Trim();
            lst_nationality = null;
        }
        //NIC
        private void tst_nic_TextChanged(object sender, EventArgs e)
        {
            student.NICno = tst_nic.Text.Trim();
            lst_nic = null;
        }
        //Gmail
        private void tst_gmail_TextChanged(object sender, EventArgs e)
        {
            student.Gmail = tst_gmail.Text.Trim();
            lst_gmail = null;
        }
        //Mobile
        private void tst_mobile_TextChanged(object sender, EventArgs e)
        {
            student.PhoneNumber = tst_mobile.Text.Trim();
            lst_mobile = null;
        }
        //Address
        private void tst_address_TextChanged(object sender, EventArgs e)
        {
            student.Address = tst_address.Text.Trim();
            lst_address = null;
        }
        //FatherName
        private void tst_fathername_TextChanged(object sender, EventArgs e)
        {
            student.FatherName = tst_fathername.Text.Trim();   
            lst_fathername = null;
        }
        //MotherName
        private void tst_mothername_TextChanged(object sender, EventArgs e)
        {
            student.MotherName = tst_mothername.Text.Trim();
            lst_mothername = null;
        }
        //ParentsPhoneNumber
        private void tst_emc_TextChanged(object sender, EventArgs e)
        {
            student.ParentsPhoneNumber = tst_emc.Text.Trim();
            lst_emc = null;
        }
        private void ClearField()
        {
            tst_firstname.Clear();
            tst_lastname.Clear();
            tst_nationality.Clear();
            tst_gmail.Clear();
            tst_nic.Clear();
            tst_mobile.Clear();
            tst_address.Clear();
            tst_fathername.Clear();
            tst_mothername.Clear();
            tst_emc.Clear();
            cst_Course.SelectedIndex = -1;
            cst_department.SelectedIndex = -1;
        }
        private void bst_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void bst_submit_Click(object sender, EventArgs e)
        {
            if (rst_male.Checked)
                student.Gender = rst_male.Text.Trim();
            else if (rst_female.Checked)
                student.Gender = rst_female.Text.Trim();
            else
            {
                MessageBox.Show("Please select gender.");
                return;
            }
            if (!Validation.Validation.ValidGmail(student.Gmail))
            {
                MessageBox.Show("Enter a valid Gmail address!");
                return;
            }
            if (!Validation.Validation.ValidPhoneNumber(student.PhoneNumber))
            {
                MessageBox.Show("Enter a valid Phone number!");
                return;
            }
            if (!Validation.Validation.ValidPhoneNumber(student.ParentsPhoneNumber))
            {
                MessageBox.Show("Enter a valid Phone number!");
                return;
            }
            if (studentController.CheckFirsteName(student) == false) { lst_firstname.Text = "Enter Your FirstName"; }
            if (studentController.CheckLastName(student) == false) { lst_lastname.Text = "Enter Your LastName"; }
            if (studentController.CheckNIC(student) == false) { lst_nic.Text = "Enter Your Nic"; }
            if (studentController.CheckNationality(student) == false) { lst_nationality.Text = "Enter Your Nationality"; }
            if (studentController.CheckGmail(student) == false) { lst_gmail.Text = "Enter Your Gmail"; }
            if (studentController.CheckPhoneNumber(student) == false) { lst_mobile.Text = "Enter Your Mobile Number"; }
            if (studentController.CheckAddress(student) == false) { lst_address.Text = "Enter Your Address"; }
            if (studentController.CheckFatherName(student) == false) { lst_fathername.Text = "Enter Your FatherName"; }
            if (studentController.CheckMotherName(student) == false) { lst_mothername.Text = "Enter Your MotherName"; }
            if (studentController.CheckParentsPhoneNumber(student) == false) { lst_emc.Text = "Enter Your Parents PhoneNumber"; }
            student.DepartmentsID = Convert.ToInt32(cst_department.SelectedValue);
            student.CoursesID = Convert.ToInt32(cst_Course.SelectedValue);
            
            studentController.CreateStudent(student);
            ClearField();
        }

        private void LoadDepartments()
        {
            DepartmentController departmentController = new DepartmentController();
            cst_department.DataSource = departmentController.GetAllDepartments();
            cst_department.DisplayMember = "Name";
            cst_department.ValueMember = "ID";
        }

        private void StudentRegisterForm1_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }
        private void LoadCoursesByDepartment(int departmentId)
        {
            CourseController courseController = new CourseController();
            var courses = courseController.GetCoursesByDepartment(departmentId);
            cst_Course.DataSource = courses;
            cst_Course.DisplayMember = "Name";
            cst_Course.ValueMember = "ID";
        }

        private void cst_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cst_department.SelectedItem is Department selectedDepartment)
            {
                int departmentId = selectedDepartment.ID;
                LoadCoursesByDepartment(departmentId);
            }
        }
    }
}
