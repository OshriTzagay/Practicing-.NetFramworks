using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastPractice_B4_Test_allFrameworks.Models
{
    public class Waiter
    {
        public Waiter(int id, string firstName, string lastName, int birthday, int workHours)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            WorkHours = workHours;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Birthday { get; set; }

        public int WorkHours { get; set; }

        public Waiter() { }
    }
}