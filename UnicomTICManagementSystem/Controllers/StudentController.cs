using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.View;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        //Phone Number Checked Validation
        public bool CheckPhoneNumber(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.PhoneNumber) && student.PhoneNumber.All(Char.IsDigit) && student.PhoneNumber.Length == 10) { return true; }
            else { return false; }
        }
        //Firstname Checked Validation
        public bool CheckFirsteName(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.FirstName)) { return true; }
            else { return false; }
        }
        //LastName Checked Validation
        public bool CheckLastName(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.LastName)) { return true; }
            else { return false; }
        }
        //NICNo Checked Validation
        public bool CheckNIC(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.NICno)) { return true; }
            else { return false; }
        }
        //NICNo Checked Validation
        public bool CheckNationality(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.Nationality)) { return true; }
            else { return false; }
        }
        //Gmail Checked Validation
        public bool CheckGmail(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.Gmail)) { return true; }
            else { return false; }
        }
        //Address Checked Validation
        public bool CheckAddress(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.Address)) { return true; }
            else { return false; }
        }
        //FatherName Checked Validation
        public bool CheckFatherName(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.FatherName)) { return true; }
            else { return false; }
        }
        //MotherName Checked Validation
        public bool CheckMotherName(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.MotherName)) { return true; }
            else { return false; }
        }
        //ParentsPhoneNumber Checked Validation
        public bool CheckParentsPhoneNumber(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.ParentsPhoneNumber) && student.ParentsPhoneNumber.All(Char.IsDigit) && student.ParentsPhoneNumber.Length == 10) { return true; }
            else { return false; }
        }
        public void CreateStudent(Student student)
        {
            if (!string.IsNullOrWhiteSpace(student.FirstName) &&
                !string.IsNullOrWhiteSpace(student.LastName) &&
                !string.IsNullOrWhiteSpace(student.DateOfBirth.ToString()) &&
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
                UserRegisterForm userRegister = new UserRegisterForm();
                userRegister.ShowDialog();
                if (userRegister.Id > 0)
                {
                    //DataBase Connect
                    using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                    {
                        string studentQuery = @"INSERT INTO Students(
                                            FirstName, LastName, DateOfBirth, Gender, Nationality, NICno,
                                            Gmail, PhoneNumber, Address, FatherName, MotherName,
                                            ParentsPhoneNumber, UsersID, DepartmentsID, CoursesID)
                                            VALUES(
                                            @firstName, @lastName, @dateofbirth, @gender, @nationality, @nicno,
                                            @gmail, @phoneNumber, @address, @fatherName, @motherName,
                                            @parentsPhoneNumber, @usersID, @departmentsID, @coursesID);";
                        try
                        {
                            //Excute the Database
                            using (SQLiteCommand command = new SQLiteCommand(studentQuery, connect))
                            {
                                command.Parameters.AddWithValue("@firstName", student.FirstName);
                                command.Parameters.AddWithValue("@lastName", student.LastName);
                                command.Parameters.AddWithValue("@dateofbirth", student.DateOfBirth.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@gender", student.Gender);
                                command.Parameters.AddWithValue("@nationality", student.Nationality);
                                command.Parameters.AddWithValue("@nicno", student.NICno);
                                command.Parameters.AddWithValue("@gmail", student.Gmail);
                                command.Parameters.AddWithValue("@phoneNumber", student.PhoneNumber);
                                command.Parameters.AddWithValue("@address", student.Address);
                                command.Parameters.AddWithValue("@fatherName", student.FatherName);
                                command.Parameters.AddWithValue("@motherName", student.MotherName);
                                command.Parameters.AddWithValue("@parentsPhoneNumber", student.ParentsPhoneNumber);
                                command.Parameters.AddWithValue("@usersID", student.UsersID);
                                command.Parameters.AddWithValue("@departmentsID", student.DepartmentsID);
                                command.Parameters.AddWithValue("@coursesID", student.CoursesID);
                                command.Parameters.AddWithValue("@usersID", userRegister.Id);
                                command.ExecuteNonQuery();
                                MessageBox.Show($"Student {student.LastName} Registered Successfully.");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Error saving student data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Complete all student information.");
            }
        }
    }
}
