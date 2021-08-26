using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company c49 = new Company("C49 Industries", new DateTime(2021, 5, 18, 8, 0, 0));
            Employee joelBeckum = new Employee("Joel", "Beckum", "Chief Shenanigans Officer", new DateTime(2021, 6, 2, 14, 25, 6));
            Employee hollyRudge = new Employee("Holly", "'The Codinator' Rudge", "Deputy Chief Assistant Secretary Vice Rear Admiral", new DateTime(21, 7, 13, 8, 7, 16));
            Employee peterRacine = new Employee("Peter", "'I'm definitely not a clone from the future' Racine", "Deputy Chairclone of Time Travel R&D", new DateTime(2894, 1, 16, 9, 9, 9));

            c49.Employees.Add(joelBeckum);
            c49.Employees.Add(hollyRudge);
            c49.Employees.Add(peterRacine);

            c49.ListEmployees();
        }
    }
}
