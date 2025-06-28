using System;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class DepartmentRegister : Form
    {
        // Instance of Department model to store user input
        Department department = new Department();

        // Controller to manage department-related database operations
        DepartmentController departmentController = new DepartmentController();
        DashBoardForm dashBoardForm1;
        // Constructor
        public DepartmentRegister()
        {
            InitializeComponent();
        }
        public DepartmentRegister(DashBoardForm dashBoard)
        {
            InitializeComponent();
            this.dashBoardForm1 = dashBoard;
        }

        // Triggered when the department name textbox content changes.
        // Saves input and clears validation label.
        private void td_name_TextChanged(object sender, EventArgs e)
        {
            department.Name = td_name.Text.Trim(); // Store department name
            ld_name.Text = null;                   // Clear any previous validation message
        }

        // Triggered when the department description textbox content changes.
        // Saves input and clears validation label.
        private void td_description_TextChanged(object sender, EventArgs e)
        {
            department.Description = td_description.Text.Trim(); // Store description
            ld_description.Text = null;                          // Clear previous validation error
        }

        // Clears all input fields in the form.
        public void ClearField()
        {
            td_name.Clear();
            td_description.Clear();
        }

        // Clears the form when the "Clear" button is clicked.
        private void bd_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        // Validates inputs and adds department details to the database.
        private void bd_add_Click(object sender, EventArgs e)
        {
            // Show validation errors if fields are missing
            if (!departmentController.CheckedName(department))
            {
                ld_name.Text = "Enter the Department Name";
                return;
            }
            if (!departmentController.CheckedDescription(department))
            {
                ld_description.Text = "Enter the Department Description";
                return;
            }

            // Create department using controller
            departmentController.CreateDepartment(department);

            // Clear form after successful entry
            ClearField();
        }

        // Opens the Course Registration Form.
        private void bd_addtocourse_Click(object sender, EventArgs e)
        {
            dashBoardForm1.LoadForm(new CourseRegisterForm(this.dashBoardForm1));
        }

        // Closes the current form (Back button).
        private void bd_back_Click(object sender, EventArgs e)
        {
            Close(); // Exit this form
        }
    }
}
