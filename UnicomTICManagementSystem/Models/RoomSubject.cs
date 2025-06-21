using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class RoomSubject
    {
        public int Id { get; set; }
        public int RoomsID {  get; set; }
        public int SubjectsID {  get; set; }
    }
}
