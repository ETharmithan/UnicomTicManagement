using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class ExamRegisterForm : Form
    {
        Exam exam = new Exam();
        ExamController examController = new ExamController();
        public ExamRegisterForm()
        {
            InitializeComponent();
        }
        private void LoadCourses()
        {
            CourseController courseController = new CourseController();
            ce_course.DataSource = courseController.GetAllCourses();
            ce_course.DisplayMember = "Name";
            ce_course.ValueMember = "Id";
            ce_course.SelectedIndex = -1;
        }
        private void LoadRooms()
        {
            RoomController roomController = new RoomController();
            ce_room.DataSource = roomController.GetallRooms();
            ce_room.DisplayMember = "RoomNumber";
            ce_room.ValueMember = "ID";
            ce_room.SelectedIndex = -1;
        }
        private void ExamRegisterForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadRooms();
        }
        private void te_name_TextChanged(object sender, EventArgs e)
        {
            exam.ExamName = te_name.Text;
            le_name.Text = null;
        }
        private void de_date_ValueChanged(object sender, EventArgs e)
        {
            exam.ExamDate = de_date.Value;
            le_date.Text = null;
        }
        private void de_time_ValueChanged(object sender, EventArgs e)
        {
            exam.ExamTime = de_time.Value;
            le_time.Text = null;
        }
        private void ce_examtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            exam.ExamType = ce_examtype.Text;
        }
        private void ce_examtype_Click(object sender, EventArgs e)
        {
            le_examtype.Text = null;
        }
        private void te_duration_TextChanged(object sender, EventArgs e)
        {
            exam.Duration = te_duration.Text;
            le_duration.Text = null;
        }
        private void te_remarks_TextChanged(object sender, EventArgs e)
        {
            exam.Remarks = te_remarks.Text;
            le_remarks.Text = null;
        }
        private void ce_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            exam.Status = ce_status.Text;
            le_status.Text = null;
        }
        private void LoadSubjectsByCourse(int courseId) 
        {
            SubjectController subjectController = new SubjectController();
            var subjects = subjectController.GetSubjectsByCourseId(courseId);
            ce_subject.DataSource = subjects;
            ce_subject.DisplayMember = "Name";
            ce_subject.ValueMember = "Id";
        }


        private void ce_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ce_course.SelectedItem is Course SelectedCourse) 
            {
                int courseId =SelectedCourse.Id;
                exam.CoursesID = courseId;
                LoadSubjectsByCourse(courseId);
                ce_subject.Enabled = true;
            }
            else
            {
                ce_subject.DataSource = null;
                ce_subject.Enabled = false;
            }
        }
        private void ce_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ce_room.SelectedItem is Room SelectedRoom)
            {
                int roomid = SelectedRoom.ID;
                exam.RoomsID = roomid;
            }
        }
        private int selectedSubjectId = 0;
        private void ce_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ce_subject.SelectedItem is Subject selected)
            {
                selectedSubjectId = selected.Id;
                exam.SubjectsID = selected.Id;
            } 
        }
        private void ClearField()
        {
            te_name.Clear();
            ce_course.SelectedIndex = -1;
            ce_subject.SelectedIndex = -1;
            ce_examtype.SelectedIndex = -1;
            te_duration.Clear();
            ce_room.SelectedIndex = -1;
            te_remarks.Clear();
            ce_status.SelectedIndex = -1;
        }
        private void be_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(te_name.Text) || ce_course.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            examController.CreateExam(exam);
            //ClearField();
        }
        private void be_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void be_back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ce_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
