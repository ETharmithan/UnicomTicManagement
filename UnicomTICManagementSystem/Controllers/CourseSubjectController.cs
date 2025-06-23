using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class CourseSubjectController
    {
        public void AssignSubjectToCourse(int CoursesID, int SubjectsID)
        {
            // Establish SQLite database connection
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                // SQL query to insert the course-subject relationship into the CoursesSubjects table
                string courseSubjectQuery = @"INSERT INTO CoursesSubjects(CoursesID, SubjectsID)
                                              VALUES(@coursesid, @subjectsid);";

                // Prepare and execute the SQL command
                using (SQLiteCommand command = new SQLiteCommand(courseSubjectQuery, connect))
                {
                    command.Parameters.AddWithValue("@coursesid", CoursesID);
                    command.Parameters.AddWithValue("@subjectsid", SubjectsID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
