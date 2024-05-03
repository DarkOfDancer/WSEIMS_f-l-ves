using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_féléves
{
    public class Program
    {
        static string NeptunKódGeneralas()
        {
            string NeptunKod = null;
            Random rnd = new Random();
            if (0 == rnd.Next(0, 1))
            {
                NeptunKod += "M-";
            }
            else { NeptunKod += "F-"; }

            NeptunKod += rnd.Next(100, 999);
            for (int i = 0; i <= 1;)
            {
                NeptunKod += (char)rnd.Next('a', 'z' + 1);
            }
            Console.WriteLine(NeptunKod);
            return NeptunKod;
        }
        static void Main(string[] args)
        {
            NeptunKódGeneralas();
            Console.ReadKey();
        }
    }
}
