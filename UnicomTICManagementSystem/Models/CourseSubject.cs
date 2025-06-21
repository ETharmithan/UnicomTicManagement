using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class CourseSubject
    {
        public int Id { get; set; }
        public int CoursesId { get; set; }
        public int SubjectsId {  get; set; }
    }
}
