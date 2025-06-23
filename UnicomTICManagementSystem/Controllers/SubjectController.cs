using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class SubjectController
    {
        public int CreateSubject(Subject subject)
        {
            if (!string.IsNullOrWhiteSpace(subject.Name) && !string.IsNullOrWhiteSpace(subject.Credit))
            {
                using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    string subjectQuery = @"INSERT INTO Subjects(Name,Credit,DepartmentsID)
                                            VALUES(@name,@credit,@departmentsid);";
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(subjectQuery, connect))
                        {
                            command.Parameters.AddWithValue("@name",subject.Name);
                            command.Parameters.AddWithValue("@credit",subject.Credit);
                            command.Parameters.AddWithValue("@departmentsid",subject.DepartmentsID);
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Subject {subject.Name} Registered Successfully.");
                            
                            command.CommandText = "SELECT last_insert_rowid();";
                            command.Parameters.Clear();
                            return Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving subject:\n{ex.Message}", "Subject Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }

                } 
            }
            else
            {
                MessageBox.Show("Fill Subject Details");
                return -1;
            }
        }
        public List<Subject> GetSubjectsByDepartmentId(int departmentsId)
        {
            List<Subject> subjects = new List<Subject>();
            using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string dsQuery = @"SELECT * FROM Subjects s 
                                   WHERE DepartmentsID = @departmentsId;";
                using(SQLiteCommand command = new SQLiteCommand(dsQuery, connect))
                {
                    command.Parameters.AddWithValue("@departmentsId", departmentsId);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            DepartmentsID = Convert.ToInt32(reader["DepartmentsID"])
                        });
                    }
                }
                return subjects;
            }
        }
        public List<Subject> GetSubjectsByCourseId(int courseId)
        {
            List<Subject> subjectList = new List<Subject>();
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string csQuery = @"SELECT s.Id, s.Name, cs.CoursesID
                           FROM CoursesSubjects cs
                           JOIN Subjects s ON s.Id = cs.SubjectsID
                           WHERE cs.CoursesID = @coursesId;";
                using (SQLiteCommand command = new SQLiteCommand(csQuery, connect))
                {
                    command.Parameters.AddWithValue("@coursesId", courseId);
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        subjectList.Add(new Subject
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            CoursesID = Convert.ToInt32(reader["CoursesID"])
                        });
                    }
                }
                return subjectList;
            }
        }
    }
}
