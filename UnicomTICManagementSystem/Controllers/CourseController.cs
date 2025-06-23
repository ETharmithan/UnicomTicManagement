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
    internal class CourseController
    {
        // Check if Course Name is provided
        public bool CheckName(Course course)
        {
            return !string.IsNullOrWhiteSpace(course.Name);
        }

        // Check if Course Description is provided
        public bool CheckDescription(Course course)
        {
            return !string.IsNullOrWhiteSpace(course.Description);
        }

        // Check if Course Duration is provided
        public bool CheckDuration(Course course)
        {
            return !string.IsNullOrWhiteSpace(course.Duration);
        }

        // Insert a new Course into the database
        public void CreateCourse(Course course)
        {
            if (!string.IsNullOrWhiteSpace(course.Name) &&
                !string.IsNullOrWhiteSpace(course.Description) &&
                !string.IsNullOrWhiteSpace(course.Duration))
            {
                using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    string courseQuery = @"
                        INSERT INTO Courses(Name, Description, Duration, DepartmentsID)
                        VALUES(@name, @description, @duration, @departmentsid)";
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(courseQuery, connect))
                        {
                            command.Parameters.AddWithValue("@name", course.Name);
                            command.Parameters.AddWithValue("@description", course.Description);
                            command.Parameters.AddWithValue("@duration", course.Duration);
                            command.Parameters.AddWithValue("@departmentsid", course.DepartmentsID);
                            command.ExecuteNonQuery();
                            MessageBox.Show($"{course.Name} Registered Successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving course:\n{ex.Message}", "Course Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill Course Details");
            }
        }

        // Retrieve courses belonging to a specific department
        public List<Course> GetCoursesByDepartment(int departmentId)
        {
            List<Course> courses = new List<Course>();
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                SQLiteCommand command = connect.CreateCommand();
                command.CommandText = "SELECT * FROM Courses WHERE DepartmentsID = @DepartmentID";
                command.Parameters.AddWithValue("@DepartmentID", departmentId);

                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    courses.Add(new Course
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DepartmentsID = Convert.ToInt32(reader["DepartmentsID"]),
                        Name = Convert.ToString(reader["Name"])
                    });
                }
            }
            return courses;
        }

        // Get all subjects under a specific course (via join table)
        public List<Subject> GetSubjectsByCourseId(int coursesId)
        {
            List<Subject> subjects = new List<Subject>();
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string csQuery = @"
                    SELECT * FROM Subjects s
                    JOIN CoursesSubjects cs ON s.ID = cs.SubjectsID
                    WHERE cs.CoursesID = @coursesId;";
                using (SQLiteCommand command = new SQLiteCommand(csQuery, connect))
                {
                    command.Parameters.AddWithValue("@coursesId", coursesId);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Credit = reader["Credit"].ToString(),
                            DepartmentsID = Convert.ToInt32(reader["DepartmentsID"])
                        });
                    }
                }
            }
            return subjects;
        }

        // Fetch all courses from the database
        public List<Course> GetCoursesFromDatabase()
        {
            var courses = new List<Course>();
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string query = "SELECT * FROM Courses";
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Add(new Course
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                            });
                        }
                    }
                }
            }
            return courses;
        }

        // Alternative method to get all courses
        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                SQLiteCommand command = connect.CreateCommand();
                command.CommandText = "SELECT * FROM Courses";
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    courses.Add(new Course
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                    });
                }
            }
            return courses;
        }

        // Update course name and department
        public void UpdateCourse(Course course)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "UPDATE Courses SET Name = @Name, DepartmentsID = @DeptID WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.Parameters.AddWithValue("@DeptID", course.DepartmentsID);
                    cmd.Parameters.AddWithValue("@Id", course.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete a course by ID
        public void DeleteCourse(int courseId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "DELETE FROM Courses WHERE Id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", courseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Check whether a course still has subjects linked to it
        public bool HasSubjects(int courseId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "SELECT COUNT(*) FROM CoursesSubjects WHERE CoursesID = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", courseId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
