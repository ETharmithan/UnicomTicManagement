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
        // Check if Department Name is not empty
        public bool CheckedName(Department department)
        {
            return !string.IsNullOrWhiteSpace(department.Name);
        }

        // Check if Department Description is not empty
        public bool CheckedDescription(Department department)
        {
            return !string.IsNullOrWhiteSpace(department.Description);
        }

        // Create a new department in the database
        public void CreateDepartment(Department department)
        {
            if (!string.IsNullOrWhiteSpace(department.Name) && !string.IsNullOrWhiteSpace(department.Description))
            {
                using (SQLiteConnection Connect = DatabaseManager.DatabaseConnect())
                {
                    string departmentQuery = @"
                        INSERT INTO Departments(Name, Description)
                        VALUES(@name, @description);";

                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(departmentQuery, Connect))
                        {
                            command.Parameters.AddWithValue("@name", department.Name);
                            command.Parameters.AddWithValue("@description", department.Description);
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

        // Retrieve all departments from the database
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            using (var conn = DatabaseManager.DatabaseConnect())
            {
                SQLiteCommand comand = conn.CreateCommand();
                comand.CommandText = "SELECT * FROM Departments";

                SQLiteDataReader reading = comand.ExecuteReader();
                while (reading.Read())
                {
                    departments.Add(new Department
                    {
                        ID = Convert.ToInt32(reading[0]),     // ID
                        Name = reading[1].ToString()          // Name
                        
                    });
                }
            }

            return departments;
        }

        // Update department name based on its ID
        public void UpdateDepartment(Department dept)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "UPDATE Departments SET Name = @Name WHERE ID = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", dept.Name);
                    cmd.Parameters.AddWithValue("@Id", dept.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete a department by ID
        public void DeleteDepartment(int departmentId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "DELETE FROM Departments WHERE ID = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", departmentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Check if the department still has any courses assigned
        public bool HasCourses(int departmentId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "SELECT COUNT(*) FROM Courses WHERE DepartmentsID = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", departmentId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // If count > 0, department still has courses
                }
            }
        }
    }
}
