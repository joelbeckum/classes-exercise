using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Employee> Employees { get; set; }

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach(Employee e in Employees)
            {
                System.Console.WriteLine($"{e.FirstName} {e.LastName} works for {this.Name} as {e.Title} since {e.StartDate.ToShortDateString()}.");
            }
        }
    }
}
