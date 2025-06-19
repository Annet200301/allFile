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
";
                cmd.ExecuteNonQuery();
            }
        }

    }
}


