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
    public partial class AdminRegisterForm : Form
    {
        AdminController adminController = new AdminController();
        Admin admin = new Admin();

        public AdminRegisterForm()
        {
            InitializeComponent();
        }

        private void AdminRegisterForm_Load(object sender, EventArgs e)
        {

        }
        //Save FirstName
        private void ta_firstname_TextChanged(object sender, EventArgs e)
        {
            admin.Firstname = ta_firstname.Text;
            la_firstname.Text = null;
        }
        //Save LastName
        private void ta_lastname_TextChanged(object sender, EventArgs e)
        {
            admin.Lastname = ta_lastname.Text;
            la_lastname.Text = null;
        }
        //Save NIC
        private void ta_nic_TextChanged(object sender, EventArgs e)
        {
            admin.NIC = ta_nic.Text;
            la_nic.Text = null;
        }
        //Save Gmail
        private void ta_gmail_TextChanged(object sender, EventArgs e)
        {
            admin.Gmail = ta_gmail.Text;
            la_gmail.Text = null;
        }
        //Save PhoneNumber
        private void ta_mobile_TextChanged(object sender, EventArgs e)
        {
            admin.PhoneNumber = ta_mobile.Text;
            la_mobile.Text = null;
        }
        //Save Address
        private void ta_address_TextChanged(object sender, EventArgs e)
        {
            admin.Address = ta_address.Text;
            la_address.Text = null;
        }
        //Clear Method
        public void clearfield()
        {
            ta_firstname.Clear();
            ta_lastname.Clear();
            ta_nic.Clear();
            ta_gmail.Clear();
            ta_mobile.Clear();
            ta_address.Clear();
        }
        //Clear Details
        private void ba_clear_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        //Register details
        private void ba_Submit_Click(object sender, EventArgs e)
        {
            if (ra_male.Checked)
            {
                admin.Gender = ra_male.Text;
                la_gender.Text = null;
            }
            else if (ra_female.Checked)
            {
                admin.Gender = ra_female.Text;
                la_gender.Text = null;
            }

            if (!Validation.Validation.ValidPhoneNumber(admin.PhoneNumber))
            {
                MessageBox.Show("Enter a valid Phone number!");
                return;
            }

            if (!Validation.Validation.ValidGmail(admin.Gmail))
            {
                MessageBox.Show("Enter a valid Gmail address!");
                return;
            }
            adminController.CreateAdmin(admin);
            clearfield();
        }


        private void AdminRegisterForm_Click(object sender, EventArgs e)
        {
       
        }
        //Checked Empty Box
        private void ta_lastname_Click(object sender, EventArgs e)
        {
            if (adminController.CheckFirstName(admin) == false) { la_firstname.Text = "Enter Your First Name"; }
        }
        //Checked Empty Box
        private void ta_nic_Click(object sender, EventArgs e)
        {
            if (adminController.CheckFirstName(admin) == false) { la_firstname.Text = "Enter Your First Name"; }
            if (adminController.CheckLastName(admin) == false){ la_lastname.Text = "Enter Your Last Name"; }
        }
        //Checked Empty Box
        private void ta_gmail_Click(object sender, EventArgs e)
        {
            if (adminController.CheckFirstName(admin) == false) { la_firstname.Text = "Enter Your First Name"; }
            if (adminController.CheckLastName(admin) == false) { la_lastname.Text = "Enter Your Last Name"; }
            if (adminController.CheckNic(admin) == false) { la_nic.Text = "Enter Your Nic no"; }
        }
        //Checked Empty Box
        private void ta_mobile_Click(object sender, EventArgs e)
        {
            if (adminController.CheckFirstName(admin) == false) { la_firstname.Text = "Enter Your First Name"; }
            if (adminController.CheckLastName(admin) == false) { la_lastname.Text = "Enter Your Last Name"; }
            if (adminController.CheckNic(admin) == false) { la_nic.Text = "Enter Your Nic no"; }
            if (adminController.CheckGmail(admin) == false) { la_gmail.Text = "Enter Your Gmail"; }
        }
        //Checked Empty Box
        private void ta_address_Click(object sender, EventArgs e)
        {
            if (adminController.CheckFirstName(admin) == false) { la_firstname.Text = "Enter Your First Name"; }
            if (adminController.CheckLastName(admin) == false) { la_lastname.Text = "Enter Your Last Name"; }
            if (adminController.CheckNic(admin) == false) { la_nic.Text = "Enter Your Nic no"; }
            if (adminController.CheckGmail(admin) == false) { la_gmail.Text = "Enter Your Gmail"; }
            if (adminController.CheckPhoneNumber(admin) == false) { la_mobile.Text = "Enter Your Mobile Number"; }
        }
    }
}