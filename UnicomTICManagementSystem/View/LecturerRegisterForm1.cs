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
    public partial class LecturerRegisterForm1 : Form
    {
        Lecture lecture = new Lecture();
        LectureController lectureController = new LectureController();
        public LecturerRegisterForm1()
        {
            InitializeComponent();
        }
        private void LoadDepartment()
        {
            DepartmentController departmentController = new DepartmentController();
            cl_department.DataSource = departmentController.GetAllDepartments();
            cl_department.DisplayMember = "Name";
            cl_department.ValueMember = "ID";
            cl_department.SelectedIndex = -1;
        }
        private void LecturerRegisterForm1_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }
        //FirstName
        private void tl_firstname_TextChanged(object sender, EventArgs e)
        {
            lecture.FirstName = tl_firstname.Text.Trim();
            ll_firstname.Text = null;
        }
        //LastName
        private void tl_lastname_TextChanged(object sender, EventArgs e)
        {
            lecture.LastName = tl_lastname.Text.Trim();
            ll_lastname.Text = null;
        }
        //Date of Birth
        private void dl_dateofbirth_ValueChanged(object sender, EventArgs e)
        {
            lecture.DateOfBirth=dl_dateofbirth.Value;
            ll_dateofbirth.Text = null;
        }
        //Nationality
        private void tl_nationality_TextChanged(object sender, EventArgs e)
        {
            lecture.Nationality = tl_nationality.Text.Trim();
            ll_nationality.Text = null;
        }
        //Nic
        private void tl_nic_TextChanged(object sender, EventArgs e)
        {
            lecture.NICno = tl_nic.Text.Trim();
            ll_nic.Text = null;
        }
        //Gmail
        private void tl_gmail_TextChanged(object sender, EventArgs e)
        {
            lecture.Gmail = tl_gmail.Text.Trim();
            ll_gmail.Text = null;
        }
        //Phone Number
        private void tl_mobile_TextChanged(object sender, EventArgs e)
        {
            lecture.PhoneNumber = tl_mobile.Text.Trim();
            ll_mobile.Text = null;
        }
        //Address
        private void tl_address_TextChanged(object sender, EventArgs e)
        {
            lecture.Address = tl_address.Text.Trim();
            ll_address.Text = null;
        }
        //Maritial Status
        private void cl_maritialstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lecture.MaritalStatus = cl_maritialstatus.Text.Trim();
            ll_maritalstatus.Text = null;
        }
        //Relation Name
        private void tl_relation_TextChanged(object sender, EventArgs e)
        {
            lecture.RelationName = tl_relation.Text.Trim();
            ll_relationname.Text = null;
        }
        //RelationShip
        private void tl_relationship_TextChanged(object sender, EventArgs e)
        {
            lecture.Relationship = tl_relationship.Text.Trim();
            ll_relationship.Text = null;
        }
        //Relation Number
        private void tl_emc_TextChanged(object sender, EventArgs e)
        {
            lecture.Relationnumber = tl_emc.Text.Trim();
            ll_emc.Text = null;
        }
        //Salary
        private void ts_salary_TextChanged(object sender, EventArgs e)
        {
            lecture.Salary = ts_salary.Text.Trim();
            ll_salary.Text = null;
        }
        //Qualification
        private void ts_qualification_TextChanged(object sender, EventArgs e)
        {
            lecture.Qualification = ts_qualification.Text.Trim();
        }
        //Gender Male Check
        private void rl_male_CheckedChanged(object sender, EventArgs e)
        {
            if (rl_male.Checked)
            {
                lecture.Gender = rl_male.Text;
            }
        }
        //Gender Female Check
        private void rl_female_CheckedChanged(object sender, EventArgs e)
        {
            if (rl_female.Checked)
            {
                lecture.Gender = rl_female.Text;
            }
        }
        //Add to Department
        private void bl_adddepartment_Click(object sender, EventArgs e)
        {
            DepartmentRegister departmentRegister = new DepartmentRegister();
            departmentRegister.ShowDialog();
        }
        //Add to Subject
        private void bl_addsubject_Click(object sender, EventArgs e)
        {
            cs_lecturer subjectRegister = new cs_lecturer();
            subjectRegister.ShowDialog();
        }
        //Create Clear Method
        public void Clearfield()
        {
            tl_firstname.Clear();
            tl_lastname.Clear();
            if (DateTime.Today >= dl_dateofbirth.MinDate && DateTime.Today <= dl_dateofbirth.MaxDate)
            {
                dl_dateofbirth.Value = DateTime.Today;
            }
            else
            {
                dl_dateofbirth.Value = dl_dateofbirth.MinDate;
            }
            tl_nationality.Clear();
            rl_male.Checked = false;
            rl_female.Checked = false;
            tl_nic.Clear();
            tl_gmail.Clear();
            tl_mobile.Clear();
            tl_address.Clear();
            cl_maritialstatus.Text = null;
            tl_relation.Clear();
            tl_relationship.Clear();
            tl_emc.Clear();
            ts_salary.Clear();
            ts_qualification.Clear();
            cl_department.Text = null;
            cl_Subject.Text = null;
        }
        private void bl_submit_Click(object sender, EventArgs e)
        {            
            lectureController.CreateLecture(lecture);
            Clearfield();
        }
        private void bl_clear_Click(object sender, EventArgs e)
        {
            Clearfield();
        }

        private void LoadSubjectsByDepartment(int departmentId)
        {
            SubjectController subjectController = new SubjectController();
            var subjects = subjectController.GetSubjectsByDepartmentId(departmentId);
            cl_Subject.DataSource = subjects;
            cl_Subject.DisplayMember = "Name";
            cl_Subject.ValueMember= "Id";
        }
        private void cl_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cl_department.SelectedItem is Department selectedDepartment)
            {
                int departmentid = selectedDepartment.ID;
                lecture.DepartmentsID = selectedDepartment.ID;
                LoadSubjectsByDepartment(departmentid);
                cl_Subject.Enabled = true;
            }
            else
            {
                cl_Subject.DataSource = null;
                cl_Subject.Enabled = false;
            }
        }
        private int selectedSubjectId = 0;
        private void cl_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cl_Subject.SelectedItem is Subject selected)
            {
                selectedSubjectId = selected.Id;
                lecture.SubjectsID = selected.Id;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tl_nationality_Click(object sender, EventArgs e)
        {

        }

    }
}
