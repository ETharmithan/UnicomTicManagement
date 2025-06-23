using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class SubjectController
    {
        public int CreateSubject(Subject subject)
        {
            // Check if essential fields are filled
            if (!string.IsNullOrWhiteSpace(subject.Name) && !string.IsNullOrWhiteSpace(subject.Credit))
            {
                using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    // SQL insert query to add new subject
                    string subjectQuery = @"INSERT INTO Subjects(Name, Credit, DepartmentsID)
                                            VALUES(@name, @credit, @departmentsid);";
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(subjectQuery, connect))
                        {
                            // Bind parameters safely to avoid SQL injection
                            command.Parameters.AddWithValue("@name", subject.Name);
                            command.Parameters.AddWithValue("@credit", subject.Credit);
                            command.Parameters.AddWithValue("@departmentsid", subject.DepartmentsID);

                            // Execute insert command
                            command.ExecuteNonQuery();

                            MessageBox.Show($"Subject {subject.Name} Registered Successfully.");

                            // Retrieve last inserted row ID for this subject
                            command.CommandText = "SELECT last_insert_rowid();";
                            command.Parameters.Clear();
                            return Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show error message on failure
                        MessageBox.Show($"Error saving subject:\n{ex.Message}", "Subject Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }
            }
            else
            {
                // Alert user if required fields are missing
                MessageBox.Show("Fill Subject Details");
                return -1;
            }
        }

        public List<Subject> GetSubjectsByDepartmentId(int departmentsId)
        {
            List<Subject> subjects = new List<Subject>();

            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                // SQL select query to get subjects for department
                string dsQuery = @"SELECT * FROM Subjects WHERE DepartmentsID = @departmentsId;";

                using (SQLiteCommand command = new SQLiteCommand(dsQuery, connect))
                {
                    // Bind department ID parameter
                    command.Parameters.AddWithValue("@departmentsId", departmentsId);

                    // Execute query and get reader
                    SQLiteDataReader reader = command.ExecuteReader();

                    // Read all returned rows and create Subject objects
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            // Note: Credit is not retrieved here; add if needed
                            DepartmentsID = Convert.ToInt32(reader["DepartmentsID"])
                        });
                    }
                }
            }
            return subjects;
        }

        public List<Subject> GetSubjectsByCourseId(int courseId)
        {
            List<Subject> subjectList = new List<Subject>();

            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                // SQL join query to fetch subjects related to a course
                string csQuery = @"
                    SELECT s.Id, s.Name, cs.CoursesID
                    FROM CoursesSubjects cs
                    JOIN Subjects s ON s.Id = cs.SubjectsID
                    WHERE cs.CoursesID = @coursesId;";

                using (SQLiteCommand command = new SQLiteCommand(csQuery, connect))
                {
                    // Bind course ID parameter
                    command.Parameters.AddWithValue("@coursesId", courseId);

                    SQLiteDataReader reader = command.ExecuteReader();

                    // Read each row and build Subject objects with CourseID info
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
            }
            return subjectList;
        }

        public void UpdateSubjectWithCourse(Subject subject, int courseId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                using (var tran = conn.BeginTransaction()) // Begin transaction for atomicity
                {
                    try
                    {
                        // Update subject details in Subjects table
                        string updateSubjectQuery = @"
                            UPDATE Subjects 
                            SET Name = @Name, Credit = @Credit, DepartmentsID = @DeptId 
                            WHERE ID = @Id";

                        using (var cmd = new SQLiteCommand(updateSubjectQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", subject.Name);
                            cmd.Parameters.AddWithValue("@Credit", subject.Credit);
                            cmd.Parameters.AddWithValue("@DeptId", subject.DepartmentsID);
                            cmd.Parameters.AddWithValue("@Id", subject.Id);
                            cmd.ExecuteNonQuery();
                        }

                        // Remove any existing course-subject mapping for this subject
                        string deleteMappingQuery = "DELETE FROM CoursesSubjects WHERE SubjectsID = @SubId";
                        using (var cmd = new SQLiteCommand(deleteMappingQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@SubId", subject.Id);
                            cmd.ExecuteNonQuery();
                        }

                        // Insert new course-subject mapping
                        string insertMappingQuery = "INSERT INTO CoursesSubjects (CoursesID, SubjectsID) VALUES (@CourseId, @SubId)";
                        using (var cmd = new SQLiteCommand(insertMappingQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CourseId", courseId);
                            cmd.Parameters.AddWithValue("@SubId", subject.Id);
                            cmd.ExecuteNonQuery();
                        }

                        // Commit transaction if all steps succeeded
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        // Rollback transaction on failure to maintain data integrity
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public void DeleteCourseSubjectMapping(int subjectId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "DELETE FROM CoursesSubjects WHERE SubjectsID = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = DatabaseManager.DatabaseConnect())
            {
                string query = "DELETE FROM Subjects WHERE Id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
