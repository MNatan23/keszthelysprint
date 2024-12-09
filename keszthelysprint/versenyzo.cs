using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace keszthelysprint
{
    internal class versenyzo
    {
        public string Nev { get; set; }
        public int Szuletesieve { get; set; }
        public int  Rajtszam { get; set; }

        public string Neme { get; set; }
        public string Életkor { get; set; }
        public string Elsoeredmeny { get; set; }
        public string Masodikeredmeny { get; set; }
        public string Harmadikeredmeny { get; set; }
        public string Negyedikeredmeny { get; set; }
        public string Otodikeredmeny { get; set; }

        public versenyzo(string sor)
        {
            string[] darabok = sor.Split(';');

            Nev = darabok[0];
            Szuletesieve = int.Parse(darabok[1]);
            Rajtszam = int.Parse( darabok[2]);
            Neme = darabok[3];
            Életkor = darabok[4];
            Elsoeredmeny = darabok[5];
            Masodikeredmeny = darabok[6];
            Harmadikeredmeny = darabok[7];
            Negyedikeredmeny = darabok[8];
            Otodikeredmeny = darabok[9];
        }





    }
}
