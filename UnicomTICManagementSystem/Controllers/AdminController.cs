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
        //Firstname Checked Validation
        public bool CheckFirstName(Admin admin)
        {
            if (!string.IsNullOrWhiteSpace(admin.Firstname)) {  return true; }
            else {  return false; }
        }
        //Lastname Checked Validation
        public bool CheckLastName(Admin admin)
        {
            if (!string.IsNullOrWhiteSpace(admin.Lastname)) {  return true; }
            else { return false; }
        }
        //Nic Checked Validation
        public bool CheckNic(Admin admin)
        {
            if (!string.IsNullOrWhiteSpace(admin.NIC)) { return true; }
            else { return false; }
        }
        //Gmail Checked Validation
        public bool CheckGmail(Admin admin)
        {
            if (!string.IsNullOrWhiteSpace(admin.Gmail)){  return true; }
            else { return false; }
        }
        //Phone Number Checked Validation
        public bool CheckPhoneNumber(Admin admin) 
        {
            if(!string.IsNullOrWhiteSpace(admin.PhoneNumber) && admin.PhoneNumber.All(Char.IsDigit) && admin.PhoneNumber.Length ==10) {  return true; }
            else { return false; }
        }
        public void CreateAdmin(Admin admin)
        {
            if (!string.IsNullOrWhiteSpace(admin.Firstname) &&
                !string.IsNullOrWhiteSpace(admin.Lastname) &&
                !string.IsNullOrWhiteSpace(admin.NIC) &&
                !string.IsNullOrWhiteSpace(admin.Gmail) &&
                !string.IsNullOrWhiteSpace(admin.PhoneNumber) &&
                !string.IsNullOrWhiteSpace(admin.Address) &&
                !string.IsNullOrWhiteSpace(admin.Gender))
                    
            {
                UserRegisterForm userRegister = new UserRegisterForm();
                userRegister.ShowDialog();
                if (userRegister.Id > 0) 
                {
                    //Database Connect
                    using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                    {
                        string adminQuery = @"INSERT INTO Admins(
                                    Firstname, Lastname, NIC, Gmail, PhoneNumber, Address, Gender,UsersID) VALUES(
                                    @firstname,@lastname,@nic,@gmail,@mobile,@address,@gender,@usersid);";
                        try
                        {
                            //Excute the Database
                            using (SQLiteCommand command = new SQLiteCommand(adminQuery, connect))
                            {

                                command.Parameters.AddWithValue("@firstname", admin.Firstname);
                                command.Parameters.AddWithValue("@lastname", admin.Lastname);
                                command.Parameters.AddWithValue("@nic", admin.NIC);
                                command.Parameters.AddWithValue("@gmail", admin.Gmail);
                                command.Parameters.AddWithValue("@mobile", admin.PhoneNumber);
                                command.Parameters.AddWithValue("@address", admin.Address);
                                command.Parameters.AddWithValue("@gender", admin.Gender);
                                command.Parameters.AddWithValue("@usersid", userRegister.Id);
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
                MessageBox.Show("Complete all admin information.");
            }
        }
    }
}
