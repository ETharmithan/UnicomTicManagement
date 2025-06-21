using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Exam
    {
        public int ID { get; set; }
        public string ExamName { get; set; }
        public string Date { get; set; }
        public string Duration { get; set; }
        public string ExamType { get; set; }
        public string Status { get; set; }
        public string SubjectsID { get; set; }
        public int StudentsID { get; set; }
        
    }
}
