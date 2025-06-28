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
            dashboardForm.LoadForm(new ViewAdmin(this.dashboardForm));
        }

        private void b_ustaff_Click(object sender, EventArgs e)
        {
            dashboardForm.LoadForm(new ViewStaffDetails(this.dashboardForm));
        }

        private void b_ulecture_Click(object sender, EventArgs e)
        {
            dashboardForm.LoadForm(new ViewLectureDetails(this.dashboardForm));
        }

        private void b_ustudent_Click(object sender, EventArgs e)
        {
            dashboardForm.LoadForm(new ViewStudentDetails(this.dashboardForm));
        }
    }
}
