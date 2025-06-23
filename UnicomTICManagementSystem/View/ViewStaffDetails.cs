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
    public partial class ViewStaffDetails : Form
    
    {
        StaffController staffController = new StaffController();
        private List<Staff> staffs = new List<Staff>();
        public ViewStaffDetails()
        {
            InitializeComponent();
        }

        private void bsta_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tsta_search.Text, out int staffId))
            {
                List<Staff> staffList = staffController.GetStaff(staffId);
                staffs = staffController.GetStaff(staffId);
                dsta_staff.DataSource = staffs;
                dsta_staff.DataSource = staffList;
            }
            else
            {
                MessageBox.Show("Please enter the correct Staff Id.");
            }
        }

        private void bsta_update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dsta_staff.Rows)
            {
                if (row.IsNewRow) continue;

                Staff st = new Staff
                {
                    Id = Convert.ToInt32(row.Cells["ID"].Value),
                    FirstName = row.Cells["FirstName"].Value?.ToString(),
                    LastName = row.Cells["LastName"].Value?.ToString(),
                    DateOfBirth = Convert.ToDateTime(row.Cells["DateOfBirth"].Value),
                    Gender = row.Cells["Gender"].Value?.ToString(),
                    Nationality = row.Cells["Nationality"].Value?.ToString(),
                    Nic = row.Cells["Nic"].Value?.ToString(),
                    Gmail = row.Cells["Gmail"].Value?.ToString(),
                    PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString(),
                    MaritalStatus = row.Cells["MaritalStatus"].Value?.ToString(),
                    Address = row.Cells["Address"].Value?.ToString(),
                    Salary = row.Cells["Salary"].Value?.ToString(),
                    Qualification = row.Cells["Qualification"].Value?.ToString(),
                    DateOfJoining = Convert.ToDateTime(row.Cells["DateOfJoining"].Value),
                    EmergencyContactInformationRelationName = row.Cells["EmergencyContactInformationRelationName"].Value?.ToString(),
                    EmergencyContactInformationRelationship = row.Cells["EmergencyContactInformationRelationship"].Value?.ToString(),
                    EmergencyContactInformationRelationPhoneNumber = row.Cells["EmergencyContactInformationRelationPhoneNumber"].Value?.ToString()
                };

                staffController.UpdateStaffInDatabase(st);
            }

            MessageBox.Show("Updated successfully!");
        }

        private void bsta_delete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(dsta_staff.SelectedRows[0].Cells["Id"].Value);

            var staff = staffs.FirstOrDefault(st => st.Id == selectedId);
            if (staff != null)
            {
                staffController.DeleteStaff(staff);
                staffs.Remove(staff);
                dsta_staff.DataSource = null;
                dsta_staff.DataSource = staffs;

                MessageBox.Show("The selected staff has been removed.");
            }
            else
            {
                MessageBox.Show("Please select a staff first.");
            }
        }

        private void bsta_addstaff_Click(object sender, EventArgs e)
        {
            StaffRegisterForm staffRegisterForm = new StaffRegisterForm();
            staffRegisterForm.ShowDialog();
        }

        private void bsta_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
