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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        User user = new User();
        private void b_admin_Click(object sender, EventArgs e)
        {
            AdminRegisterForm adminRegisterForm = new AdminRegisterForm(); 
            adminRegisterForm.ShowDialog();
            user.Role = "Admin";
        }

        private void b_Staff_Click(object sender, EventArgs e)
        {
            StaffRegisterForm staffRegisterForm = new StaffRegisterForm();
            staffRegisterForm.ShowDialog();
            user.Role = "Staff";
        }

        private void b_lecture_Click(object sender, EventArgs e)
        {
            LecturerRegisterForm1 lecturerRegisterForm1 = new LecturerRegisterForm1();
            lecturerRegisterForm1.ShowDialog();
            user.Role = "Lecture";
        }

        private void b_student_Click(object sender, EventArgs e)
        {
            StudentRegisterForm1 studentRegisterForm1 = new StudentRegisterForm1();
            studentRegisterForm1.ShowDialog();
            user.Role = "Student";
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
