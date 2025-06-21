using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class LecturerSubject
    {
        public int Id { get; set; }
        public int LecturersID {  get; set; }
        public int SubjectsID {  get; set; }
    }
}
