using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class AssPerStud
    {
        public int x { get; set; }

        public string y { get; set; }

        public string o { get; set; }

        public AssPerStud(int _x, string _y, string _o)
        {
            x = _x;
            y = _y;
            o = o;
        }

        public AssPerStud()
        {

        }

        public void SpA()
        {
            List<AssPerStud> SAl = new List<AssPerStud>();
            AssPerStud SA1 = new AssPerStud();
            SA1.x = 1234;
            SA1.y = "Project A";
            SA1.o = "Thesis on history of art";
            Console.WriteLine($"The student with the id {SA1.x} has the assignment {SA1.y} and {SA1.o}");

            AssPerStud SA2 = new AssPerStud();
            SA2.x = 5678;
            SA2.y = "Thesis on psychology";
            Console.WriteLine($"The student with the id {SA2.x} has the assignment {SA2.y}");

            AssPerStud SA3 = new AssPerStud();
            SA3.x = 9823;
            SA3.y = "Group project A";
            SA1.o = "Project A";
            Console.WriteLine($"The student with the id {SA3.x} has the assignment {SA3.y} and {SA1.o}");

            AssPerStud SA4 = new AssPerStud();
            SA4.x = 1256;
            SA4.y = "Thesis on history of art";
            Console.WriteLine($"The student with the id {SA4.x} has the assignment {SA4.y}");
        }
    }
}
