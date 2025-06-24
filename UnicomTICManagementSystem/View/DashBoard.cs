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
    public partial class DashBoardForm : Form
    {
        public void LoadForm(object formobject)
        {
            if (this.panel_Main.Controls.Count > 0)
            {
                this.panel_Main.Controls.RemoveAt(0);
            }

            Form form = formobject as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel_Main.Controls.Add(form);
            form.Show();
        }
        public DashBoardForm()
        {
            InitializeComponent();
            LoadForm(new DashboardForm1());
        }

        private void bd_cUser_Click(object sender, EventArgs e)
        {
            //    CreateUser createuser = new CreateUser();
            //    createuser.ShowDialog();
            LoadForm(new CreateUser());
        }
        private void b_education_Click(object sender, EventArgs e)
        {
            //CreateEducation createEducation = new CreateEducation();
            //createEducation.ShowDialog();
            LoadForm(new CreateEducation());
        }

        private void b_exammark_Click(object sender, EventArgs e)
        {
            //ExamMark examMark = new ExamMark();
            //examMark.ShowDialog();
            LoadForm(new ExamMark());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //RoomRegister roomRegister = new RoomRegister();
            //roomRegister.ShowDialog();
            LoadForm(new RoomRegister());
        }
        private void b_updateusers_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdateUsers(this));
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
