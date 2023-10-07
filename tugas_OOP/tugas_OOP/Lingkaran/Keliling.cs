using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingkaran.Keliling
{
    public class Keliling
    {
        public void Hitung(int jari1) {
            var Kel = 2 * 3.14 * jari1 * jari1;
            //menampilkan hasil dari Keliling
            Console.WriteLine("Keliling Lingkaran Adalah = " + Kel);
        }
    }
}
