using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class StudPerCour 
    {
        public int x { get; set; }

        public string y { get; set; }

        public string o { get; set; }

        public StudPerCour(int _x, string _y, string _o)
        {
            x = _x;
            y = _y;
            o = _o;
        }

        public StudPerCour()
        {

        }

        public void SC()
        {
            List<StudPerCour> SCl = new List<StudPerCour>();
            StudPerCour SC1 = new StudPerCour();
            SC1.x = 1234;
            SC1.y = "Programing";
            SC1.o = "Illustration";
            Console.WriteLine($"The student with the id {SC1.x} is in the {SC1.y} and {SC1.o} course");

            StudPerCour SC2 = new StudPerCour();
            SC2.x = 5678;
            SC2.y = "Psychology";
            Console.WriteLine($"The student with the id {SC2.x} is in the {SC2.y} course");

            StudPerCour SC3 = new StudPerCour();
            SC3.x = 9823;
            SC3.y = "Engineering";
            SC3.o = "Programing";
            Console.WriteLine($"The student with the id {SC3.x} is in the {SC3.y} and {SC1.o} course");

            StudPerCour SC4 = new StudPerCour();
            SC4.x = 1256;
            SC4.y = "Illustration";
            Console.WriteLine($"The student with the id {SC4.x} is in the {SC4.y} course");
        }
    }
}

