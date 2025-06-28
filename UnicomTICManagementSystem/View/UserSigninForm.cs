using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.View
{
    public partial class UserSigninForm : Form
    {
        public UserSigninForm()
        {
            InitializeComponent();
        }

        private void blo_login_Click(object sender, EventArgs e)
        {
            string username = tlo_username.Text.Trim();
            string password = tlo_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }
            using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string loginQuery = "SELECT * FROM Users WHERE UserName = @username AND Password = @password";
                using(SQLiteCommand command = new SQLiteCommand(loginQuery, connect))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login Successfully.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DashBoardForm dashBoardForm = new DashBoardForm(reader[4].ToString());
                            dashBoardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void blo_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserSigninForm_Load(object sender, EventArgs e)
        {

        }
    }
}
