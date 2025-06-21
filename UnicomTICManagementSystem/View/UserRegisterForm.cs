using Microsoft.Win32;
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
    public partial class UserRegisterForm : Form
    {
        User user = new User();
        UserController userController = new UserController();
        public int Id { get; set; }
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void UserRegisterForm_Load(object sender, EventArgs e)
        {

        }
        //Save Username
        private void tu_username_TextChanged(object sender, EventArgs e)
        {
            user.UserName = tu_username.Text;
        }
        //Save Password
        private void tu_password_TextChanged(object sender, EventArgs e)
        {
            user.Password = tu_password.Text;
        }
        //Save ConfirmPassword
        private void tu_cpassword_TextChanged(object sender, EventArgs e)
        {
            user.ConfirmPassword = tu_cpassword.Text;
        }
        //Save Gmail
        private void tu_gmail_TextChanged(object sender, EventArgs e)
        {
            user.Gmail = tu_gmail.Text;
        }
        //Clear Method
        public void clearfield()
        {
            tu_username.Clear();
            tu_password.Clear();
            tu_cpassword.Clear();
            tu_gmail.Clear();
        }

        private void bu_Submit_Click(object sender, EventArgs e)
        {
            if (!Validation.Validation.ValidGmail(user.Gmail))
            {
                MessageBox.Show("Enter a Correct Gmail!");
                return;
            }
            Id=userController.CreateUser(user);
            clearfield();
            if (Id > 0)
            {
                Close();
            }
        }

        private void bu_clear_Click(object sender, EventArgs e)
        {
            clearfield();
            lu_confirmpassword = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
