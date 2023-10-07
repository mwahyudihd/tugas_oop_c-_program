using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lingkaran.Luas
{
    public class Luas
    {
        public void Hitung(int jari1)
        {
            var luas = 3.14 * jari1 * jari1;
            //menampilkan hasil dari luas
            Console.WriteLine("Luas Lingkaran Adalah = " + luas);

        }
    }
}
