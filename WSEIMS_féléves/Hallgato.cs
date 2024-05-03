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
        public int Kapacitás { get; set; }
        public List<Targy> Tárgyak { get; set; }

        Random rnd = new Random();

        public event EventHandler Kiiratkozott;

        public Hallgato(string Név, string NeptunKód, List<Targy>Tárgyak)
        {
            this.Név = Név;
            this.NeptunKód = NeptunKódGeneralas();
            this.Terhelés = 0;
            this.Kapacitás = rnd.Next(0, 999);
        }

        static string NeptunKódGeneralas() //Works
        {
            string NeptunKod = null;
            Random rnd = new Random();
            if (0 == rnd.Next(0, 1))
            {
                NeptunKod += "M-";
            }
            else { NeptunKod += "F-"; }

            NeptunKod += rnd.Next(100, 999);
            for (int i = 0; i < 2; i++)
            {
                NeptunKod += ((char)rnd.Next('a', 'z' + 1)).ToString().ToUpper();
            }
            Console.WriteLine(NeptunKod);
            return NeptunKod;
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
            if (Kapacitás == Terhelés) { return false; }
            else { return true; }
        }
    }
}
