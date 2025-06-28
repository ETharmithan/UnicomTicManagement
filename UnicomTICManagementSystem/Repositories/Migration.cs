using System;
using System.Data.SQLite;

namespace UnicomTICManagementSystem.Repositories
{

    internal static class Migration
    {
        public static void CreateTable()
        {
            using (var connect = DatabaseManager.DatabaseConnect())
            {
                // SQL statements to create tables if they do not exist
                string Query = @"
                    -- Users table for authentication
                    CREATE TABLE IF NOT EXISTS Users(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserName TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Gmail TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        CreateDate TEXT DEFAULT CURRENT_TIMESTAMP,
                        UpdateDate TEXT DEFAULT CURRENT_TIMESTAMP
                    );

                    -- Departments table to organize courses and subjects
                    CREATE TABLE IF NOT EXISTS Departments(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Description TEXT NOT NULL,
                        CreateDate TEXT DEFAULT CURRENT_TIMESTAMP
                    );

                    -- Courses associated with departments
                    CREATE TABLE IF NOT EXISTS Courses(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        DepartmentsID INTEGER,
                        Name TEXT NOT NULL,
                        Description TEXT NOT NULL,
                        Duration TEXT NOT NULL,
                        FOREIGN KEY (DepartmentsID) REFERENCES Departments(ID)
                    );

                    -- Subjects linked to departments
                    CREATE TABLE IF NOT EXISTS Subjects(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        DepartmentsID INTEGER,
                        Name TEXT NOT NULL,
                        Credit INTEGER NOT NULL,
                        FOREIGN KEY (DepartmentsID) REFERENCES Departments(ID)
                    );

                    -- Many-to-many relationship between courses and subjects
                    CREATE TABLE IF NOT EXISTS CoursesSubjects(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CoursesID INTEGER,
                        SubjectsID INTEGER,
                        FOREIGN KEY (CoursesID) REFERENCES Courses(ID),
                        FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID)
                    );

                    -- Rooms for lectures and exams
                    CREATE TABLE IF NOT EXISTS Rooms(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomType TEXT NOT NULL,
                        RoomNumber TEXT NOT NULL,
                        Capacity TEXT NOT NULL
                    );

                    -- Admin users (linked to general Users table)
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
                        FOREIGN KEY (UsersID) REFERENCES Users(ID)
                    );

                    -- Staff members (e.g. non-teaching staff)
                    CREATE TABLE IF NOT EXISTS Staffs(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
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
                        FOREIGN KEY (UsersID) REFERENCES Users(ID)
                    );

                    -- Exams conducted per subject and course, assigned to rooms
                    CREATE TABLE IF NOT EXISTS Exams(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CoursesID INTEGER,
                        SubjectsID INTEGER,
                        RoomsID INTEGER,
                        ExamName TEXT NOT NULL,
                        ExamDate TEXT NOT NULL,
                        ExamTime TEXT NOT NULL,
                        ExamType TEXT NOT NULL,
                        Duration TEXT NOT NULL,
                        Remarks TEXT NOT NULL,
                        Status TEXT NOT NULL,
                        FOREIGN KEY (CoursesID) REFERENCES Courses(ID),
                        FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID),
                        FOREIGN KEY (RoomsID) REFERENCES Rooms(ID)
                    );

                    -- Students with course and department association
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
                        FOREIGN KEY (UsersID) REFERENCES Users(ID)
                    );

                    -- Lecturers information
                    CREATE TABLE IF NOT EXISTS Lecturers(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UsersID INTEGER,
                        DepartmentsID INTEGER,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        DateOfBirth TEXT NOT NULL,
                        Gender TEXT NOT NULL,
                        Nationality TEXT NOT NULL,
                        NICno TEXT NOT NULL,
                        Gmail TEXT NOT NULL,
                        PhoneNumber TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        MaritalStatus TEXT NOT NULL,
                        RelationName TEXT NOT NULL,
                        Relationship TEXT NOT NULL,
                        Relationnumber TEXT NOT NULL,
                        Salary TEXT NOT NULL,
                        Qualification TEXT NOT NULL,
                        FOREIGN KEY (UsersID) REFERENCES Users(Id),
                        FOREIGN KEY (DepartmentsID) REFERENCES Departments(Id)
                    );

                    -- Students' marks for exams and subjects
                    CREATE TABLE IF NOT EXISTS Marks(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentsID INTEGER,
                        SubjectsID INTEGER,
                        ExamsID INTEGER,
                        Score TEXT NOT NULL,
                        Grade TEXT NOT NULL,
                        FOREIGN KEY (StudentsID) REFERENCES Students(ID),
                        FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID),
                        FOREIGN KEY (ExamsID) REFERENCES Exams(ID)
                    );

                    -- Timetable entries for subjects
                    CREATE TABLE IF NOT EXISTS Timetables(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        SubjectsID INTEGER,
                        FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID)
                    );

                    -- Many-to-many relationship: students and subjects
                    CREATE TABLE IF NOT EXISTS StudentsSubjects(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentsID INTEGER,
                        SubjectsID INTEGER,
                        FOREIGN KEY (StudentsID) REFERENCES Students(ID),
                        FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID)
                    );

                    -- Many-to-many relationship: students and lecturers
                    CREATE TABLE IF NOT EXISTS StudentsLectures(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LecturesID INTEGER,
                        StudentsID INTEGER,
                        FOREIGN KEY (StudentsID) REFERENCES Students(ID),
                        FOREIGN KEY (LecturesID) REFERENCES Lectures(ID)
                    );

                    -- Many-to-many relationship: lecturers and subjects
                    CREATE TABLE IF NOT EXISTS LecturersSubjects(
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LecturersID INTEGER,
                        SubjectsID INTEGER,
                        FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID),
                        FOREIGN KEY (LecturersID) REFERENCES Lecturers(ID)
                    );
                ";

                // Execute the entire SQL batch to create all tables
                SQLiteCommand command = new SQLiteCommand(Query, connect);
                command.ExecuteNonQuery(); // Executes all CREATE TABLE statements
            }
        }
    }
}
