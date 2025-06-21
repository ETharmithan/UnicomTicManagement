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
    }
}
