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
    public partial class ExamMark : Form
    {
        DashBoardForm dashboardForm1;
        public ExamMark()
        {
            InitializeComponent();
        }
        
        public ExamMark(DashBoardForm dashBoardForm)
        {
            InitializeComponent();
            this.dashboardForm1 = dashBoardForm;
        }
        private void b_examreg_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new ExamRegisterForm(this.dashboardForm1));
        }

        private void b_examview_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new ViewExam(this.dashboardForm1));
        }

        private void b_mark_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new MarkRegister());
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
