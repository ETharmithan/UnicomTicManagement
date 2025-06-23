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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.View
{
    public partial class ViewLectureDetails : Form
    {
        LectureController lectureController = new LectureController();
        private List<Lecture> lecturers = new List<Lecture>();
        public ViewLectureDetails()
        {
            InitializeComponent();
        }

        private void bl_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tl_search.Text, out int lectureId))
            {
                List<Lecture> lecturerList = lectureController.GetLecturer(lectureId);
                lecturers = lectureController.GetLecturer(lectureId);
                dl_lecturer.DataSource = lecturers;
                dl_lecturer.DataSource = lecturerList;
            }
            else
            {
                MessageBox.Show("Please enter the correct Staff Id.");
            }
        }

        private void bl_update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dl_lecturer.Rows)
            {
                if (row.IsNewRow) continue;

                Lecture le = new Lecture
                {
                    Id = Convert.ToInt32(row.Cells["ID"].Value),
                    FirstName = row.Cells["FirstName"].Value?.ToString(),
                    LastName = row.Cells["LastName"].Value?.ToString(),
                    DateOfBirth = Convert.ToDateTime(row.Cells["DateOfBirth"].Value),
                    Gender = row.Cells["Gender"].Value?.ToString(),
                    Nationality = row.Cells["Nationality"].Value?.ToString(),
                    NICno = row.Cells["NICno"].Value?.ToString(),
                    Gmail = row.Cells["Gmail"].Value?.ToString(),
                    PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString(),
                    MaritalStatus = row.Cells["MaritalStatus"].Value?.ToString(),
                    Address = row.Cells["Address"].Value?.ToString(),
                    Salary = row.Cells["Salary"].Value?.ToString(),
                    Qualification = row.Cells["Qualification"].Value?.ToString(),
                    RelationName = row.Cells["RelationName"].Value?.ToString(),
                    Relationship = row.Cells["Relationship"].Value?.ToString(),
                    Relationnumber = row.Cells["Relationnumber"].Value?.ToString()
                };

                lectureController.UpdateLecturerInDatabase(le);
            }

            MessageBox.Show("Updated successfully!");
        }

        private void bl_delete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(dl_lecturer.SelectedRows[0].Cells["ID"].Value);

            var lecturer = lecturers.FirstOrDefault(le => le.Id == selectedId);
            if (lecturer != null)
            {
                lectureController.DeleteLecturer(lecturer);
                lecturers.Remove(lecturer);
                dl_lecturer.DataSource = null;
                dl_lecturer.DataSource = lecturers;

                MessageBox.Show("The selected staff has been removed.");
            }
            else
            {
                MessageBox.Show("Please select a staff first.");
            }
        }

        private void bl_addregister_Click(object sender, EventArgs e)
        {
            LecturerRegisterForm1 lecturerRegisterForm = new LecturerRegisterForm1();
            lecturerRegisterForm.ShowDialog();
        }

        private void bl_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
