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
    internal class RoomController
    {
        //Select Room Type
        public bool SelectRoomType(Room room)
        {
            if (!string.IsNullOrWhiteSpace(room.RoomType)) { return true; }
            else {  return false; }
        }
        //Enter Room Number
        public bool SelectRoomNumber(Room room)
        {
            if (!string.IsNullOrWhiteSpace(room.RoomNumber)) { return true; }
            else { return false; }
        }
        //Enter Capacity of Room
        public bool SelectRoomCapacity(Room room)
        {
            if (!string.IsNullOrWhiteSpace(room.Capacity)) { return true; }
            else { return false; }
        }
        public void CreateRoom(Room room)
        {
            if(!string.IsNullOrWhiteSpace(room.RoomType) && 
               !string.IsNullOrWhiteSpace(room.RoomNumber) &&
               !string.IsNullOrEmpty(room.Capacity))
            {
                using(SQLiteConnection connect = DatabaseManager.DatabaseConnect())
                {
                    string roomQuery = @"INSERT INTO Rooms(RoomType,RoomNumber,Capacity)
                                         VALUES(@roomtype,@roomnumber,@capacity)";
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(roomQuery, connect))
                        {
                            command.Parameters.AddWithValue("@roomtype", room.RoomType);
                            command.Parameters.AddWithValue("@roomnumber",room.RoomNumber);
                            command.Parameters.AddWithValue("@capacity",room.Capacity);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Room saved successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving room data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public List<Room> GetallRooms()
        {
            List<Room> rooms = new List<Room>();
            using (SQLiteConnection connect = DatabaseManager.DatabaseConnect())
            {
                SQLiteCommand command = connect.CreateCommand();
                command.CommandText = "SELECT * FROM Rooms";
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rooms.Add(new Room
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        RoomNumber = reader["RoomNumber"].ToString()
                    });
                }
            }
            return rooms;
        }
    }
}
