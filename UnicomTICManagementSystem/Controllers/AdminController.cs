using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.View;

namespace UnicomTICManagementSystem.Controllers
{
    internal class AdminController
    {
        // Validates if Firstname is not empty or null
        public bool CheckFirstName(Admin admin)
        {
            return !string.IsNullOrWhiteSpace(admin.Firstname);
        }

        // Validates if Lastname is not empty or null
        public bool CheckLastName(Admin admin)
        {
            return !string.IsNullOrWhiteSpace(admin.Lastname);
        }

        // Validates if NIC is not empty or null
        public bool CheckNic(Admin admin)
        {
            return !string.IsNullOrWhiteSpace(admin.NIC);
        }

        // Validates if Gmail is not empty or null
        public bool CheckGmail(Admin admin)
        {
            return !string.IsNullOrWhiteSpace(admin.Gmail);
        }

        // Validates if phone number is exactly 10 digits and only numeric
        public bool CheckPhoneNumber(Admin admin)
        {
            return !string.IsNullOrWhiteSpace(admin.PhoneNumber) &&
                   admin.PhoneNumber.All(Char.IsDigit) &&
                   admin.PhoneNumber.Length == 10;
        }

        // Creates an Admin after validating all fields and linking to a User account
        public void CreateAdmin(Admin admin)
        {
            // Check if all required fields are filled
            if (!string.IsNullOrWhiteSpace(admin.Firstname) &&
                !string.IsNullOrWhiteSpace(admin.Lastname) &&
                !string.IsNullOrWhiteSpace(admin.NIC) &&
                !string.IsNullOrWhiteSpace(admin.Gmail) &&
                !string.IsNullOrWhiteSpace(admin.PhoneNumber) &&
                !string.IsNullOrWhiteSpace(admin.Address) &&
                !string.IsNullOrWhiteSpace(admin.Gender))
            {
                // Open the User Registration Form to create a linked User entry
                UserRegisterForm userRegister = new UserRegisterForm();
                userRegister.ShowDialog();

                // If a valid user was created (Id > 0), proceed to create Admin
                if (userRegister.Id > 0)
                {
                    using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                    {
                        // SQL Query to insert a new admin
                        string adminQuery = @"INSERT INTO Admins(
                                    Firstname, Lastname, NIC, Gmail, PhoneNumber, Address, Gender, UsersID) 
                                    VALUES (@firstname, @lastname, @nic, @gmail, @mobile, @address, @gender, @usersid);";

                        try
                        {
                            using (SQLiteCommand command = new SQLiteCommand(adminQuery, connect))
                            {
                                // Add admin values to query
                                command.Parameters.AddWithValue("@firstname", admin.Firstname);
                                command.Parameters.AddWithValue("@lastname", admin.Lastname);
                                command.Parameters.AddWithValue("@nic", admin.NIC);
                                command.Parameters.AddWithValue("@gmail", admin.Gmail);
                                command.Parameters.AddWithValue("@mobile", admin.PhoneNumber);
                                command.Parameters.AddWithValue("@address", admin.Address);
                                command.Parameters.AddWithValue("@gender", admin.Gender);
                                command.Parameters.AddWithValue("@usersid", userRegister.Id);

                                // Execute insert
                                command.ExecuteNonQuery();
                                MessageBox.Show($"Admin {admin.Lastname} Registered Successfully.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving admin data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // If any field is missing, show validation message
                MessageBox.Show("Complete all admin information.");
            }
        }
    }
}
