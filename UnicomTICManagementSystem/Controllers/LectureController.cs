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
    internal class LectureController
    {
        //Firstname Checked Validation
        public bool CheckFirsteName(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.FirstName)) { return true; }
            else { return false; }
        }
        //LastName Checked Validation
        public bool CheckLastName(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.LastName)) { return true; }
            else { return false; }
        }
        //NICNo Checked Validation
        public bool CheckNationality(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Nationality)) { return true; }
            else { return false; }
        }
        //NICNo Checked Validation
        public bool CheckNIC(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.NICno)) { return true; }
            else { return false; }
        }
        //Gmail Checked Validation
        public bool CheckGmail(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Gmail)) { return true; }
            else { return false; }
        }
        //Phone Number Checked Validation
        public bool CheckPhoneNumber(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.PhoneNumber) && lecture.PhoneNumber.All(Char.IsDigit) && lecture.PhoneNumber.Length == 10) { return true; }
            else { return false; }
        }
        //Address Checked Validation
        public bool CheckAddress(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Address)) { return true; }
            else { return false; }
        }
        //DateOfBirth Checked Validation
        public bool CheckDateofBirth(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.DateOfBirth)) { return true; }
            else { return false; }
        }
        //Gender Checked Validation
        public bool CheckGender(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Gender)) { return true; }
            else { return false; }
        }
        //Marital Status Checked Validation
        public bool CheckMaritalStatus(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.MaritalStatus)) { return true; }
            else { return false; }
        }
        //Salary Checked Validation
        public bool CheckSalary(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Salary)) { return true; }
            else { return false; }
        }
        //Qualification Checked Validation
        public bool CheckQualification(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Qualification)) { return true; }
            else { return false; }
        }
        //Relation Name Checked Validation
        public bool CheckRelationName(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.RelationName)) { return true; }
            else { return false; }
        }
        //Relation Ship Checked Validation
        public bool CheckRelationShip(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Relationship)) { return true; }
            else { return false; }
        }
        //Relation Phone Number Checked Validation
        public bool CheckRelationphoneNumber(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.Relationnumber) && lecture.Relationnumber.All(Char.IsDigit) && lecture.Relationnumber.Length == 10) { return true; }
            else { return false; }
        }
        public void CreateLecture(Lecture lecture)
        {
            if (!string.IsNullOrWhiteSpace(lecture.FirstName) &&
                !string.IsNullOrWhiteSpace(lecture.LastName) &&
                !string.IsNullOrWhiteSpace(lecture.DateOfBirth) &&
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
                //Database Connect
                using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    string lecturerQuery = @"INSERT INTO Lecturers (
                                            FirstName, LastName, DateOfBirth, Gender, Nationality, NICno,
                                            Gmail, PhoneNumber, Address, MaritalStatus, RelationName,
                                            Relationship, Relationnumber, Salary, Qualification,
                                            SubjectsID, UsersID, DepartmentsID, StudentsID) 
                                            VALUES (@firstName, @lastName, @dateOfBirth, @gender, @nationality, @nicno,
                                            @gmail, @phoneNumber, @address, @maritalStatus, @relationName,
                                            @relationship, @relationNumber, @salary, @qualification,
                                            @subjectsID, @usersID, @departmentsID, @studentsID)";
                    try
                    {
                        using(SQLiteCommand command = new SQLiteCommand(lecturerQuery, connect))
                        {
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
                            command.Parameters.AddWithValue("@subjectsID", lecture.SubjectsID);
                            command.Parameters.AddWithValue("@usersID", lecture.UsersID);
                            command.Parameters.AddWithValue("@departmentsID", lecture.DepartmentsID);
                            command.Parameters.AddWithValue("@studentsID", lecture.StudentsID);
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Lecturer {lecture.LastName} Registered Successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving lecturer data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete all lecturer information.");
            }
        }
    }
}
