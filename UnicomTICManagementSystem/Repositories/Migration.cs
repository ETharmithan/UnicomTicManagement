using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal static class Migration
    {
        public static void CreateTable()
        {
            using (var connect=DatabaseManager.DatabaseConnect()) 
            {
                string Query = @"CREATE TABLE IF NOT EXISTS Users(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    UserName TEXT NOT NULL,
                                    Password TEXT NOT NULL,
                                    Gmail TEXT NOT NULL,
                                    CreateDate TEXT DEFAULT CURRENT_TIMESTAMP,
                                    UpdateDate TEXT DEFAULT CURRENT_TIMESTAMP);

                                CREATE TABLE IF NOT EXISTS Departments(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Name TEXT NOT NULL,
                                    Description TEXT NOT NULL,
                                    CreateDate TEXT DEFAULT CURRENT_TIMESTAMP);
    
                                CREATE TABLE IF NOT EXISTS Courses(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    DepartmentsID INTEGER,
                                    Name TEXT NOT NULL,
                                    Description TEXT NOT NULL,
                                    Duration TEXT NOT NULL,
                                    FOREIGN KEY (DepartmentsID) REFERENCES Departments(ID));

                                CREATE TABLE IF NOT EXISTS Subjects(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    DepartmentsID INTEGER,
                                    Name TEXT NOT NULL,
                                    Credit INTEGER NOT NULL,
                                    FOREIGN KEY (DepartmentsID) REFERENCES Departments(ID));

                                CREATE TABLE IF NOT EXISTS CoursesSubjects(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    CoursesID INTEGER,
                                    SubjectsID INTEGER,
                                    FOREIGN KEY(CoursesID) REFERENCES Courses(ID),
                                    FOREIGN KEY(SubjectsID) REFERENCES Subjects(ID));

                                CREATE TABLE IF NOT EXISTS Rooms(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Name TEXT NOT NULL,
                                    TYPE TEXT NOT NULL);

                                CREATE TABLE IF NOT EXISTS Admins(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    UsersID INTEGER,
                                    FirstName TEXT NOT NULL,
                                    LastName TEXT NOT NULL,
                                    Nic TEXT NOT NULL,
                                    Gmail TEXT NOT NULL,
                                    PhoneNumber TEXT NOT NULL,
                                    Address TEXT NOT NULL,
                                    Gender TEXT NOT NULL,
                                    CreateDate TEXT DEFAULT CURRENT_TIMESTAMP,
                                    FOREIGN KEY (UsersID) REFERENCES Users(ID));

                                CREATE TABLE IF NOT EXISTS Staffs(
                                    ID  INTEGER PRIMARY KEY  AUTOINCREMENT,
                                    UsersID INTEGER,
                                    FirstName TEXT NOT NULL,
                                    LastName TEXT NOT NULL,
                                    DateofBirth TEXT NOT NULL,
                                    Gender TEXT NOT NULL,
                                    Nationality TEXT NOT NULL,
                                    Nic TEXT NOT NULL,
                                    Gmail TEXT NOT NULL,
                                    PhoneNumber TEXT NOT NULL,
                                    Address TEXT NOT NULL,
                                    MaritalStatus TEXT NOT NULL,
                                    Salary TEXT NOT NULL,
                                    Qualification TEXT NOT NULL,
                                    EmergencyContactInformationRelationName TEXT NOT NULL,
                                    EmergencyContactInformationRelationship TEXT NOT NULL,
                                    EmergencyContactInformationRelationPhoneNumber TEXT NOT NULL,
                                    DateofJoining TEXT DEFAULT CURRENT_TIMESTAMP,
                                    FOREIGN KEY (UsersID) REFERENCES Users(ID));



                                CREATE TABLE IF NOT EXISTS Exams(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    SubjectsID INTEGER,
                                    ExamName TEXT NOT NULL,
                                    Subject TEXT NOT NULL,
                                    Date TEXT NOT NULL,
                                    Duration TEXT NOT NULL,
                                    ExamType TEXT NOT NULL,
                                    Location TEXT NOT NULL,
                                    Status TEXT NOT NULL,
                                    FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID));

                                CREATE TABLE IF NOT EXISTS Students(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    UsersID INTEGER,
                                    DepartmentsID INTEGER,
                                    CoursesID INTEGER,
                                    FirstName TEXT NOT NULL,
                                    LastName TEXT NOT NULL,
                                    DateOfBirth TEXT NOT NULL,
                                    Gender TEXT NOT NULL,
                                    Nationality TEXT NOT NULL,
                                    NICno TEXT NOT NULL,
                                    Gmail TEXT NOT NULL,
                                    PhoneNumber TEXT NOT NULL,
                                    Address TEXT NOT NULL,
                                    AdmissionDate TEXT DEFAULT CURRENT_TIMESTAMP,
                                    FatherName TEXT NOT NULL,
                                    MotherName TEXT NOT NULL,
                                    ParentsPhoneNumber TEXT NOT NULL,
                                    FOREIGN KEY (DepartmentsID) REFERENCES Departments(ID),
                                    FOREIGN KEY (CoursesID) REFERENCES Courses(ID),
                                    FOREIGN KEY (UsersID) REFERENCES Users(ID));

                                CREATE TABLE IF NOT EXISTS Lectures(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT, 
                                    FirstName TEXT NOT NULL,
                                    LastName TEXT NOT NULL,
                                    DateOfBirth TEXT NOT NULL,
                                    Gender TEXT NOT NULL,
                                    Nationality TEXT NOT NULL,
                                    Nic TEXT NOT NULL,
                                    Gmail TEXT NOT NULL,
                                    PhoneNumber TEXT NOT NULL,
                                    Address TEXT NOT NULL,
                                    MaritialStatus TEXT NOT NULL,
                                    EmergencyContactInformationRelation TEXT NOT NULL,
                                    EmergencyContactInformationRelationPhoneNumber TEXT NOT NULL,
                                    DateOfJoining TEXT NOT NULL,
                                    SubjectsID INTEGER,
                                    UsersID INTEGER,
                                    FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID),
                                    FOREIGN KEY (UsersID) REFERENCES Users(ID));

                                CREATE TABLE IF NOT EXISTS Marks(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    StudentsID INTEGER,
                                    SubjectsID INTEGER,
                                    ExamsID INTEGER,
                                    Score TEXT NOT NULL,
                                    Grade TEXT NOT NULL,
                                    FOREIGN KEY (StudentsID) REFERENCES Students(ID),
                                    FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID),
                                    FOREIGN KEY (ExamsID) REFERENCES Exams(ID));

                                CREATE TABLE IF NOT EXISTS Timetables(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Name TEXT NOT NULL,
                                    SubjectsID INTEGER,
                                    FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID));

                                CREATE TABLE IF NOT EXISTS StudentsSubjects(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    StudentsID INTEGER,
                                    SubjectsID INTEGER,
                                    FOREIGN KEY (StudentsID) REFERENCES Students(ID),
                                    FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID));

                                CREATE TABLE IF NOT EXISTS StudentsLectures(
                                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    LecturesID INTEGER,
                                    StudentsID INTEGER,
                                    FOREIGN KEY (StudentsID) REFERENCES Students(ID),
                                    FOREIGN KEY (LecturesID) REFERENCES Lectures(ID));
                                ";
                SQLiteCommand command = new SQLiteCommand(Query, connect);
                command.ExecuteNonQuery();
            }
        }
    }
}
