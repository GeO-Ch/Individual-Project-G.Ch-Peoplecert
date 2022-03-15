using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IndividualPr.G.CH
{
    class Welcome
    {
        public string tl { get; set; }

        public string adr { get; set; }

        public string psc { get; set; }
       
        public DateTime dt { get; set; }

        public Welcome(string _tl, string _adr, string _psc, string _usi, DateTime _dt)
        {
            tl = _tl;
            adr = _adr;
            psc = _psc;           
            dt = _dt;
        }

        public Welcome()
        {

        }

        public void Wel()
        {

            Welcome W1 = new Welcome();
            W1.tl = "The university of Progra";
            W1.adr = "Adress : 22 John St";
            W1.psc = "Ps code: 12398";
            W1.dt = DateTime.Now;
            Console.WriteLine($"{W1.tl}");
            Console.WriteLine($"{W1.adr} {W1.psc}");
            Console.WriteLine($"The date and time are: {W1.dt}");           
            Console.WriteLine("Welcome to the university of Progra!");
        }
    }
}
