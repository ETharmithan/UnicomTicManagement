using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.View;

namespace UnicomTICManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Migration.CreateTable();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdminRegisterForm());
            //Application.Run(new StaffRegisterForm());
            //Application.Run(new DepartmentRegister());
            //Application.Run(new CourseRegisterForm());
            //Application.Run(new cs_lecturer());
            //Application.Run(new StudentRegisterForm1());
            //Application.Run(new LecturerRegisterForm1());
            Application.Run(new UserSigninForm());
            //Application.Run(new RoomRegister());
            //Application.Run(new ExamRegisterForm());
            //Application.Run(new ViewStudentDetails());
            //Application.Run(new ViewStaffDetails());
            //Application.Run(new ViewLectureDetails());
            //Application.Run(new ViewSubjects());
            //Application.Run(new MarkRegister());
            //Application.Run(new DashBoardForm());
            //Application.Run(new ViewAdmin());

        }
    }
}
