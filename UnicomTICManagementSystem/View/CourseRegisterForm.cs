using System;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class CourseRegisterForm : Form
    {
        // Model instance to store course data temporarily
        Course course = new Course();

        // Controller instance to interact with the database
        CourseController courseController = new CourseController();
        DashBoardForm dashBoardForm1;
        // Constructor
        public CourseRegisterForm()
        {
            InitializeComponent();
        }
        public CourseRegisterForm(DashBoardForm dashBoard)
        {
            InitializeComponent();
            this.dashBoardForm1 = dashBoard;
        }

        // Loads the list of departments into the ComboBox when the form loads.
        private void LoadDepartment()
        {
            DepartmentController departmentController = new DepartmentController();
            cc_department.DataSource = departmentController.GetAllDepartments(); // Bind list of departments
            cc_department.DisplayMember = "Name"; // Show the department name in dropdown
            cc_department.ValueMember = "ID";     // Use the ID as the value
        }

        // Button click handler to open the department registration form.
        private void bc_addtodepartment_Click(object sender, EventArgs e)
        {
            dashBoardForm1.LoadForm(new DepartmentRegister(this.dashBoardForm1));
        }

        // Form load event to populate department ComboBox.
        private void CourseRegisterForm_Load(object sender, EventArgs e)
        {
            LoadDepartment(); // Populate departments when form loads
        }

        // TextChanged event for course name input.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            course.Name = textBox1.Text.Trim(); // Save course name
            // lc_name.Text = null; // You can show validation messages here
        }

        // TextChanged event for course description input.
        private void tc_description_TextChanged(object sender, EventArgs e)
        {
            course.Description = tc_description.Text.Trim(); // Save description
            // lc_description.Text = null;
        }

        // TextChanged event for course duration input.
        private void tc_duration_TextChanged(object sender, EventArgs e)
        {
            course.Duration = tc_duration.Text.Trim(); // Save duration
            // lc_duration.Text = null;
        }

        // Clears all form input fields.
        public void ClearField()
        {
            textBox1.Clear();
            tc_description.Clear();
            tc_duration.Clear();
        }

        // Button click handler to clear the form inputs.
        private void bc_clear_Click(object sender, EventArgs e)
        {
            ClearField(); // Clear fields on button click
        }

        // Closes the form (back button).
        private void bc_back_Click(object sender, EventArgs e)
        {
            Close(); // Close the current form
        }

        // Button click handler to save the course into the database.
        private void bc_addtosubject_Click(object sender, EventArgs e)
        {
            // Set selected department ID for the course
            course.DepartmentsID = Convert.ToInt32(cc_department.SelectedValue);

            // Call controller to save course
            courseController.CreateCourse(course);

            // Clear form after successful save
            ClearField();
        }

        // Optional event handler for when department selection changes.
        private void cc_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Can be used for validation or dynamic filtering
        }

        // Opens subject registration form (or subject assignment form).
        private void bc_subject_Click(object sender, EventArgs e)
        {
            dashBoardForm1.LoadForm(new cs_lecturer(this.dashBoardForm1));
        }
        private void bcr_addtosubject_Click(object sender, EventArgs e)
        {

        }
    }
}
