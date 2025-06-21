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
    internal class DepartmentController
    {
        //Department Name Checked
        public bool CheckedName(Department department)
        {
            if (!string.IsNullOrWhiteSpace(department.Name)) { return true; }
            else { return false; }
        }
        //Department Description
        public bool CheckedDescription(Department department)
        {
            if (!string.IsNullOrWhiteSpace(department.Description)) { return true; }
            else { return false; }
        }
        public void CreateDepartment(Department department)
        {
            if(!string.IsNullOrWhiteSpace(department.Name) && !string.IsNullOrWhiteSpace(department.Description))
            {
                using (SQLiteConnection Connect = DatabaseManager.DatabaseConnect())
                {
                    string departmentQuery = @"INSERT INTO Departments(Name,Description)
                                               VALUES(@name,@description);";
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(departmentQuery,Connect))
                        {
                            command.Parameters.AddWithValue("@name",department.Name);
                            command.Parameters.AddWithValue("@description",department.Description);
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Department '{department.Name}' Registered Successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Saving {department.Name} data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Fill the Department Details");
            }

        }
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            using (var conn = DatabaseManager.DatabaseConnect())
            {
                SQLiteCommand comand = conn.CreateCommand();
                comand.CommandText = "SELECT * FROM Departments";
                SQLiteDataReader reading = comand.ExecuteReader();
                while(reading.Read())
                {
                    departments.Add(new Department
                    {
                        ID = Convert.ToInt32(reading[0]),
                        Name = reading[1].ToString()
                    });
                   
                }
            }

            return departments;
        }


    }
}
