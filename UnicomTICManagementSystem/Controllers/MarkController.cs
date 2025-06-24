using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class MarkController
    {
        public bool SaveMark(Mark mark)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string markQuery = @"INSERT INTO Marks (StudentsID, SubjectsID, ExamsID, Score, Grade)
                                 VALUES (@StudentId, @SubjectId, @ExamId, @Score, @Grade)";
                using (SQLiteCommand command = new SQLiteCommand(markQuery, connect))
                {
                    command.Parameters.AddWithValue("@StudentId", mark.StudentsID);
                    command.Parameters.AddWithValue("@SubjectId", mark.SubjectsID);
                    command.Parameters.AddWithValue("@ExamId", mark.ExamsID);
                    command.Parameters.AddWithValue("@Score", mark.Score);
                    command.Parameters.AddWithValue("@Grade", mark.Grade);

                    return command.ExecuteNonQuery() > 0; // true if inserted
                }
            }
        }
        public List<Mark> GetMarks(int departmentId, int courseId, int subjectId, int examId)
        {
            List<Mark> marks = new List<Mark>();

            using (var connect = DatabaseManager.DatabaseConnect())
            {
                string query = @"
            SELECT m.ID, s.FirstName || ' ' || s.LastName AS StudentName, 
                   sub.Name AS SubjectName, e.ExamName, m.Score, m.Grade
            FROM Marks m
            INNER JOIN Students s ON m.StudentsID = s.ID
            INNER JOIN Subjects sub ON m.SubjectsID = sub.ID
            INNER JOIN Exams e ON m.ExamsID = e.ID
            INNER JOIN Courses c ON e.CoursesID = c.ID
            INNER JOIN Departments d ON c.DepartmentsID = d.ID
            WHERE d.ID = @DeptId AND c.ID = @CourseId AND sub.ID = @SubjectId AND e.ID = @ExamId
        ";

                using (var cmd = new SQLiteCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@DeptId", departmentId);
                    cmd.Parameters.AddWithValue("@CourseId", courseId);
                    cmd.Parameters.AddWithValue("@SubjectId", subjectId);
                    cmd.Parameters.AddWithValue("@ExamId", examId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marks.Add(new Mark
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                StudentName = reader["StudentName"].ToString(),
                                SubjectName = reader["SubjectName"].ToString(),
                                ExamName = reader["ExamName"].ToString(),
                                Score = reader["Score"].ToString(),
                                Grade = reader["Grade"].ToString()
                            });
                        }
                    }
                }
            }

            return marks;
        }
        public bool UpdateMark(int markId, string score, string grade)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string updateQuery = @"UPDATE Marks 
                               SET Score = @Score, Grade = @Grade 
                               WHERE ID = @Id";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connect))
                {
                    command.Parameters.AddWithValue("@Score", score);
                    command.Parameters.AddWithValue("@Grade", grade);
                    command.Parameters.AddWithValue("@Id", markId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool DeleteMark(int markId)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string deleteQuery = "DELETE FROM Marks WHERE ID = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@Id", markId);
                    return cmd.ExecuteNonQuery() > 0; // true if deleted
                }
            }
        }



    }
}
