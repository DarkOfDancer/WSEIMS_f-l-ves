using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_féléves
{
    public class Tankor
    {
        public List<IHallgato> Hallgatok { get; set; }

        public Tankor()
        {
            Hallgatok = new List<IHallgato>();
        }

        public void HallgatoHozzaadasa(Hallgato hallgato)
        {
            Hallgatok.Add(hallgato);
        }
    }
}
