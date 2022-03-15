using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class Students 
    {
        public string nm {get; set;}  

        public string snm {get; set;}

        public DateTime dt {get; set;}

        public int sid { get; set; }        

        public Students(string _nm, string _snm, int _sid, DateTime _dt)
        {
            nm = _nm;
            snm = _snm;
            sid = _sid;
            dt = _dt;
        }

        public Students()
        {

        }
                
        public void StudL()
        {
            List<Students> Sl = new List<Students>();
            for (int i = 0; i <=3; i++)  
            {
                Students S1 = new Students();                
                Console.WriteLine("Please type the name of the student.");
                S1.nm = Console.ReadLine();
                Console.WriteLine("Please type the Surname of the student.");
                S1.snm = Console.ReadLine();
                Console.WriteLine("Please type the student's id number (4 digits)");
                S1.sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Date of birth (year month day)");
                S1.dt = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Student was created successfully!");
                Sl.Add(S1);                                               
            }
            
            Console.WriteLine("The list of the students:");

            for (int i = 0; i <= 3; i++) //i must be the same as the list for.
            {
                Students Pr = Sl[i];                
                Console.WriteLine($"Name: {Pr.nm} | Surname: {Pr.snm} | Student id: {Pr.sid} | Date of birth: {Pr.dt}");
            }                            
        }
    }
}
