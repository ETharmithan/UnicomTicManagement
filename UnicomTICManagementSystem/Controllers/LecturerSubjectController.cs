using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LecturerSubjectController
    {
        public void AssignLecturertoSubject(int LectureId, int SubjectId)
        {
            // Open a connection to the SQLite database using a helper method
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                // SQL query to insert a new lecturer-subject relationship
                string LecturerSubjectQuery = @"INSERT INTO LecturesSubjects(LecturersID, SubjectsID)
                                               VALUES(@lecturersid, @subjectsid);";

                // Create a SQLiteCommand to execute the query with parameters to prevent SQL injection
                using (SQLiteCommand command = new SQLiteCommand(LecturerSubjectQuery, connect))
                {
                    // Bind parameters with the method arguments
                    command.Parameters.AddWithValue("@lecturersid", LectureId);
                    command.Parameters.AddWithValue("@subjectsid", SubjectId);

                    // Execute the insert command on the database
                    command.ExecuteNonQuery();
                }
            }
            // The connection and command are disposed automatically because of 'using' statements
        }
    }
}
