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
        public void AssignLecturertoSubject(int LectureId,int SubjectId)
        {
            using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string LecturerSubjectQuery = @"INSERT INTO LecturesSubjects(LecturersID,SubjectsID)
                                                VALUES(@lecturersid,@subjectsid);";
                using(SQLiteCommand command = new SQLiteCommand(LecturerSubjectQuery, connect))
                {
                    command.Parameters.AddWithValue("@lecturersid",LectureId);
                    command.Parameters.AddWithValue("@subjectsid", SubjectId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
