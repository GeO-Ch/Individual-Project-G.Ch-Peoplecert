using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class TraiPerCour
    {
        public int x { get; set; }

        public string y { get; set; }

        public TraiPerCour(int _x, string _y)
        {
            x = _x;
            y = _y;
        }

        public TraiPerCour()
        {

        }

        public void TC()
        {
            List<TraiPerCour> TCl = new List<TraiPerCour>();
            TraiPerCour TC1 = new TraiPerCour();
            TC1.x = 123;
            TC1.y = "Engineering";
            Console.WriteLine($"The trainer with the id {TC1.x} is in the {TC1.y} course");

            TraiPerCour TC2 = new TraiPerCour();
            TC2.x = 234;
            TC2.y = "Illustration";
            Console.WriteLine($"The trainer with the id {TC2.x} is in the {TC2.y} course");

            TraiPerCour TC3 = new TraiPerCour();
            TC3.x = 576;
            TC3.y = "Programing";
            Console.WriteLine($"The trainer with the id {TC3.x} is in the {TC3.y} course");

            TraiPerCour TC4 = new TraiPerCour();
            TC4.x = 910;
            TC4.y = "Psychology";
            Console.WriteLine($"The trainer with the id {TC4.x} is in the {TC4.y} course");
        }
    }
}
