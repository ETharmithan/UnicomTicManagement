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
    public partial class ViewAdmin : Form
    {
        AdminController adminController = new AdminController();
        private List<Admin> admins =new List<Admin>();
        
        public ViewAdmin()
        {
            InitializeComponent();
        }

        private void bl_addadmin_Click(object sender, EventArgs e)
        {
            AdminRegisterForm adminRegisterForm = new AdminRegisterForm();
            adminRegisterForm.ShowDialog();
        }

        private void ba_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ta_search.Text, out int adminid))
            {
                List<Admin> adminlist = adminController.Getadmin(adminid);
                admins = adminController.Getadmin(adminid);
                da_admin.DataSource = admins;
                da_admin.DataSource = adminlist;
            }
            else
            {
                MessageBox.Show("Please enter the correct Staff Id.");
            }
        }

        private void ba_update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in da_admin.Rows)
            {
                if (row.IsNewRow) continue;

                Admin ad = new Admin
                {
                    Id = Convert.ToInt32(row.Cells["ID"].Value),
                    Firstname = row.Cells["FirstName"].Value?.ToString(),
                    Lastname = row.Cells["LastName"].Value?.ToString(),
                    Gender = row.Cells["Gender"].Value?.ToString(),
                    NIC = row.Cells["NIC"].Value?.ToString(),
                    Gmail = row.Cells["Gmail"].Value?.ToString(),
                    PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString(),
                    Address = row.Cells["Address"].Value?.ToString(),
                };

                adminController.UpdateAdminInDatabase(ad);
            }
        }

        private void ba_delete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(da_admin.SelectedRows[0].Cells["ID"].Value);

            var admin = admins.FirstOrDefault(le => le.Id == selectedId);
            if (admin != null)
            {
                adminController.DeleteAdmin(admin);
                admins.Remove(admin);
                da_admin.DataSource = null;
                da_admin.DataSource = admins;

                MessageBox.Show("The selected admin has been removed.");
            }
            else
            {
                MessageBox.Show("Please select a admin first.");
            }
        }

        private void ba_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

