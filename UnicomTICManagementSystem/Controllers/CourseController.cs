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
        //Course Name Checked
        public bool CheckName(Course course)
        {
            if (!string.IsNullOrWhiteSpace(course.Name)) { return true; }
            else { return false; }
        }
        //Course Description Checked
        public bool CheckDescription(Course course)
        {
            if(!string.IsNullOrWhiteSpace (course.Description)) {return true;}
            else {  return false;}
        }
        //Course Duration Checked
        public bool CheckDuration(Course course)
        {
            if (!string.IsNullOrWhiteSpace(course.Duration)) { return true; }
            else { return false; }
        }
        public void CreateCourse(Course course)
        {
            if(!string.IsNullOrWhiteSpace(course.Name) && !string.IsNullOrWhiteSpace(course.Description) && !string.IsNullOrWhiteSpace(course.Duration))
            {
                using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    string courseQuery = @"INSERT INTO Courses(
                                               Name,Description,Duration,DepartmentsID)
                                               VALUES(@name,@description,@duration,@departmentsid)";
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(courseQuery, connect))
                        {
                            command.Parameters.AddWithValue("@name", course.Name);
                            command.Parameters.AddWithValue("@description", course.Description);
                            command.Parameters.AddWithValue("@duration", course.Duration);
                            command.Parameters.AddWithValue("@departmentsid",course.DepartmentsID );
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
        public List<Subject> GetSubjectsByCourseId(int coursesId)
        {
            List<Subject> subjects = new List<Subject>();
            using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string csQuery = @"SELECT s.ID, s.Name, s.Credit, s.DepartmentsID
                                 FROM Subjects s
                                 JOIN CourseSubject cs ON s.ID = cs.SubjectID
                                 WHERE cs.CoursesID = @coursesId;";
                using (SQLiteCommand command = new SQLiteCommand(csQuery, connect))
                {
                    command.Parameters.AddWithValue("@coursesId", coursesId);
                    SQLiteDataReader reader = command.ExecuteReader() ;
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
    }
}
