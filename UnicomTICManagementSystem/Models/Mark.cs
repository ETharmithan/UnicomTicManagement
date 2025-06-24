using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Mark
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }

        public string ExamName { get; set; }

        public string Score{get; set; }
        public string Grade{get; set; }
        public int CoursesID { get; set; }
        public int StudentsID {  get; set; }
        public int SubjectsID { get; set; }
        public int ExamsID {  get; set; }

    }
}
