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
        User user = new User();
        DashBoardForm dashboardForm1;
        public CreateUser()
        {
            InitializeComponent();
        }
        public CreateUser(DashBoardForm dashBoardForm)
        {
            InitializeComponent();
            this.dashboardForm1 = dashBoardForm;
        }
        private void b_admin_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new AdminRegisterForm(dashboardForm1));
        }

        private void b_Staff_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new StaffRegisterForm(this.dashboardForm1));
        }

        private void b_lecture_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new LecturerRegisterForm1(this.dashboardForm1));
        }

        private void b_student_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new StudentRegisterForm1(this.dashboardForm1));
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
