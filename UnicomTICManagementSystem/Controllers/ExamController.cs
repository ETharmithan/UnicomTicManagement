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
            if (!string.IsNullOrWhiteSpace(exam.ExamName) &&
                !string.IsNullOrWhiteSpace(exam.Duration) &&
                !string.IsNullOrWhiteSpace(exam.Remarks) &&
                !string.IsNullOrWhiteSpace(exam.ExamType)&&
                !string.IsNullOrWhiteSpace(exam.Status))


            {
                using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    string examQuery = @"INSERT INTO Exams(
                                  ExamName, ExamDate, ExamTime, ExamType, Duration, Remarks, Status,
                                  CoursesID, SubjectsID, RoomsID)
                                  VALUES(
                                  @ExamName, @ExamDate, @ExamTime, @ExamType, @Duration, @Remarks,
                                  @Status, @CoursesID, @SubjectsID, @RoomsID
                                  );";
                    try
                    {
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

                            command.ExecuteNonQuery();
                            MessageBox.Show($"{exam.ExamName} Registered Successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving exam data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
