using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class Trainers
    {
        public string nm { get; set; }

        public string snm { get; set; }

        public int tid { get; set; }

        public DateTime dt { get; set; }

        public Trainers(string _nm, string _snm,int _tid, DateTime _dt)
        {
            nm = _nm;
            snm = _snm;
            tid = _tid;
            dt = _dt;
        }

        public Trainers()
        {

        }

        public void TraiL()
        {
            List<Trainers> Tl = new List<Trainers>();
            for (int i = 0; i <= 3; i++)
            {
                Trainers T1 = new Trainers();
                Console.WriteLine("Please type the name of the Trainer.");
                T1.nm = Console.ReadLine();
                Console.WriteLine("Please type a Surname.");
                T1.snm = Console.ReadLine();
                Console.WriteLine("Please type the trainer's id(3 digits)");
                T1.tid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Date of birth (year month day)");
                T1.dt = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Trainer was created successfully!");
                Tl.Add(T1);
            }

            Console.WriteLine("The list of the trainers:");

            for (int i = 0; i <= 3; i++) //i must be the same as the list for.
            {
                Trainers Pr = Tl[i];
                Console.WriteLine($"Name: {Pr.nm} | Surname: {Pr.snm} | trainer id: {Pr.tid} | Date of birth: {Pr.dt}");
            }
        }
    }
}
