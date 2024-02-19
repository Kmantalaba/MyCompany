using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyCompany
{
    public class Employee
    {
        public Employee(int id, string firstName, string? middleName, string lastName, string position, double salary)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Position = position;
            Salary = salary;
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string Position { get; set; } 
        public double Salary { get; set; }
        public List<Achievement> Achievements { get; set; } = new List<Achievement>();

        internal void AddAchievements(int v1, string v2)
        {
           Achievements.Add(new Achievement(v1, v2));
        }
    
    }
}
