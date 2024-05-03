using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_féléves
{
    public interface IHallgato
    {
        string Név { get; set; }
        string NeptunKód {  get; set; }
        Tárgy[] Tárgyak { get; set; }

        string Fogyasztás(int óra) 
        {
            return Név + "nevű hallgató " + óra + " óra alatt " + (óra * 25) + " dl kávét fogyasztott és " + (óra * 2) + " alkalommal esett pánikba.";
        }
        string Lefoglalás(int óra) 
        {
            Terhelés += óra;
        }
        int Teljesítmény() 
        {
            return HallgatoiTelljesítmény;        
        }
        bool VaneMégKapacitás() 
        {

                if (HallgatoiTeljesitmeny==Terhelés){return false;}
                else { return true; }
        }

        public event EventHandler Kiiratkozott;

        protected virtual void OnKiiratkozott(EventArgs e)
        {
            Kiiratkozott?.Invoke(this, e);
        }

    }
}
