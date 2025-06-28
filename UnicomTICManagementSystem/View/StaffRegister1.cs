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
using UnicomTICManagementSystem.Validation;

namespace UnicomTICManagementSystem.View
{
    public partial class StaffRegisterForm : Form
    {
        Staff staff = new Staff();
        StaffController staffController = new StaffController();
        DashBoardForm dashBoardForm;
        public StaffRegisterForm()
        {
            InitializeComponent();
        }
        public StaffRegisterForm(DashBoardForm dashBoard)
        {
            InitializeComponent();
            this.dashBoardForm = dashBoard;
        }

        //Save FirstName
        private void ts_firstname_TextChanged(object sender, EventArgs e)
        {
            staff.FirstName = ts_firstname.Text.Trim();
            ls_firstname.Text = null;
        }

        //Save Lastname
        private void ts_lastname_TextChanged(object sender, EventArgs e)
        {
            staff.LastName = ts_lastname.Text;
            ls_lastname.Text = null;
        }
        //Save DateofBirth
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            staff.DateOfBirth = ts_dateofbirth.Value;
            ls_dateofbirth.Text = null;
        }
        //Save Nationality
        private void ts_nationality_TextChanged(object sender, EventArgs e)
        {
            staff.Nationality = ts_nationality.Text;
            ls_nationality.Text = null;
        }
        //Save NIC no
        private void ts_nic_TextChanged(object sender, EventArgs e)
        {
            staff.Nic = ts_nic.Text;
            ls_nic.Text = null;
        }
        //Save Gmail
        private void ts_gmail_TextChanged(object sender, EventArgs e)
        {
            staff.Gmail = ts_gmail.Text;
            ls_gmail.Text = null;
        }
        //Save Mobile number
        private void ts_mobile_TextChanged(object sender, EventArgs e)
        {
            staff.PhoneNumber = ts_mobile.Text;
            ls_mobile.Text = null;
        }
        //Save Address
        private void ts_address_TextChanged(object sender, EventArgs e)
        {
            staff.Address = ts_address.Text;
            ls_address.Text = null;
        }
        //Save Maritial Status
        private void cs_martial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cs_martial.SelectedItem != null)
            {
                staff.MaritalStatus = cs_martial.SelectedItem.ToString();
                ls_martialstatus.Text = null;
            }
            
        }
        //Save Emergency Contact Information Relation
        private void ts_emc_relation_TextChanged(object sender, EventArgs e)
        {
            staff.EmergencyContactInformationRelationName = ts_emc_relation.Text;
            ls_emc.Text = null;
        }
        //Save Emergency Contact Information Relation
        private void ts_emcrelationship_TextChanged(object sender, EventArgs e)
        {
            staff.EmergencyContactInformationRelationship = ts_emcrelationship.Text;
            ls_emcrelationship.Text = null;
        }

        //Emergency Contact Information Relation PhoneNumber
        private void ts_emc_mobile_TextChanged(object sender, EventArgs e)
        {
            staff.EmergencyContactInformationRelationPhoneNumber = ts_emc_mobile.Text;
            ls_emcmobile.Text = null;
        }
        //Save Salary
        private void ts_salary_TextChanged(object sender, EventArgs e)
        {
            staff.Salary = ts_salary.Text;
            ls_salary.Text = null;
        }
        //Save Qualification
        private void ts_qualification_TextChanged(object sender, EventArgs e)
        {
            staff.Qualification = ts_qualification.Text;
            ls_qualification.Text = null;
        }
        //Create Clear Methode
        public void ClearField()
        {
            ts_firstname.Clear();
            ts_lastname.Clear();
            rs_male.Checked = false;
            rs_female.Checked = false;
            ts_nationality.Clear();
            ts_nic.Clear();
            ts_gmail.Clear();
            ts_mobile.Clear();
            ts_address.Clear();
            cs_martial.SelectedIndex = -1;
            ts_emc_relation.Clear();
            ts_emcrelationship.Clear();
            ts_emc_mobile.Clear();
            ts_salary.Clear();
            ts_qualification.Clear();
        }
        //Clear Details
        private void bs_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        //Register Details
        private void bs_submit_Click(object sender, EventArgs e)
        {
            if (rs_male.Checked)
                staff.Gender = rs_male.Text;
            else if (rs_female.Checked)
                staff.Gender = rs_female.Text;
            else
            {
                MessageBox.Show("Fill All your Details");
                return;
            }
            if (!Validation.Validation.ValidGmail(staff.Gmail))
            {
                MessageBox.Show("Enter a valid Gmail address!");
                return;
            }
            if(!Validation.Validation.ValidPhoneNumber(staff.PhoneNumber))
            {
                MessageBox.Show("Enter a valid Phone number!");
                return;
            }
            if (!Validation.Validation.ValidPhoneNumber(staff.EmergencyContactInformationRelationPhoneNumber))
            {
                MessageBox.Show("Enter a valid Phone number!");
                return;
            }
            if (!Validation.Validation.ValidSalary(staff.Salary))
            {
                MessageBox.Show("Enter the Numeric Number");
                return;
            }
            if (staffController.CheckFirstName(staff) == false) { ls_firstname.Text = "Enter Your FirstName"; }
            if (staffController.CheckLastName(staff) == false) { ls_lastname.Text = "Enter Your LastName"; }
            if (staffController.CheckNationality(staff) == false) { ls_nationality.Text = "Enter Your Nationality"; }
            if (staffController.CheckNic(staff) == false) { ls_nic.Text = "Enter Your Nic"; }
            if (staffController.CheckGmail(staff) == false) { ls_gmail.Text = "Enter Your Gmail"; }
            if (staffController.CheckPhoneNumber(staff) == false) { ls_mobile.Text = "Enter Your Mobile Number"; }
            if (staffController.CheckAddress(staff) == false) { ls_address.Text = "Enter Your Address"; }
            if (staffController.CheckMaritalStatus(staff) == false) { ls_martialstatus.Text = "Select Your Status"; }
            if (staffController.CheckRelation(staff) == false) { ls_emc.Text = "Enter Your RelationName"; }
            if (staffController.CheckRelationship(staff) == false) { ls_emcrelationship.Text = "Enter Your RelationShip"; }
            if (staffController.CheckRelationPhoneNumber(staff) == false) { ls_emcmobile.Text = "Enter Your Relation Phone Number"; }
            if (staffController.CheckSalary(staff) == false) { ls_salary.Text = "Enter the Correct Amount"; }
            if (staffController.CheckQualification(staff) == false) { ls_qualification.Text = "Enter the Qualification"; }
            staffController.CreateStaff(staff);
            ClearField();
        }
        private void bs_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ts_lastname_Click(object sender, EventArgs e)
        {
            
        }

        private void rs_male_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void StaffRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
