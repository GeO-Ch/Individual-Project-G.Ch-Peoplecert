using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class Assignments
    {
        public string nm { get; set; }

        public DateTime dt { get; set; }

        public Assignments(string _nm, DateTime _dt)
        {
            nm = _nm;
            dt = _dt;
        }

        public Assignments()
        {

        }

        public void AsL()
        {
            List<Assignments> Al = new List<Assignments>();
            for (int i = 0; i <= 3; i++)
            {
                Assignments A1 = new Assignments();
                Console.WriteLine("Please type the name of the Assignment.");
                A1.nm = Console.ReadLine();
                Console.WriteLine("Please type the Due date (year month day)");
                A1.dt = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Assignment was created successfully!");
                Al.Add(A1);
            }

            Console.WriteLine("The list of the Assignments:");

            for (int i = 0; i <= 3; i++) //i must be the same as the list for.
            {
                Assignments Pr = Al[i];
                Console.WriteLine($"Title: {Pr.nm} | Due date: {Pr.dt}");
            }
        }
    }
}
