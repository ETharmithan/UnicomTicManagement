using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Subject
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Credit {get; set; }
        public int DepartmentsID {  get; set; }
        public int StudentsID {  get; set; }
        public int LecturersID {  get; set; }
        public int RoomsID {  get; set; }
        public int CoursesID {  get; set; }
        
    }
}
