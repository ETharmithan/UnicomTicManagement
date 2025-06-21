using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Staff
    {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string Nationality { get; set; }
            public string Nic { get; set; }
            public string Gmail { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string MaritalStatus { get; set; }
            public string EmergencyContactInformationRelationName { get; set; }
            public string EmergencyContactInformationRelationship {get; set; }
            public string EmergencyContactInformationRelationPhoneNumber { get; set; }
            public DateTime DateOfJoining { get; set; }
            public DateTime UpdateDate {  get; set; }
            public string Salary { get; set; }      
            public string Qualification { get; set; }
            public int UsersId { get; set; }
    }
}
