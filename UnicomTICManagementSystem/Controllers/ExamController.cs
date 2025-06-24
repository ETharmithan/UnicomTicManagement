using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class ExamController
    {
        public void CreateExam(Exam exam)
        {
            // Validate required exam properties before saving
            if (!string.IsNullOrWhiteSpace(exam.ExamName) &&
                !string.IsNullOrWhiteSpace(exam.Duration) &&
                !string.IsNullOrWhiteSpace(exam.Remarks) &&
                !string.IsNullOrWhiteSpace(exam.ExamType) &&
                !string.IsNullOrWhiteSpace(exam.Status))
            {
                // Open a connection to the SQLite database
                using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    // SQL query to insert a new exam record into the Exams table
                    string examQuery = @"INSERT INTO Exams(
                                  ExamName, ExamDate, ExamTime, ExamType, Duration, Remarks, Status,
                                  CoursesID, SubjectsID, RoomsID)
                                  VALUES(
                                  @ExamName, @ExamDate, @ExamTime, @ExamType, @Duration, @Remarks,
                                  @Status, @CoursesID, @SubjectsID, @RoomsID
                                  );";

                    try
                    {
                        // Prepare the command and bind parameters
                        using (SQLiteCommand command = new SQLiteCommand(examQuery, connect))
                        {
                            command.Parameters.AddWithValue("@ExamName", exam.ExamName);
                            command.Parameters.AddWithValue("@ExamDate", exam.ExamDate.Date);
                            command.Parameters.AddWithValue("@ExamTime", exam.ExamTime.TimeOfDay);
                            command.Parameters.AddWithValue("@ExamType", exam.ExamType);
                            command.Parameters.AddWithValue("@Duration", exam.Duration);
                            command.Parameters.AddWithValue("@Remarks", exam.Remarks);
                            command.Parameters.AddWithValue("@Status", exam.Status);
                            command.Parameters.AddWithValue("@CoursesID", exam.CoursesID);
                            command.Parameters.AddWithValue("@SubjectsID", exam.SubjectsID);
                            command.Parameters.AddWithValue("@RoomsID", exam.RoomsID);

                            // Execute the insert command
                            command.ExecuteNonQuery();

                            // Inform user of successful registration
                            MessageBox.Show($"{exam.ExamName} Registered Successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show error message if database operation fails
                        MessageBox.Show($"Error saving exam data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // You might want to add this to inform the user that validation failed
                MessageBox.Show("Please fill in all required exam details.");
            }
        }
        public List<Exam> GetExamsBySubjectId(int subjectId)
        {
            var exams = new List<Exam>();
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string query = "SELECT * FROM Exams WHERE SubjectsID = @SubjectsID";
                using (SQLiteCommand command = new SQLiteCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@SubjectsID", subjectId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            exams.Add(new Exam
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                ExamName = reader["ExamName"].ToString(),
                                SubjectsID = Convert.ToInt32(reader["SubjectsID"])
                            });
                        }
                    }
                }
            }
            return exams;
        }

    }
}
