using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Room
    {
        public int ID { get; set; }
        public string RoomType {  get; set; }
        public string RoomNumber {  get; set; }
        public string IsAvailable {  get; set; }
        public string Capacity {  get; set; }
        public int ExamsID { get; set; }
        public int SubjectsID {  get; set; }
    }
}
