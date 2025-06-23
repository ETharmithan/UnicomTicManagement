using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.View;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LectureController
    {
        // Validate if the FirstName property is not null or whitespace
        public bool CheckFirsteName(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.FirstName);
        }

        // Validate if the LastName property is not null or whitespace
        public bool CheckLastName(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.LastName);
        }

        // Validate if the Nationality property is not null or whitespace
        public bool CheckNationality(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Nationality);
        }

        // Validate if the NICno property is not null or whitespace
        public bool CheckNIC(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.NICno);
        }

        // Validate if the Gmail property is not null or whitespace
        public bool CheckGmail(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Gmail);
        }

        // Validate if PhoneNumber is not null/whitespace, contains only digits, and length is 10
        public bool CheckPhoneNumber(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.PhoneNumber) &&
                   lecture.PhoneNumber.All(Char.IsDigit) &&
                   lecture.PhoneNumber.Length == 10;
        }

        // Validate if Address is not null or whitespace
        public bool CheckAddress(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Address);
        }

        // Validate if DateOfBirth is a valid date (always true unless default date)
        public bool CheckDateofBirth(Lecture lecture)
        {
            // This check converts DateOfBirth to string and checks if not whitespace, 
            // but better to validate the actual date value if needed
            return !string.IsNullOrWhiteSpace(lecture.DateOfBirth.ToString("yyyy-MM-dd"));
        }

        // Validate if Gender is not null or whitespace
        public bool CheckGender(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Gender);
        }

        // Validate if MaritalStatus is not null or whitespace
        public bool CheckMaritalStatus(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.MaritalStatus);
        }

        // Validate if Salary is not null or whitespace
        public bool CheckSalary(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Salary);
        }

        // Validate if Qualification is not null or whitespace
        public bool CheckQualification(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Qualification);
        }

        // Validate if RelationName is not null or whitespace
        public bool CheckRelationName(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.RelationName);
        }

        // Validate if Relationship is not null or whitespace
        public bool CheckRelationShip(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Relationship);
        }

        // Validate if Relationnumber is not null/whitespace, all digits, and length 10
        public bool CheckRelationphoneNumber(Lecture lecture)
        {
            return !string.IsNullOrWhiteSpace(lecture.Relationnumber) &&
                   lecture.Relationnumber.All(Char.IsDigit) &&
                   lecture.Relationnumber.Length == 10;
        }

        // Create a new lecturer in the database after validating all required fields
        public void CreateLecture(Lecture lecture)
        {
            // Check if all required fields are filled
            if (!string.IsNullOrWhiteSpace(lecture.FirstName) &&
                !string.IsNullOrWhiteSpace(lecture.LastName) &&
                !string.IsNullOrWhiteSpace(lecture.DateOfBirth.ToString("yyyy-MM-dd")) &&
                !string.IsNullOrWhiteSpace(lecture.Gender) &&
                !string.IsNullOrWhiteSpace(lecture.Nationality) &&
                !string.IsNullOrWhiteSpace(lecture.NICno) &&
                !string.IsNullOrWhiteSpace(lecture.Gmail) &&
                !string.IsNullOrWhiteSpace(lecture.PhoneNumber) &&
                !string.IsNullOrWhiteSpace(lecture.Address) &&
                !string.IsNullOrWhiteSpace(lecture.MaritalStatus) &&
                !string.IsNullOrWhiteSpace(lecture.RelationName) &&
                !string.IsNullOrWhiteSpace(lecture.Relationship) &&
                !string.IsNullOrWhiteSpace(lecture.Relationnumber) &&
                !string.IsNullOrWhiteSpace(lecture.Salary) &&
                !string.IsNullOrWhiteSpace(lecture.Qualification))
            {
                // Open User Register form and get user id for lecturer
                UserRegisterForm userRegisterForm = new UserRegisterForm();
                userRegisterForm.ShowDialog();

                // Check if user registration was successful (Id > 0)
                if (userRegisterForm.Id > 0)
                {
                    // Connect to database
                    using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                    {
                        string lecturerQuery = @"INSERT INTO Lecturers (
                                            FirstName, LastName, DateOfBirth, Gender, Nationality, NICno,
                                            Gmail, PhoneNumber, Address, MaritalStatus, RelationName,Relationship,
                                            Relationnumber, Salary, Qualification, UsersID, DepartmentsID) 
                                            VALUES (@firstName, @lastName, @dateOfBirth, @gender, @nationality, @nicno,
                                            @gmail, @phoneNumber, @address, @maritalStatus, @relationName,@relationship, 
                                            @relationNumber, @salary, @qualification, @usersID, @departmentsID)";

                        try
                        {
                            using (SQLiteCommand command = new SQLiteCommand(lecturerQuery, connect))
                            {
                                // Add parameters to the SQL query to avoid SQL injection
                                command.Parameters.AddWithValue("@firstName", lecture.FirstName);
                                command.Parameters.AddWithValue("@lastName", lecture.LastName);
                                command.Parameters.AddWithValue("@dateOfBirth", lecture.DateOfBirth);
                                command.Parameters.AddWithValue("@gender", lecture.Gender);
                                command.Parameters.AddWithValue("@nationality", lecture.Nationality);
                                command.Parameters.AddWithValue("@nicno", lecture.NICno);
                                command.Parameters.AddWithValue("@gmail", lecture.Gmail);
                                command.Parameters.AddWithValue("@phoneNumber", lecture.PhoneNumber);
                                command.Parameters.AddWithValue("@address", lecture.Address);
                                command.Parameters.AddWithValue("@maritalStatus", lecture.MaritalStatus);
                                command.Parameters.AddWithValue("@relationName", lecture.RelationName);
                                command.Parameters.AddWithValue("@relationship", lecture.Relationship);
                                command.Parameters.AddWithValue("@relationNumber", lecture.Relationnumber);
                                command.Parameters.AddWithValue("@salary", lecture.Salary);
                                command.Parameters.AddWithValue("@qualification", lecture.Qualification);
                                command.Parameters.AddWithValue("@usersID", userRegisterForm.Id);
                                command.Parameters.AddWithValue("@departmentsID", lecture.DepartmentsID);

                                // Execute insertion
                                command.ExecuteNonQuery();

                                // Notify success
                                MessageBox.Show($"Lecturer {lecture.LastName} Registered Successfully.");

                                // Get the last inserted lecturer ID for saving subjects
                                long lastLecturerId = connect.LastInsertRowId;

                                // Save lecturer-subject relationship
                                SaveLecturerSubject((int)lastLecturerId, lecture.SubjectsID);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Show error message if database save fails
                            MessageBox.Show($"Error saving lecturer data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Inform user to complete all information
                MessageBox.Show("Complete all lecturer information.");
            }
        }

        // Save the relationship between lecturer and subject in the LecturersSubjects table
        private void SaveLecturerSubject(int lecturerId, int subjectId)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string saveLecturerSubjectQuery = @"INSERT INTO LecturersSubjects(LecturersID, SubjectsID)
                                                   VALUES(@lecturerId, @subjectId)";
                using (SQLiteCommand command = new SQLiteCommand(saveLecturerSubjectQuery, connect))
                {
                    command.Parameters.AddWithValue("@lecturerId", lecturerId);
                    command.Parameters.AddWithValue("@subjectId", subjectId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Retrieve a list of lecturers by their ID (should normally return a single lecturer)
        public List<Lecture> GetLecturer(int lectureId)
        {
            List<Lecture> lecturers = new List<Lecture>();

            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string lecturerQuery = "SELECT * FROM Lecturers WHERE ID = @lectureId;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(lecturerQuery, connect);
                adapter.SelectCommand.Parameters.AddWithValue("@lectureId", lectureId);

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                // Map each row from the data table to a Lecture object
                foreach (DataRow row in datatable.Rows)
                {
                    Lecture lecturer = new Lecture
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                        Gender = row["Gender"].ToString(),
                        Nationality = row["Nationality"].ToString(),
                        NICno = row["NICno"].ToString(),
                        Gmail = row["Gmail"].ToString(),
                        PhoneNumber = row["PhoneNumber"].ToString(),
                        MaritalStatus = row["MaritalStatus"].ToString(),
                        Address = row["Address"].ToString(),
                        Salary = row["Salary"].ToString(),
                        Qualification = row["Qualification"].ToString(),
                        RelationName = row["RelationName"].ToString(),
                        Relationship = row["Relationship"].ToString(),
                        Relationnumber = row["Relationnumber"].ToString(),
                        UsersID = Convert.ToInt32(row["UsersId"])
                    };
                    lecturers.Add(lecturer);
                }
            }

            return lecturers;
        }

        // Update lecturer details in the database
        public void UpdateLecturerInDatabase(Lecture lecturer)
        {
            using (var connect = DatabaseManager.DatabaseConnect())
            {
                string updateQuery = @"UPDATE Lecturers SET FirstName=@FirstName, LastName=@LastName, DateOfBirth=@DateOfBirth, Gender=@Gender,
                                 Nationality=@Nationality, NICno=@NICno, Gmail=@Gmail, PhoneNumber=@PhoneNumber, Address=@Address, MaritalStatus=@MaritalStatus,
                                 Salary=@Salary, Qualification=@Qualification, RelationName=@RelationName, Relationship=@Relationship, Relationnumber=@Relationnumber
                                 WHERE Id=@Id";

                using (var command = new SQLiteCommand(updateQuery, connect))
                {
                    // Bind parameters for updating the record
                    command.Parameters.AddWithValue("@FirstName", lecturer.FirstName);
                    command.Parameters.AddWithValue("@LastName", lecturer.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", lecturer.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", lecturer.Gender);
                    command.Parameters.AddWithValue("@Nationality", lecturer.Nationality);
                    command.Parameters.AddWithValue("@NICno", lecturer.NICno);
                    command.Parameters.AddWithValue("@Gmail", lecturer.Gmail);
                    command.Parameters.AddWithValue("@PhoneNumber", lecturer.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", lecturer.Address);
                    command.Parameters.AddWithValue("@MaritalStatus", lecturer.MaritalStatus);
                    command.Parameters.AddWithValue("@Salary", lecturer.Salary);
                    command.Parameters.AddWithValue("@Qualification", lecturer.Qualification);
                    command.Parameters.AddWithValue("@RelationName", lecturer.RelationName);
                    command.Parameters.AddWithValue("@Relationship", lecturer.Relationship);
                    command.Parameters.AddWithValue("@Relationnumber", lecturer.Relationnumber);
                    command.Parameters.AddWithValue("@Id", lecturer.Id);

                    // Execute the update query
                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete a lecturer and related records in a transaction to maintain data integrity
        public void DeleteLecturer(Lecture lecturer)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                using (var transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Delete from the junction table LecturersSubjects
                        string deleteLecturerSubjectQuery = "DELETE FROM LecturersSubjects WHERE LecturersID = @LecturerId";
                        using (SQLiteCommand deleteLecturerSubjectCmd = new SQLiteCommand(deleteLecturerSubjectQuery, connect))
                        {
                            deleteLecturerSubjectCmd.Parameters.AddWithValue("@LecturerId", lecturer.Id);
                            deleteLecturerSubjectCmd.ExecuteNonQuery();
                        }

                        // Step 2: Delete from the Lecturers table
                        string deleteLecturerQuery = "DELETE FROM Lecturers WHERE Id = @Id";
                        using (SQLiteCommand deleteLecturerCmd = new SQLiteCommand(deleteLecturerQuery, connect))
                        {
                            deleteLecturerCmd.Parameters.AddWithValue("@Id", lecturer.Id);
                            deleteLecturerCmd.ExecuteNonQuery();
                        }

                        // Step 3: Delete from the Users table (assuming lecturer has a corresponding user)
                        string deleteUserQuery = "DELETE FROM Users WHERE Id = @UserId";
                        using (SQLiteCommand deleteUserCmd = new SQLiteCommand(deleteUserQuery, connect))
                        {
                            deleteUserCmd.Parameters.AddWithValue("@UserId", lecturer.UsersID);
                            deleteUserCmd.ExecuteNonQuery();
                        }

                        // Commit all deletions if no errors occurred
                        transaction.Commit();

                        // Notify success
                        MessageBox.Show("Lecturer, related subjects, and user deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        // Rollback all changes if any error occurs to maintain database consistency
                        transaction.Rollback();
                        MessageBox.Show("Error while deleting: " + ex.Message);
                    }
                }
            }
        }
    }
}
