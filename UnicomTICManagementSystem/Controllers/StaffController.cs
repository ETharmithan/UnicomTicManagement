using System;
using System.Collections.Generic;
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
    internal class StaffController
    {
        //Firstname Checked Validation
        public bool CheckFirstName(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.FirstName)) { return true; }
            else {  return false; }
        }
        //Lastname Checked Validation
        public bool CheckLastName(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.LastName)) {  return true; }
            else { return false; }
        }
        //Nationality Checked Validation
        public bool CheckNationality(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.Nationality)) { return true; }
            else { return false; }
        }
        //Nic Checked Validation
        public bool CheckNic(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.Nic)) { return true; }
            else { return false; }
        }
        //Gmail Checked Validation
        public bool CheckGmail(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.Gmail)) { return true; }
            else { return false; }
        }
        //Phone Number Checked Validation
        public bool CheckPhoneNumber(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.PhoneNumber) && staff.PhoneNumber.All(Char.IsDigit) && staff.PhoneNumber.Length == 10) { return true; }
            else { return false; }
        }
        //Address Checked Validation
        public bool CheckAddress(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.Address)) { return true; }
            else { return false; }
        }
        //Marital Status Checked Validation
        public bool CheckMaritalStatus(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.MaritalStatus)) {  return true; }
            else { return false; }
        }
        //Staff Relation Checked Validation
        public bool CheckRelation(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationName)) { return true; }
            else { return false; }
        }
        //Staff Relationship Checked Validation
        public bool CheckRelationship(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationship)) { return true; }
            else { return false; }
        }
        //Staff Relation PhoneNumber Checked Validation
        public bool CheckRelationPhoneNumber(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationPhoneNumber) && staff.EmergencyContactInformationRelationPhoneNumber.All(Char.IsDigit) && staff.EmergencyContactInformationRelationPhoneNumber.Length == 10) { return true; }
            else { return false; }
        }
        //Staff Salary Checked
        public bool CheckSalary(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.Salary) && Convert.ToInt32(staff.Salary)>0) {  return true; }
            else { return false; }
        }
        //Staff Qualification Checked
        public bool CheckQualification(Staff staff)
        {
            if (!string.IsNullOrWhiteSpace(staff.Qualification)) { return true; }
            else { return false; }
        }

        public void CreateStaff(Staff staff)
        {
            if(!string.IsNullOrWhiteSpace(staff.FirstName) &&
               !string.IsNullOrWhiteSpace(staff.LastName) &&
                staff.DateOfBirth != DateTime.MinValue &&
               !string.IsNullOrWhiteSpace(staff.Gender) &&
               !string.IsNullOrWhiteSpace(staff.Nationality) &&
               !string.IsNullOrWhiteSpace(staff.Nic) &&
               !string.IsNullOrWhiteSpace(staff.Gmail) &&
               !string.IsNullOrWhiteSpace(staff.PhoneNumber) &&
               !string.IsNullOrWhiteSpace(staff.Address) &&
               !string.IsNullOrWhiteSpace(staff.MaritalStatus) &&
               !string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationName) &&
               !string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationship) &&
               !string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationPhoneNumber) &&
               !string.IsNullOrWhiteSpace(staff.Salary) &&
               !string.IsNullOrWhiteSpace(staff.Qualification)
               )
            {
                UserRegisterForm userRegister = new UserRegisterForm();
                userRegister.ShowDialog();
                if (userRegister.Id > 0)
                {
                    using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                    {
                        string staffQuery = @"INSERT INTO Staffs(
                                            FirstName,LastName,DateofBirth,Gender,Nationality,
                                            Nic,Gmail,PhoneNumber,Address,MaritalStatus,Salary,
                                            Qualification,EmergencyContactInformationRelationName,
                                            EmergencyContactInformationRelationship,
                                            EmergencyContactInformationRelationPhoneNumber,UsersID)
                                            VALUES (@firstname,@lastname,@dateofbirth,@gender,@nationality,
                                            @nic,@gmail,@phonenumber,@address,@maritalstatus,@salary,
                                            @qualification,@emergencycontactinformationrelationname,
                                            @emergencycontactinformationrelationship,
                                            @emergencycontactinformationrelationphonenumber,@usersid);";
                        try
                        {
                            using(SQLiteCommand command = new SQLiteCommand(staffQuery, connect))
                            {
                                command.Parameters.AddWithValue("@firstname",staff.FirstName);
                                command.Parameters.AddWithValue("@lastname",staff.LastName);
                                command.Parameters.AddWithValue("@dateofbirth", staff.DateOfBirth);
                                command.Parameters.AddWithValue("@gender",staff.Gender);
                                command.Parameters.AddWithValue("@nationality", staff.Nationality);
                                command.Parameters.AddWithValue("@nic", staff.Nic);
                                command.Parameters.AddWithValue("@gmail", staff.Gmail);
                                command.Parameters.AddWithValue("@phonenumber", staff.PhoneNumber);
                                command.Parameters.AddWithValue("@address",staff.Address);
                                command.Parameters.AddWithValue("@maritalstatus", staff.MaritalStatus);
                                command.Parameters.AddWithValue("@salary", staff.Salary);
                                command.Parameters.AddWithValue("@qualification", staff.Qualification);
                                command.Parameters.AddWithValue("@emergencycontactinformationrelationname", staff.EmergencyContactInformationRelationName);
                                command.Parameters.AddWithValue("@emergencycontactinformationrelationship", staff.EmergencyContactInformationRelationship);
                                command.Parameters.AddWithValue("@emergencycontactinformationrelationphonenumber", staff.EmergencyContactInformationRelationPhoneNumber);
                                command.Parameters.AddWithValue("@usersid", userRegister.Id);
                                command.ExecuteNonQuery();
                                MessageBox.Show($"Staff '{staff.LastName}' Registered Successfully.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving staff data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete all staff information.");
                
            }
        }
    }
}
