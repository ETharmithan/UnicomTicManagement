using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class RoomRegister : Form
    {
        Room room = new Room();
        RoomController roomController = new RoomController();
        public RoomRegister()
        {
            InitializeComponent();
        }
        private void cr_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.RoomType = cr_roomtype.SelectedItem.ToString();
            lr_roomtype.Text = null;
        }

        private void tr_roomnumber_TextChanged(object sender, EventArgs e)
        {
            room.RoomNumber = tr_roomnumber.Text;
            lr_roomnumber.Text = null;
        }
        private void tl_capacity_TextChanged(object sender, EventArgs e)
        {
            room.Capacity = tl_capacity.Text;
            lr_capacity.Text = null;
        }
        private void tr_roomnumber_Click(object sender, EventArgs e)
        {
            if (roomController.SelectRoomType(room) == false) { lr_roomtype.Text = "Select the RoomType"; }
        }

        private void tl_capacity_Click(object sender, EventArgs e)
        {
            if (roomController.SelectRoomNumber(room) == false) { lr_roomnumber.Text = "Enter the RoomNumber"; }
        }
        private void Clearfileld()
        {
            cr_roomtype.SelectedValue = -1;
            tr_roomnumber.Clear();
            tl_capacity.Clear();
        }

        private void br_add_Click(object sender, EventArgs e)
        {
            if (roomController.SelectRoomCapacity(room) == false) { lr_capacity.Text = "Enter the Capacity"; }
            roomController.CreateRoom(room);
            Clearfileld();
        }
    }
}
