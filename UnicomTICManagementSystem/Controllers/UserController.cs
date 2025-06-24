using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class UserController
    {
        public int CreateUser(User user)
        {
            if(!string.IsNullOrWhiteSpace(user.UserName) && 
               !string.IsNullOrWhiteSpace(user.Password) &&
               user.Password == user.ConfirmPassword)
            {
                //Database Connect
                using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    string userQuery = @"INSERT INTO 
                                        Users(Username, Password, Gmail, Role) 
                                        VALUES(@username, @password,@gmail,@role);";
                    
                    try
                    {
                        //Excute the Database
                        using (SQLiteCommand command = new SQLiteCommand(userQuery, connect))
                        {
                            command.Parameters.AddWithValue("@username", user.UserName);
                            command.Parameters.AddWithValue("@password", user.Password);
                            command.Parameters.AddWithValue("@gmail", user.Gmail);
                            command.Parameters.AddWithValue("@role", user.Role);
                            int id = Convert.ToInt32(command.ExecuteScalar());
                            MessageBox.Show("User Registered Successfully.");
                            return id;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving user data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }

            }
            else
            {
                MessageBox.Show("Complete all user information.");
                return -1;
            }

        }
    }
}
