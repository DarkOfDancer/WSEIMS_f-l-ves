using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_féléves
{
    class Hallgatok :Hallgato
    {
        
        public string HallgatoJelenlegi { get; set; }
        public Hallgatok KövetkezőHallgato { get; set; }
    }
    class Tankor
    {
        private Hallgatok fej;

        public void Felvétel(string UjHallgato)
        {
            Hallgatok uj = new Hallgatok();
            uj.HallgatoJelenlegi = UjHallgato;
            uj.KövetkezőHallgato = fej;
            fej = uj;
        }
    }
}
