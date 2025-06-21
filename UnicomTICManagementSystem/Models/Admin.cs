using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Admin
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string NIC { get; set; }
        public string Gmail {  get; set; }
        public string PhoneNumber {  get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int UsersId { get; set; }

        
    }
}
