using System;
using PTxyz.Gaji.Bersih;

namespace PTxyz.Gaji.Total
{
    public class Gajitotal
    {
        public void Tambahan (int Gaji_pokok)
        { 
            double Tunjangan = 0.10 * Gaji_pokok ; //menghitung tunjangan
            double Bonus = 0.50 * Gaji_pokok ; //menghitung bonus
            var Gatotal = Gaji_pokok + Tunjangan + Bonus; //mentotalkan gaji dengan tambahan
            //rician data
            Console.WriteLine("Berikut Rician Gaji Anda \t:");
            Console.WriteLine("KETERANGAN\t\t|"+" JUMLAH");
            Console.WriteLine("Gaji Pokok \t\t:" + " Rp." + Gaji_pokok);
            Console.WriteLine("Tunjangan\t\t:+" + "Rp." + Tunjangan+" [10%]");
            Console.WriteLine("Bonus\t\t\t:+" + "Rp." + Bonus+" [50%]");
            Console.WriteLine("Gaji Total\t\t: Rp."+(int)Math.Round(Gatotal)); //gaji total dibulatkan "Math.Round" 
            GajiBersih set = new GajiBersih();
            set.Pengurangan(Gatotal, Gaji_pokok);


        }
    }
}
