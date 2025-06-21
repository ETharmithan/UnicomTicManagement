using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class CourseSubjectController
    {
        public void AssignSubjectToCourse(int CoursesID, int SubjectsID)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string courseSubjectQuery = @"INSERT INTO CoursesSubjects(CoursesID, SubjectsID)
                                              VALUES(@coursesid, @subjectsid);";
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
