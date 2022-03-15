using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class AssPerCour
    {
        public string x { get; set; }

        public string y { get; set; }

        public AssPerCour(string _x, string _y)
        {
            x = _x;
            y = _y;
        }

        public AssPerCour()
        {

        }

        public void ApC()
        {
            List<AssPerCour> ACl = new List<AssPerCour>();
            AssPerCour AC1 = new AssPerCour();
            AC1.x = "Group project A";
            AC1.y = "Engineering";
            Console.WriteLine($"The assignment {AC1.x} is in the {AC1.y} course");

            AssPerCour AC2 = new AssPerCour();
            AC2.x = "Thesis on history of art";
            AC2.y = "Illustration";
            Console.WriteLine($"The assignment {AC2.x} is in the {AC2.y} course");

            AssPerCour AC3 = new AssPerCour();
            AC3.x = "Project A";
            AC3.y = "Programing";
            Console.WriteLine($"The assignment {AC3.x} is in the {AC3.y} course");

            AssPerCour AC4 = new AssPerCour();
            AC4.x = "Thesis on psychology";
            AC4.y = "Psychology";
            Console.WriteLine($"The assignment {AC4.x} is in the {AC4.y} course");
        }
    }
}
