using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingkaran.Luas
{
    public class LingkaranLuas
    {
        public void Luas(int Jari_Jari)
        {
            var Luas = 3.14 * Jari_Jari * Jari_Jari;
            Console.WriteLine("Luas Lingkaran adalah = " + Luas);
        }
    }
}
