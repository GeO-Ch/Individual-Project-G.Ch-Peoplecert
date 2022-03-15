using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPr.G.CH
{
    class Choice
    {

        public int x = 1;

        public int y = 2;

        public int usi;
        
       
        public void Cho()
        {
           

            Console.WriteLine("Please type the number for the desired action");
            Console.WriteLine("1: To add information");
            Console.WriteLine("2: To log out");
            usi = Convert.ToInt32(Console.ReadLine());
            

            if ( usi == 1) 
            {
                InfAdd I1 = new InfAdd();
                I1.IA();
                I1.IA2();
                I1.IA3();
                I1.IA4();
               
                Students Ss = new Students();
                Ss.StudL();

                Console.WriteLine("---------------------------------------------");

                Trainers Tt = new Trainers();
                Tt.TraiL();

                Console.WriteLine("---------------------------------------------");

                Courses Cc = new Courses();
                Cc.CouL();

                Console.WriteLine("---------------------------------------------");

                Assignments Aa = new Assignments();
                Aa.AsL();

                Console.WriteLine("---------------------------------------------");

                StudPerCour SpC = new StudPerCour();
                SpC.SC();

                Console.WriteLine("---------------------------------------------");

                TraiPerCour TpC = new TraiPerCour();
                TpC.TC();

                Console.WriteLine("---------------------------------------------");

                AssPerCour ApC = new AssPerCour();
                ApC.ApC();

                Console.WriteLine("---------------------------------------------");

                AssPerStud ApS = new AssPerStud();
                ApS.SpA();

                Console.WriteLine("---------------------------------------------");

                StudMorCour SmC = new StudMorCour();
                SmC.SR();

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Press any button to log off");                
            }

            else if (usi == 2)
            {
                Console.WriteLine("You have logged out!");              
            }
            else
            {
                Console.WriteLine("You have logged out!");
            }
        }
    }
}
