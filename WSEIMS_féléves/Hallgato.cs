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
        public int Terhelés { get; set; }
        public List<Targy> Tárgyak { get; set; }

        Random rnd = new Random();
        public Hallgato(string Név, string NeptunKód, List<Targy>Tárgyak)
        {
            this.Név = Név;
            this.NeptunKód = NeptunKód;
            this.Terhelés = rnd.Next(0, 999);
        }
        public string Fogyasztás(int óra)
        {
            return Név + "nevű hallgató " + óra + " óra alatt " + (óra * 25) + " dl kávét fogyasztott és " + (óra * 2) + " alkalommal esett pánikba.";
        }

        public void Lefoglalás(int óra)
        {
            Terhelés += óra;
        }

        public int Teljesítmény()
        {
            return this.Terhelés;
        }

        public bool VaneMégKapacitás()
        {
            throw new NotImplementedException();
        }
    }
}
