using System;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Validation;

namespace UnicomTICManagementSystem.View
{
    public partial class AdminRegisterForm : Form
    {
        // Create instances of controller and model to manage admin data
        AdminController adminController = new AdminController();
        Admin admin = new Admin();
        DashBoardForm dashBoardForm1;
        public AdminRegisterForm()
        {
            InitializeComponent();
        }
        public AdminRegisterForm(DashBoardForm dashBoard)
        {
            InitializeComponent();
            this.dashBoardForm1 = dashBoard;
        }

        // Event handler for FirstName TextBox change
        private void ta_firstname_TextChanged(object sender, EventArgs e)
        {
            admin.Firstname = ta_firstname.Text.Trim();  // Save trimmed input to model
            la_firstname.Text = null;                     // Clear any previous error message
        }

        // Event handler for LastName TextBox change
        private void ta_lastname_TextChanged(object sender, EventArgs e)
        {
            admin.Lastname = ta_lastname.Text.Trim();
            la_lastname.Text = null;
        }

        // Event handler for NIC TextBox change
        private void ta_nic_TextChanged(object sender, EventArgs e)
        {
            admin.NIC = ta_nic.Text.Trim();
            la_nic.Text = null;
        }

        // Event handler for Gmail TextBox change
        private void ta_gmail_TextChanged(object sender, EventArgs e)
        {
            admin.Gmail = ta_gmail.Text.Trim();
            la_gmail.Text = null;
        }

        // Event handler for PhoneNumber TextBox change
        private void ta_mobile_TextChanged(object sender, EventArgs e)
        {
            admin.PhoneNumber = ta_mobile.Text.Trim();
            la_mobile.Text = null;
        }

        // Event handler for Address TextBox change
        private void ta_address_TextChanged(object sender, EventArgs e)
        {
            admin.Address = ta_address.Text.Trim();
            la_address.Text = null;
        }

        private void ta_lastname_Click(object sender, EventArgs e)
        {
            if (!adminController.CheckFirstName(admin))
                la_firstname.Text = "Enter Your First Name";
        }

        private void ta_nic_Click(object sender, EventArgs e)
        {
            if (!adminController.CheckFirstName(admin))
                la_firstname.Text = "Enter Your First Name";

            if (!adminController.CheckLastName(admin))
                la_lastname.Text = "Enter Your Last Name";
        }

        private void ta_gmail_Click(object sender, EventArgs e)
        {
            if (!adminController.CheckFirstName(admin))
                la_firstname.Text = "Enter Your First Name";

            if (!adminController.CheckLastName(admin))
                la_lastname.Text = "Enter Your Last Name";

            if (!adminController.CheckNic(admin))
                la_nic.Text = "Enter Your Nic no";
        }

        private void ta_mobile_Click(object sender, EventArgs e)
        {
            if (!adminController.CheckFirstName(admin))
                la_firstname.Text = "Enter Your First Name";

            if (!adminController.CheckLastName(admin))
                la_lastname.Text = "Enter Your Last Name";

            if (!adminController.CheckNic(admin))
                la_nic.Text = "Enter Your Nic no";

            if (!adminController.CheckGmail(admin))
                la_gmail.Text = "Enter Your Gmail";
        }

        private void ta_address_Click(object sender, EventArgs e)
        {
            if (!adminController.CheckFirstName(admin))
                la_firstname.Text = "Enter Your First Name";

            if (!adminController.CheckLastName(admin))
                la_lastname.Text = "Enter Your Last Name";

            if (!adminController.CheckNic(admin))
                la_nic.Text = "Enter Your Nic no";

            if (!adminController.CheckGmail(admin))
                la_gmail.Text = "Enter Your Gmail";

            if (!adminController.CheckPhoneNumber(admin))
                la_mobile.Text = "Enter Your Mobile Number";
        }

        // Method to clear all input fields in the form
        public void clearfield()
        {
            ta_firstname.Clear();
            ta_lastname.Clear();
            ta_nic.Clear();
            ta_gmail.Clear();
            ta_mobile.Clear();
            ta_address.Clear();
        }


        // Submit button click event handler - validates input and attempts registration
        private void ba_Submit_Click(object sender, EventArgs e)
        {
            // Set gender based on which radio button is checked
            if (ra_male.Checked)
            {
                admin.Gender = ra_male.Text.Trim();
                la_gender.Text = null;
            }
            else if (ra_female.Checked)
            {
                admin.Gender = ra_female.Text.Trim();
                la_gender.Text = null;
            }

            // Validate phone number using custom validation method
            if (!Validation.Validation.ValidPhoneNumber(admin.PhoneNumber))
            {
                MessageBox.Show("Enter a valid Phone number!");
                return;  // Stop submission if invalid
            }

            // Validate Gmail address format
            if (!Validation.Validation.ValidGmail(admin.Gmail))
            {
                MessageBox.Show("Enter a valid Gmail address!");
                return;
            }

            // Call controller to save the admin data to the database
            adminController.CreateAdmin(admin);

            // Clear all fields after successful registration
            clearfield();
        }

        // Clear button click event handler - clears all input fields
        private void ba_clear_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        // Back button click event handler - closes the form
        private void ba_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AdminRegisterForm_Load(object sender, EventArgs e)
        {
            // Optional: Initialize or load any data when the form loads
        }
        private void AdminRegisterForm_Click(object sender, EventArgs e)
        {
            // Currently empty, can be used for form click events if needed
        }

        // These event handlers check if required fields are filled when user clicks on a field,
        // and display error messages if previous required fields are missing.
    }
}
