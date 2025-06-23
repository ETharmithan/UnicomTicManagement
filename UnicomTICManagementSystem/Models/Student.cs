using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string NICno { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FatherName { get; set; }
        public string MotherName {  get; set; }
        public string ParentsPhoneNumber { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string DepartmentName { get; set; }
        public string CourseName { get; set; }
        public int UsersID {  get; set; }
        public int DepartmentsID {  get; set; }
        public int CoursesID {  get; set; }
    }
}
