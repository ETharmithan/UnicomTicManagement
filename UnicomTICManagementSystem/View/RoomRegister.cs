using System;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;
using System.Collections.Generic;


namespace UnicomTICManagementSystem.View
{
    public partial class RoomRegister : Form
    {
        private Room room = new Room();
        private RoomController roomController = new RoomController();

        DashBoardForm dashboardForm1;
        public RoomRegister()
        {
            InitializeComponent();
        }
        public RoomRegister(DashBoardForm dashBoardForm)
        {
            InitializeComponent();
            this.dashboardForm1 = dashBoardForm;
        }

        // === Event Handlers ===

        // Room Type selection
        private void cr_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cr_roomtype.SelectedItem != null)
            {
                room.RoomType = cr_roomtype.SelectedItem.ToString();
                lr_roomtype.Text = null;
            }
        }

        // Room Number input
        private void tr_roomnumber_TextChanged(object sender, EventArgs e)
        {
            room.RoomNumber = tr_roomnumber.Text.Trim();
            lr_roomnumber.Text = null;
        }

        // Capacity input
        private void tl_capacity_TextChanged(object sender, EventArgs e)
        {
            room.Capacity = tl_capacity.Text.Trim();
            lr_capacity.Text = null;
        }

        // Clicking into Room Number triggers validation (optional)
        private void tr_roomnumber_Click(object sender, EventArgs e)
        {
            if (!roomController.SelectRoomType(room))
            {
                lr_roomtype.Text = "Please select a Room Type.";
            }
        }

        // Clicking into Capacity triggers validation (optional)
        private void tl_capacity_Click(object sender, EventArgs e)
        {
            if (!roomController.SelectRoomNumber(room))
            {
                lr_roomnumber.Text = "Please enter a Room Number.";
            }
        }

        // Add Room
        private void br_add_Click(object sender, EventArgs e)
        {
            // Inline validation (you could also do this in RoomController if desired)
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(room.RoomType))
            {
                lr_roomtype.Text = "Select Room Type.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(room.RoomNumber))
            {
                lr_roomnumber.Text = "Enter Room Number.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(room.Capacity))
            {
                lr_capacity.Text = "Enter Capacity.";
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            try
            {
                roomController.CreateRoom(room);
                MessageBox.Show("Room registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back Button
        private void br_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadRoomsToGrid()
        {
            List <Room> roomlist = roomController.GetallRooms();
            dr_room.DataSource = roomlist;
        }

        // Form Load (can be used for initializing RoomType options if needed)
        private void RoomRegister_Load(object sender, EventArgs e)
        {
            // Example if needed:
            // cr_roomtype.Items.AddRange(new string[] { "Lecture", "Lab", "Seminar" });
            LoadRoomsToGrid();
            cr_roomtype.SelectedIndex = -1;
            br_update.Visible = false;
            br_delete.Visible = false;
        }

        // === Utilities ===

        private void ClearFields()
        {
            cr_roomtype.SelectedIndex = -1;
            tr_roomnumber.Clear();
            tl_capacity.Clear();
            room = new Room(); // reset state
        }

        private void br_update_Click(object sender, EventArgs e)
        {

        }
    }
}
