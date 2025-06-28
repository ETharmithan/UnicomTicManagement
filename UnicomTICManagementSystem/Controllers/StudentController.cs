using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.View;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        // Validate PhoneNumber: must be 10 digits and numeric
        public bool CheckPhoneNumber(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.PhoneNumber) &&
                   student.PhoneNumber.All(char.IsDigit) &&
                   student.PhoneNumber.Length == 10;
        }

        // Validate FirstName is not empty
        public bool CheckFirstName(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.FirstName);
        }

        // Validate LastName is not empty
        public bool CheckLastName(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.LastName);
        }

        // Validate NIC number is not empty
        public bool CheckNIC(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.NICno);
        }

        // Validate Nationality is not empty
        public bool CheckNationality(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.Nationality);
        }

        // Validate Gmail is not empty
        public bool CheckGmail(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.Gmail);
        }

        // Validate Address is not empty
        public bool CheckAddress(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.Address);
        }

        // Validate Father's Name is not empty
        public bool CheckFatherName(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.FatherName);
        }

        // Validate Mother's Name is not empty
        public bool CheckMotherName(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.MotherName);
        }

        // Validate Parents PhoneNumber: must be 10 digits and numeric
        public bool CheckParentsPhoneNumber(Models.Student student)
        {
            return !string.IsNullOrWhiteSpace(student.ParentsPhoneNumber) &&
                   student.ParentsPhoneNumber.All(char.IsDigit) &&
                   student.ParentsPhoneNumber.Length == 10;
        }

        // Create new student record with user registration
        public int CreateStudent(Models.Student student)
        {
            // Basic validation for required fields (you may want to add more detailed validation)
            if (!string.IsNullOrWhiteSpace(student.FirstName) &&
                !string.IsNullOrWhiteSpace(student.LastName) &&
                student.DateOfBirth != DateTime.MinValue &&
                !string.IsNullOrWhiteSpace(student.Nationality) &&
                !string.IsNullOrWhiteSpace(student.Gender) &&
                !string.IsNullOrWhiteSpace(student.NICno) &&
                !string.IsNullOrWhiteSpace(student.Gmail) &&
                !string.IsNullOrWhiteSpace(student.PhoneNumber) &&
                !string.IsNullOrWhiteSpace(student.Address) &&
                !string.IsNullOrWhiteSpace(student.FatherName) &&
                !string.IsNullOrWhiteSpace(student.MotherName) &&
                !string.IsNullOrWhiteSpace(student.ParentsPhoneNumber))
            {
                // Show user registration form and wait for completion
                User user = new User();
                user.Role = "Student";
                UserRegisterForm userRegister = new UserRegisterForm(user);
                userRegister.ShowDialog();

                if (userRegister.Id > 0)
                {
                    using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                    {
                        string studentQuery = @"
                            INSERT INTO Students(
                                FirstName, LastName, DateOfBirth, Gender, Nationality, NICno,
                                Gmail, PhoneNumber, Address, FatherName, MotherName,
                                ParentsPhoneNumber, UsersID, DepartmentsID, CoursesID)
                            VALUES(
                                @firstName, @lastName, @dateOfBirth, @gender, @nationality, @nicno,
                                @gmail, @phoneNumber, @address, @fatherName, @motherName,
                                @parentsPhoneNumber, @usersID, @departmentsID, @coursesID);
                                SELECT last_insert_rowid();";

                        try
                        {
                            using (SQLiteCommand command = new SQLiteCommand(studentQuery, connect))
                            {
                                command.Parameters.AddWithValue("@firstName", student.FirstName);
                                command.Parameters.AddWithValue("@lastName", student.LastName);
                                command.Parameters.AddWithValue("@dateOfBirth", student.DateOfBirth.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@gender", student.Gender);
                                command.Parameters.AddWithValue("@nationality", student.Nationality);
                                command.Parameters.AddWithValue("@nicno", student.NICno);
                                command.Parameters.AddWithValue("@gmail", student.Gmail);
                                command.Parameters.AddWithValue("@phoneNumber", student.PhoneNumber);
                                command.Parameters.AddWithValue("@address", student.Address);
                                command.Parameters.AddWithValue("@fatherName", student.FatherName);
                                command.Parameters.AddWithValue("@motherName", student.MotherName);
                                command.Parameters.AddWithValue("@parentsPhoneNumber", student.ParentsPhoneNumber);
                                // Use the ID from user registration form here, override any existing UsersID
                                command.Parameters.AddWithValue("@usersID", userRegister.Id);
                                command.Parameters.AddWithValue("@departmentsID", student.DepartmentsID);
                                command.Parameters.AddWithValue("@coursesID", student.CoursesID);
                                object result = command.ExecuteScalar();
                                MessageBox.Show($"Student {student.LastName} Registered Successfully.");
                                return Convert.ToInt32(result);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving student data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User registration cancelled.");
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Complete all student information.");
                return -1;
            }
        }

        // Retrieve student by ID
        public List<Models.Student> GetStudent(int studentId)
        {
            List<Models.Student> students = new List<Models.Student>();

            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string studentQuery = "SELECT * FROM Students WHERE ID = @StudentID;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(studentQuery, connect);
                adapter.SelectCommand.Parameters.AddWithValue("@StudentID", studentId);

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                foreach (DataRow row in datatable.Rows)
                {
                    Models.Student student = new Models.Student
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                        Gender = row["Gender"].ToString(),
                        Nationality = row["Nationality"].ToString(),
                        NICno = row["NICno"].ToString(),
                        Gmail = row["Gmail"].ToString(),
                        PhoneNumber = row["PhoneNumber"].ToString(),
                        Address = row["Address"].ToString(),
                        AdmissionDate = Convert.ToDateTime(row["AdmissionDate"]),
                        FatherName = row["FatherName"].ToString(),
                        MotherName = row["MotherName"].ToString(),
                        ParentsPhoneNumber = row["ParentsPhoneNumber"].ToString(),
                        DepartmentsID = Convert.ToInt32(row["DepartmentsID"]),
                        CoursesID = Convert.ToInt32(row["CoursesID"]),
                        UsersID = Convert.ToInt32(row["UsersID"])
                    };
                    students.Add(student);
                }
            }
            return students;
        }

        // Update existing student record in database
        public void UpdateStudentInDatabase(Models.Student student)
        {
            using (var connect = DatabaseManager.DatabaseConnect())
            {
                string updateQuery = @"
                    UPDATE Students SET 
                        FirstName = @FirstName,
                        LastName = @LastName,
                        DateOfBirth = @DateOfBirth,
                        Gender = @Gender,
                        Nationality = @Nationality,
                        NICno = @NICno,
                        Gmail = @Gmail,
                        PhoneNumber = @PhoneNumber,
                        Address = @Address,
                        FatherName = @FatherName,
                        MotherName = @MotherName,
                        ParentsPhoneNumber = @ParentsPhoneNumber
                    WHERE ID = @ID";

                using (var command = new SQLiteCommand(updateQuery, connect))
                {
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Nationality", student.Nationality);
                    command.Parameters.AddWithValue("@NICno", student.NICno);
                    command.Parameters.AddWithValue("@Gmail", student.Gmail);
                    command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@FatherName", student.FatherName);
                    command.Parameters.AddWithValue("@MotherName", student.MotherName);
                    command.Parameters.AddWithValue("@ParentsPhoneNumber", student.ParentsPhoneNumber);
                    command.Parameters.AddWithValue("@ID", student.ID);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete student record and associated user
        public void DeleteStudent(Models.Student student)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                using (var transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Delete from Students table
                        string deleteStudentQuery = "DELETE FROM Students WHERE ID = @Id";
                        SQLiteCommand deleteStudentCmd = new SQLiteCommand(deleteStudentQuery, connect);
                        deleteStudentCmd.Parameters.AddWithValue("@Id", student.ID);
                        deleteStudentCmd.ExecuteNonQuery();

                        // Delete from Users table
                        string deleteUserQuery = "DELETE FROM Users WHERE ID = @UserId";
                        SQLiteCommand deleteUserCmd = new SQLiteCommand(deleteUserQuery, connect);
                        deleteUserCmd.Parameters.AddWithValue("@UserId", student.UsersID);
                        deleteUserCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Student and associated user deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error while deleting: " + ex.Message);
                    }
                }
            }
        }

        public int RegisterStudentWithSubjects(Student student, int courseId)
        {
            StudentSubjectController controller = new StudentSubjectController();
            int studentId = CreateStudent(student); // implement this method to insert and return new Student ID

            if (studentId > 0)
            {
                SubjectController subjectCtrl = new SubjectController();
                List<Subject> subjects = subjectCtrl.GetSubjectsByCourseId(courseId);

                foreach (var subject in subjects)
                {
                    controller.AddStudentSubjectMapping(studentId, subject.Id);
                }
            }

            return studentId;
        }
        public List<Student> GetStudentsByCourseId(int courseId)
        {
            var students = new List<Student>();

            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string csquery = "SELECT ID, LastName FROM Students WHERE CoursesID = @CourseId";

                using (SQLiteCommand command = new SQLiteCommand(csquery, connect))
                {
                    command.Parameters.AddWithValue("@CourseId", courseId);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                LastName = reader["LastName"].ToString()
                            });
                        }
                    }
                }
            }

            return students;
        }


    }
}
