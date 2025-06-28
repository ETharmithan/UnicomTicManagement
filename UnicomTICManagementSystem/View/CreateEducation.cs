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
    public partial class CreateEducation : Form
    {
        DashBoardForm dashboardForm1;
        public CreateEducation()
        {
            InitializeComponent();
        }
        public CreateEducation(DashBoardForm dashBoardForm)
        {
            InitializeComponent();
            this.dashboardForm1 = dashBoardForm;
        }

        private void b_department_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new DepartmentRegister(this.dashboardForm1));
        }

        private void b_course_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new CourseRegisterForm(this.dashboardForm1));
        }

        private void b_subject_Click(object sender, EventArgs e)
        {
            dashboardForm1.LoadForm(new cs_lecturer(this.dashboardForm1));
        }

        private void b_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
