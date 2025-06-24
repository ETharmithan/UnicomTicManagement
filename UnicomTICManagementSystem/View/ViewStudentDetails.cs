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
    public partial class ViewStudentDetails : Form
    {
        StudentController studentController = new StudentController();
        private List<Models.Student> students = new List<Models.Student>();

        public ViewStudentDetails()
        {
            InitializeComponent();
        }

        private void ViewStudentDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void bs_search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ts_search.Text, out int studentId))
            {
                List<Models.Student> studentList = studentController.GetStudent(studentId);
                students = studentController.GetStudent(studentId);
                ds_student.DataSource = students;
                ds_student.DataSource = studentList;
            }
            else
            {
                MessageBox.Show("Please enter the correct Student Id.");
            }
        }

        private void bs_update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ds_student.Rows)
            {
                if (row.IsNewRow) continue;

                Models.Student s = new Models.Student
                {
                    ID = Convert.ToInt32(row.Cells["ID"].Value),
                    FirstName = row.Cells["FirstName"].Value?.ToString(),
                    LastName = row.Cells["LastName"].Value?.ToString(),
                    DateOfBirth = Convert.ToDateTime(row.Cells["DateOfBirth"].Value),
                    Gender = row.Cells["Gender"].Value?.ToString(),
                    Nationality = row.Cells["Nationality"].Value?.ToString(),
                    NICno = row.Cells["NICno"].Value?.ToString(),
                    Gmail = row.Cells["Gmail"].Value?.ToString(),
                    PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString(),
                    Address = row.Cells["Address"].Value?.ToString(),
                    FatherName = row.Cells["FatherName"].Value?.ToString(),
                    MotherName = row.Cells["MotherName"].Value?.ToString(),
                    ParentsPhoneNumber = row.Cells["ParentsPhoneNumber"].Value?.ToString()
                };

                studentController.UpdateStudentInDatabase(s);
            }

            MessageBox.Show("Updated successfully!");
        }

        private void bs_delete_Click(object sender, EventArgs e)
        {
        
            if (ds_student.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(ds_student.SelectedRows[0].Cells["Id"].Value);

                var student = students.FirstOrDefault(s => s.ID == selectedId);
                if (student != null)
                {
                    
                    studentController.DeleteStudent(student);

                    
                    students.Remove(student);

                    
                    ds_student.DataSource = null;
                    ds_student.DataSource = students;

                    MessageBox.Show("The selected student has been removed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student first.");
            }
        }

        private void bs_addstudent_Click(object sender, EventArgs e)
        {
            StudentRegisterForm1 studentRegisterForm = new StudentRegisterForm1();
            studentRegisterForm.ShowDialog();
        }

        private void bs_back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
