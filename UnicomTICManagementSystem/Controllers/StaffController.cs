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
    internal class StaffController
    {
        // Validation for FirstName: returns true if not null, empty, or whitespace
        public bool CheckFirstName(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.FirstName);
        }

        // Validation for LastName: returns true if not null, empty, or whitespace
        public bool CheckLastName(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.LastName);
        }

        // Validation for Nationality
        public bool CheckNationality(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.Nationality);
        }

        // Validation for NIC (National ID Card)
        public bool CheckNic(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.Nic);
        }

        // Validation for Gmail (email)
        public bool CheckGmail(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.Gmail);
        }

        // Validation for PhoneNumber: must be 10 digits and numeric
        public bool CheckPhoneNumber(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.PhoneNumber) &&
                   staff.PhoneNumber.All(Char.IsDigit) &&
                   staff.PhoneNumber.Length == 10;
        }

        // Validation for Address
        public bool CheckAddress(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.Address);
        }

        // Validation for Marital Status
        public bool CheckMaritalStatus(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.MaritalStatus);
        }

        // Validation for Emergency Contact Relation Name
        public bool CheckRelation(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationName);
        }

        // Validation for Emergency Contact Relationship description
        public bool CheckRelationship(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationship);
        }

        // Validation for Emergency Contact Phone Number: must be 10 digits and numeric
        public bool CheckRelationPhoneNumber(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.EmergencyContactInformationRelationPhoneNumber) &&
                   staff.EmergencyContactInformationRelationPhoneNumber.All(Char.IsDigit) &&
                   staff.EmergencyContactInformationRelationPhoneNumber.Length == 10;
        }

        // Validation for Salary: must not be empty and greater than zero
        public bool CheckSalary(Staff staff)
        {
            // Convert salary to int, if conversion fails, it throws exception
            if (!string.IsNullOrWhiteSpace(staff.Salary))
            {
                if (int.TryParse(staff.Salary, out int salaryValue))
                {
                    return salaryValue > 0;
                }
            }
            return false;
        }

        // Validation for Qualification
        public bool CheckQualification(Staff staff)
        {
            return !string.IsNullOrWhiteSpace(staff.Qualification);
        }

        // Method to create a new Staff record
        public void CreateStaff(Staff staff)
        {
            // Check if all required staff info is filled properly
            if (!string.IsNullOrWhiteSpace(staff.FirstName) &&
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
                !string.IsNullOrWhiteSpace(staff.Qualification))
            {
                // Show User Registration dialog and wait for completion
                User user = new User();
                user.Role = "Staff";
                UserRegisterForm userRegister = new UserRegisterForm(user);
                userRegister.ShowDialog();

                // If registration is cancelled or failed
                if (userRegister.Id <= 0)
                {
                    MessageBox.Show("User registration was cancelled.");
                    return;
                }

                // If registration succeeded
                if (userRegister.Id > 0)
                {
                    using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                    {
                        string staffQuery = @"INSERT INTO Staffs(
                                                FirstName, LastName, DateofBirth, Gender, Nationality,
                                                Nic, Gmail, PhoneNumber, Address, MaritalStatus, Salary, DateOfJoining,
                                                Qualification, EmergencyContactInformationRelationName,
                                                EmergencyContactInformationRelationship,
                                                EmergencyContactInformationRelationPhoneNumber, UsersID)
                                              VALUES (
                                                @firstname, @lastname, @dateofbirth, @gender, @nationality,
                                                @nic, @gmail, @phonenumber, @address, @maritalstatus, @salary, @dateofjoining,
                                                @qualification, @emergencycontactinformationrelationname,
                                                @emergencycontactinformationrelationship,
                                                @emergencycontactinformationrelationphonenumber, @usersid);";
                        try
                        {
                            using (SQLiteCommand command = new SQLiteCommand(staffQuery, connect))
                            {
                                // Add all parameters to prevent SQL Injection
                                command.Parameters.AddWithValue("@firstname", staff.FirstName);
                                command.Parameters.AddWithValue("@lastname", staff.LastName);
                                command.Parameters.AddWithValue("@dateofbirth", staff.DateOfBirth);
                                command.Parameters.AddWithValue("@gender", staff.Gender);
                                command.Parameters.AddWithValue("@nationality", staff.Nationality);
                                command.Parameters.AddWithValue("@nic", staff.Nic);
                                command.Parameters.AddWithValue("@gmail", staff.Gmail);
                                command.Parameters.AddWithValue("@phonenumber", staff.PhoneNumber);
                                command.Parameters.AddWithValue("@address", staff.Address);
                                command.Parameters.AddWithValue("@maritalstatus", staff.MaritalStatus);
                                command.Parameters.AddWithValue("@salary", staff.Salary);
                                command.Parameters.AddWithValue("@qualification", staff.Qualification);
                                command.Parameters.AddWithValue("@dateofjoining", staff.DateOfJoining);
                                command.Parameters.AddWithValue("@emergencycontactinformationrelationname", staff.EmergencyContactInformationRelationName);
                                command.Parameters.AddWithValue("@emergencycontactinformationrelationship", staff.EmergencyContactInformationRelationship);
                                command.Parameters.AddWithValue("@emergencycontactinformationrelationphonenumber", staff.EmergencyContactInformationRelationPhoneNumber);
                                command.Parameters.AddWithValue("@usersid", userRegister.Id);

                                // Execute insert command
                                command.ExecuteNonQuery();

                                MessageBox.Show($"Staff '{staff.LastName}' Registered Successfully.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Show error message in case of failure
                            MessageBox.Show($"Error saving staff data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Prompt user to fill all fields if incomplete
                MessageBox.Show("Complete all staff information.");
            }
        }

        // Get staff details by staff ID
        public List<Staff> GetStaff(int staffId)
        {
            List<Staff> staffs = new List<Staff>();

            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                string staffQuery = "SELECT * FROM Staffs WHERE ID = @StaffID;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(staffQuery, connect);

                // Add parameter for staff ID
                adapter.SelectCommand.Parameters.AddWithValue("@StaffID", staffId);

                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                // Map each row in DataTable to Staff object
                foreach (DataRow row in datatable.Rows)
                {
                    Staff staff = new Staff
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                        Gender = row["Gender"].ToString(),
                        Nationality = row["Nationality"].ToString(),
                        Nic = row["Nic"].ToString(),
                        Gmail = row["Gmail"].ToString(),
                        PhoneNumber = row["PhoneNumber"].ToString(),
                        MaritalStatus = row["MaritalStatus"].ToString(),
                        Address = row["Address"].ToString(),
                        Salary = row["Salary"].ToString(),
                        Qualification = row["Qualification"].ToString(),
                        DateOfJoining = Convert.ToDateTime(row["DateOfJoining"]),
                        EmergencyContactInformationRelationName = row["EmergencyContactInformationRelationName"].ToString(),
                        EmergencyContactInformationRelationship = row["EmergencyContactInformationRelationship"].ToString(),
                        EmergencyContactInformationRelationPhoneNumber = row["EmergencyContactInformationRelationPhoneNumber"].ToString(),
                        UsersId = Convert.ToInt32(row["UsersId"])
                    };
                    staffs.Add(staff);
                }
            }
            return staffs;
        }

        // Update existing staff information in the database
        public void UpdateStaffInDatabase(Staff staff)
        {
            using (var connect = DatabaseManager.DatabaseConnect())
            {
                string updateQuery = @"UPDATE Staffs SET
                                        FirstName=@FirstName, LastName=@LastName, DateOfBirth=@DateOfBirth, Gender=@Gender,
                                        Nationality=@Nationality, Nic=@Nic, Gmail=@Gmail, PhoneNumber=@PhoneNumber,
                                        Address=@Address, MaritalStatus=@MaritalStatus, Salary=@Salary, Qualification=@Qualification,
                                        DateOfJoining=@DateOfJoining,
                                        EmergencyContactInformationRelationName=@EmergencyContactInformationRelationName,
                                        EmergencyContactInformationRelationship=@EmergencyContactInformationRelationship,
                                        EmergencyContactInformationRelationPhoneNumber=@EmergencyContactInformationRelationPhoneNumber
                                       WHERE Id=@Id";

                using (var command = new SQLiteCommand(updateQuery, connect))
                {
                    // Set all parameters for update
                    command.Parameters.AddWithValue("@FirstName", staff.FirstName);
                    command.Parameters.AddWithValue("@LastName", staff.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", staff.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", staff.Gender);
                    command.Parameters.AddWithValue("@Nationality", staff.Nationality);
                    command.Parameters.AddWithValue("@Nic", staff.Nic);
                    command.Parameters.AddWithValue("@Gmail", staff.Gmail);
                    command.Parameters.AddWithValue("@PhoneNumber", staff.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", staff.Address);
                    command.Parameters.AddWithValue("@MaritalStatus", staff.MaritalStatus);
                    command.Parameters.AddWithValue("@Salary", staff.Salary);
                    command.Parameters.AddWithValue("@Qualification", staff.Qualification);
                    command.Parameters.AddWithValue("@DateOfJoining", staff.DateOfJoining);
                    command.Parameters.AddWithValue("@EmergencyContactInformationRelationName", staff.EmergencyContactInformationRelationName);
                    command.Parameters.AddWithValue("@EmergencyContactInformationRelationship", staff.EmergencyContactInformationRelationship);
                    command.Parameters.AddWithValue("@EmergencyContactInformationRelationPhoneNumber", staff.EmergencyContactInformationRelationPhoneNumber);
                    command.Parameters.AddWithValue("@Id", staff.Id);

                    // Execute the update command
                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete a staff record and the associated user record from the database
        public void DeleteStaff(Staff staff)
        {
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                // Use a transaction to ensure both deletes happen atomically
                using (var transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Delete staff record
                        string deleteStaffQuery = "DELETE FROM Staffs WHERE Id = @Id";
                        SQLiteCommand deleteStaffCmd = new SQLiteCommand(deleteStaffQuery, connect);
                        deleteStaffCmd.Parameters.AddWithValue("@Id", staff.Id);
                        deleteStaffCmd.ExecuteNonQuery();

                        // Delete associated user record
                        string deleteUserQuery = "DELETE FROM Users WHERE Id = @UserId";
                        SQLiteCommand deleteUserCmd = new SQLiteCommand(deleteUserQuery, connect);
                        deleteUserCmd.Parameters.AddWithValue("@UserId", staff.UsersId);
                        deleteUserCmd.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Staff and associated user deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        // Rollback on error to maintain data integrity
                        transaction.Rollback();
                        MessageBox.Show("Error while deleting: " + ex.Message);
                    }
                }
            }
        }
    }
}
