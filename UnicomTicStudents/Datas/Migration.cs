using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;   

namespace UnicomTicStudents.Datas
{
    internal class Migration
    {
        public static void CreateTables()
        {
            using (var conn = DataConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                               CREATE TABLE IF NOT EXISTS Courses (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL
                            );
                                                            
                               CREATE TABLE IF NOT EXISTS Subjects (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    CourseId INTEGER,
                    FOREIGN KEY(CourseId) REFERENCES Courses(Id)
                            );
                               CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NIC TEXT NOT NULL,
                    Name TEXT NOT NULL,
                    IndexNumber TEXT NOT NULL,
                    Username TEXT,
                    Password TEXT,
                    Role TEXT NOT NULL
                            );
                                CREATE TABLE IF NOT EXISTS Lecturers (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    NIC TEXT NOT NULL UNIQUE,
                    IndexNumber TEXT NOT NULL UNIQUE,
                    SubjectId INTEGER,
                    FOREIGN KEY (SubjectId) REFERENCES Subjects(Id)
                            );
                                CREATE TABLE IF NOT EXISTS Admins (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NIC TEXT NOT NULL,
                    Name TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL
                            );
                                CREATETABLE IF NOT EXISTS Staff (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    NIC TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Work TEXT NOT NULL,
                            );
                                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL UNIQUE
                       
                        
                            );
                               CREATE TABLE Students (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    NIC TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    CourseId INTEGER,
                    FOREIGN KEY (CourseId) REFERENCES Courses(Id)
                            );


";
                cmd.ExecuteNonQuery();
            }
        }

    }
}


