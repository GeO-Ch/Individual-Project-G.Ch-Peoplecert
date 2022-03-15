using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class Courses
    {
        public string nm { get; set; }       

        public Courses(string _nm)
        {
            nm = _nm;
        }

        public Courses()
        {

        }

        public void CouL()
        {
            List<Courses> Cl = new List<Courses>();
            for (int i = 0; i <= 3; i++)
            {
                Courses C1 = new Courses();
                Console.WriteLine("Please type the name of the Course.");
                C1.nm = Console.ReadLine();              
                Console.WriteLine("Course was created successfully!");
                Cl.Add(C1);
            }

            Console.WriteLine("The list of the Courses:");

            for (int i = 0; i <= 3; i++) //i must be the same as the list for.
            {
                Courses Pr = Cl[i];
                Console.WriteLine($"Title: {Pr.nm}");
            }
        }  
    }
}

