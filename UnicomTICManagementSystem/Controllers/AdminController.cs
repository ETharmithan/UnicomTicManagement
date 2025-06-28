using System;
using System.Collections.Generic;
using System.Data;
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
                User user = new User();
                user.Role = "Admin";
                UserRegisterForm userRegister = new UserRegisterForm(user);
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
        public List<Admin> Getadmin(int adminid)
        {
            List<Admin> admins = new List<Admin>();

            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string adminQuery = "SELECT * FROM Admins WHERE ID = @adminId;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(adminQuery, connect);
                adapter.SelectCommand.Parameters.AddWithValue("@adminId", adminid);

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                // Map each row from the data table to a Lecture object
                foreach (DataRow row in datatable.Rows)
                {
                    Admin admin = new Admin
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Firstname = row["FirstName"].ToString(),
                        Lastname = row["LastName"].ToString(),
                        NIC = row["NIC"].ToString(),
                        Gmail = row["Gmail"].ToString(),
                        PhoneNumber = row["PhoneNumber"].ToString(),
                        Address = row["Address"].ToString(),
                        Gender = row["Gender"].ToString(),
                    };
                    admins.Add(admin);
                }
            }

            return admins;
        }
        public void DeleteAdmin(Admin admin)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {

                using (var transaction = connect.BeginTransaction())
                {
                    try
                    {

                        string deleteAdminQuery = "DELETE FROM Admins WHERE Id = @Id";
                        SQLiteCommand deleteAdminCmd = new SQLiteCommand(deleteAdminQuery, connect);
                        deleteAdminCmd.Parameters.AddWithValue("@Id", admin.Id);
                        deleteAdminCmd.ExecuteNonQuery();


                        string deleteUserQuery = "DELETE FROM Users WHERE Id = @UserId";
                        SQLiteCommand deleteUserCmd = new SQLiteCommand(deleteUserQuery, connect);
                        deleteUserCmd.Parameters.AddWithValue("@UserId", admin.UsersId);
                        deleteUserCmd.ExecuteNonQuery();


                        transaction.Commit();

                        MessageBox.Show("Admin and associated user deleted successfully.");
                    }
                    catch (Exception ex)
                    {

                        transaction.Rollback();
                        MessageBox.Show("Error while deleting: " + ex.Message);
                    }
                }
            }
        }
        public void UpdateAdminInDatabase(Admin admin)
        {
            using (var connect = DatabaseManager.DatabaseConnect())
            {
                string updateQuery = @"UPDATE Admins SET
                                        FirstName=@FirstName, LastName=@LastName, Gender=@Gender,
                                        NIC=@NIC, Gmail=@Gmail, PhoneNumber=@PhoneNumber,
                                        Address=@Address
                                       WHERE Id=@Id";

                using (var command = new SQLiteCommand(updateQuery, connect))
                {
                    // Set all parameters for update
                    command.Parameters.AddWithValue("@FirstName", admin.Firstname);
                    command.Parameters.AddWithValue("@LastName", admin.Lastname);
                    command.Parameters.AddWithValue("@Gender", admin.Gender);
                    command.Parameters.AddWithValue("@NIC", admin.NIC);
                    command.Parameters.AddWithValue("@Gmail", admin.Gmail);
                    command.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", admin.Address);
                    command.Parameters.AddWithValue("@Id", admin.Id);

                    // Execute the update command
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
