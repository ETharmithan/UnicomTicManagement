using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentSubjectController
    {
        public void AddStudentSubjectMapping(int studentId, int subjectId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = @"INSERT INTO StudentsSubjects (StudentsID, SubjectsID) VALUES (@studentsId, @subjectsId)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentsId", studentId);
                    cmd.Parameters.AddWithValue("@subjectsId", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
