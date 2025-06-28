using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class RoomController
    {
        // Validation: Check if RoomType is provided
        public bool SelectRoomType(Room room)
        {
            // Returns true if RoomType is not null, empty or whitespace
            if (!string.IsNullOrWhiteSpace(room.RoomType))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validation: Check if RoomNumber is provided
        public bool SelectRoomNumber(Room room)
        {
            // Returns true if RoomNumber is not null, empty or whitespace
            if (!string.IsNullOrWhiteSpace(room.RoomNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validation: Check if Capacity is provided
        public bool SelectRoomCapacity(Room room)
        {
            // Returns true if Capacity is not null, empty or whitespace
            if (!string.IsNullOrWhiteSpace(room.Capacity))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a new Room entry in the database if all required fields are filled
        public void CreateRoom(Room room)
        {
            // Check if all required room properties are provided before saving
            if (!string.IsNullOrWhiteSpace(room.RoomType) &&
               !string.IsNullOrWhiteSpace(room.RoomNumber) &&
               !string.IsNullOrWhiteSpace(room.Capacity))  // Changed from IsNullOrEmpty to IsNullOrWhiteSpace for consistency
            {
                // Open database connection
                using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    // SQL Insert command for the Rooms table
                    string roomQuery = @"INSERT INTO Rooms(RoomType, RoomNumber, Capacity)
                                         VALUES(@roomtype, @roomnumber, @capacity)";

                    try
                    {
                        // Execute the insert command with parameterized query to prevent SQL injection
                        using (SQLiteCommand command = new SQLiteCommand(roomQuery, connect))
                        {
                            command.Parameters.AddWithValue("@roomtype", room.RoomType);
                            command.Parameters.AddWithValue("@roomnumber", room.RoomNumber);
                            command.Parameters.AddWithValue("@capacity", room.Capacity);
                            command.ExecuteNonQuery();

                            // Notify user that room is saved successfully
                            MessageBox.Show("Room saved successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show error message if exception occurs during database operation
                        MessageBox.Show($"Error saving room data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Optional: Notify user to fill all required fields before creating a room
                MessageBox.Show("Please fill all required room details.");
            }
        }

        // Retrieve all rooms from the database and return as a list of Room objects
        public List<Room> GetallRooms()
        {
            List<Room> rooms = new List<Room>();

            // Open database connection
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                SQLiteCommand command = connect.CreateCommand();
                command.CommandText = "SELECT * FROM Rooms";  // SQL query to get all rooms

                // Execute the query and get a data reader
                SQLiteDataReader reader = command.ExecuteReader();

                // Read each record and add to the rooms list
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        ID = Convert.ToInt32(reader["ID"]),                // Room ID from database
                        RoomType = reader["RoomType"].ToString(),           // Room Type from database
                        RoomNumber = reader["RoomNumber"].ToString(),       // Room number from database
                        Capacity = reader["Capacity"].ToString()            // Capacity from database

                        // You can add other properties like RoomType, Capacity if needed
                    });
                }
            }

            // Return the list of rooms retrieved from database
            return rooms;
        }
    }
}
