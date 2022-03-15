using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class StudMorCour
    {
        public int x { get; set; }

        public string y { get; set; }

        public string o { get; set; }

        public StudMorCour(int _x, string _y, string _o)
        {
            x = _x;
            y = _y;
            o = _o;
        }

        public StudMorCour()
        {

        }

        public void SR()
        {
            List<StudPerCour> SRl = new List<StudPerCour>();
            StudPerCour SR1 = new StudPerCour();
            SR1.x = 1234;
            SR1.y = "Programing";
            SR1.o = "Illustration";
            Console.WriteLine($"The student with the id {SR1.x} is in the {SR1.y} and {SR1.o} course");
           
            StudPerCour SR2 = new StudPerCour();
            SR2.x = 9823;
            SR2.y = "Engineering";
            SR2.o = "Programing";
            Console.WriteLine($"The student with the id {SR2.x} is in the {SR2.y} and {SR2.o} course");           
        }
    }
}
