using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.View
{
    public partial class UpdateUsers : Form
    {
        private DashBoardForm dashboardForm;
        public UpdateUsers(DashBoardForm dashBoard)
        {
            InitializeComponent();
            this.dashboardForm =dashBoard;
        }

        private void b_vack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_uadmin_Click(object sender, EventArgs e)
        {
            //ViewAdmin viewAdmin = new ViewAdmin();
            //viewAdmin.ShowDialog();
            dashboardForm.LoadForm(new ViewAdmin());
        }

        private void b_ustaff_Click(object sender, EventArgs e)
        {
            //ViewStaffDetails viewStaffDetails = new ViewStaffDetails();
            //viewStaffDetails.ShowDialog();
            dashboardForm.LoadForm(new ViewStaffDetails());
        }

        private void b_ulecture_Click(object sender, EventArgs e)
        {
            //ViewLectureDetails viewlecture = new ViewLectureDetails();
            //viewlecture.ShowDialog();
            dashboardForm.LoadForm(new ViewStaffDetails());
        }

        private void b_ustudent_Click(object sender, EventArgs e)
        {
            //ViewStudentDetails viewStudentDetails = new ViewStudentDetails();
            //viewStudentDetails.ShowDialog();
            dashboardForm.LoadForm(new ViewStudentDetails());
        }
    }
}
