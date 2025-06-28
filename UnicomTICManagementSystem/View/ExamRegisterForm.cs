using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class ExamRegisterForm : Form
    {
        // Create exam object and controller instance
        Exam exam = new Exam();
        ExamController examController = new ExamController();
        DashBoardForm dashBoardform1;
        public ExamRegisterForm()
        {
            InitializeComponent();
        }
        public ExamRegisterForm(DashBoardForm dashBoard)
        {
            InitializeComponent();
            this.dashBoardform1 = dashBoard;
        }

        // Load all available courses into dropdown
        private void LoadCourses()
        {
            CourseController courseController = new CourseController();
            ce_course.DataSource = courseController.GetAllCourses();
            ce_course.DisplayMember = "Name";  // Display course name
            ce_course.ValueMember = "Id";      // Bind selected value to ID
            ce_course.SelectedIndex = -1;      // Default unselected
        }

        // Load all available rooms into dropdown
        private void LoadRooms()
        {
            RoomController roomController = new RoomController();
            ce_room.DataSource = roomController.GetallRooms();
            ce_room.DisplayMember = "RoomNumber";  // Display room number
            ce_room.ValueMember = "ID";            // Bind value to room ID
            ce_room.SelectedIndex = -1;            // Default unselected
        }

        // Called when the form loads
        private void ExamRegisterForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadRooms();
        }

        // Save exam name as user types
        private void te_name_TextChanged(object sender, EventArgs e)
        {
            exam.ExamName = te_name.Text.Trim();
            le_name.Text = null;
        }

        // Save exam date
        private void de_date_ValueChanged(object sender, EventArgs e)
        {
            exam.ExamDate = de_date.Value;
            le_date.Text = null;
        }

        // Save exam time
        private void de_time_ValueChanged(object sender, EventArgs e)
        {
            exam.ExamTime = de_time.Value;
            le_time.Text = null;
        }

        // Save exam type from dropdown
        private void ce_examtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            exam.ExamType = ce_examtype.Text;
        }

        // Clear exam type label error on click
        private void ce_examtype_Click(object sender, EventArgs e)
        {
            le_examtype.Text = null;
        }

        // Save exam duration
        private void te_duration_TextChanged(object sender, EventArgs e)
        {
            exam.Duration = te_duration.Text.Trim();
            le_duration.Text = null;
        }

        // Save remarks
        private void te_remarks_TextChanged(object sender, EventArgs e)
        {
            exam.Remarks = te_remarks.Text.Trim();
            le_remarks.Text = null;
        }

        // Save exam status (e.g., Scheduled, Completed)
        private void ce_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            exam.Status = ce_status.Text;
            le_status.Text = null;
        }

        // Load subjects related to selected course
        private void LoadSubjectsByCourse(int courseId)
        {
            SubjectController subjectController = new SubjectController();
            var subjects = subjectController.GetSubjectsByCourseId(courseId);
            ce_subject.DataSource = subjects;
            ce_subject.DisplayMember = "Name";
            ce_subject.ValueMember = "Id";
        }

        // When course is selected, update subject dropdown and set CourseID
        private void ce_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ce_course.SelectedItem is Course selectedCourse)
            {
                exam.CoursesID = selectedCourse.Id;
                LoadSubjectsByCourse(selectedCourse.Id);
                ce_subject.Enabled = true;
            }
            else
            {
                ce_subject.DataSource = null;
                ce_subject.Enabled = false;
            }
        }

        // Save selected RoomID
        private void ce_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ce_room.SelectedItem is Room selectedRoom)
            {
                exam.RoomsID = selectedRoom.ID;
            }
        }

        // Save SubjectID from subject dropdown
        private int selectedSubjectId = 0;
        private void ce_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ce_subject.SelectedItem is Subject selected)
            {
                selectedSubjectId = selected.Id;
                exam.SubjectsID = selected.Id;
            }
        }

        // Clears all form fields
        private void ClearField()
        {
            te_name.Clear();
            ce_course.SelectedIndex = -1;
            ce_subject.DataSource = null;
            ce_examtype.SelectedIndex = -1;
            te_duration.Clear();
            ce_room.SelectedIndex = -1;
            te_remarks.Clear();
            ce_status.SelectedIndex = -1;
        }

        // Save exam into database
        private void be_register_Click(object sender, EventArgs e)
        {
            // Minimal validation check
            if (string.IsNullOrWhiteSpace(te_name.Text) || ce_course.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            examController.CreateExam(exam); // Save to DB
            //ClearField(); // Uncomment if auto-clear is preferred
        }

        // Clear button handler
        private void be_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        // Back/close the form
        private void be_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Unused label click event handlers (optional to remove for cleaner code)
        private void label21_Click(object sender, EventArgs e) { }
        private void label20_Click(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void ce_roomtype_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
