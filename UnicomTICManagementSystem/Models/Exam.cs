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
        public DateTime ExamDate { get; set; }
        public DateTime ExamTime {  get; set; }
        public string ExamType { get; set; }
        public string Duration { get; set; }
        public string Remarks {  get; set; }
        public string Status { get; set; }
        public string RoomType {  get; set; }
        public string Room {  get; set; }
        public int CoursesID {  get; set; }
        public int SubjectsID { get; set; }
        public int StudentsID { get; set; }
        public int RoomsID {  get; set; }
        
    }
}
