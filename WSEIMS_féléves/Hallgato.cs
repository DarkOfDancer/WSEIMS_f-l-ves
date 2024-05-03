using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_féléves
{
    public class Hallgato : IHallgato
    {
        public string Név { get ; set ; }
        public string NeptunKód { get; set; }
        public Targy[] Tárgyak { get; set; }

        public event EventHandler Kiiratkozott;
    }
}
