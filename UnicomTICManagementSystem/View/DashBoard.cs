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
        private string role;
        public DashBoardForm(string role)
        {
            InitializeComponent();
            //LoadForm(new DashboardForm1(this));
            this.role = role;

        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            if(role == "Student") 
            {
                bd_cUser.Visible = false;
                b_education.Visible = false;
                b_exammark.Visible = false;
                button1.Visible = false;
                b_updateusers.Visible = false;
                label1.Text = "Student";
            }
            else if(role == "Lecturer")
            {
                bd_cUser.Visible = false;
                b_education.Visible = false;
                b_exammark.Visible = false;
                button1.Visible = false;
                b_updateusers.Visible=false;
                label1.Text = "Lecturer";
            }
            else if (role == "Staff")
            {
                bd_cUser.Visible = false;
                b_education.Visible = false;
                b_exammark.Visible = false;
                button1.Visible = false;
                b_updateusers.Visible = false;
                label1.Text = "Staff";
            }
            else if(role == "Admin")
            {
                label1.Text = "Admin";
            }
        }

        private void bd_cUser_Click(object sender, EventArgs e)
        {
            LoadForm(new CreateUser(this));
        }
        private void b_education_Click(object sender, EventArgs e)
        {
            LoadForm(new CreateEducation(this));
        }

        private void b_exammark_Click(object sender, EventArgs e)
        {
            LoadForm(new ExamMark(this));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomRegister(this));
        }
        private void b_updateusers_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdateUsers(this));
        }
        private void b_logout_Click_1(object sender, EventArgs e)
        {
            Close();
            UserSigninForm userSigninForm = new UserSigninForm();
            userSigninForm.ShowDialog();
        }
        private void b_logout_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
