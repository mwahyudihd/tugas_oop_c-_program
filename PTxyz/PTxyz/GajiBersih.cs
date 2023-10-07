using System;

namespace PTxyz.Gaji.Bersih
{
    internal class GajiBersih
    {
        public void Pengurangan(double Gaji_total, int Gaji_pokok) 
        {
            double PPH = 0.025 * Gaji_pokok; //menghitung pph
            var hasil = Gaji_total - PPH; //pengurangan dari pph
            //rician data gaji bersih
            Console.WriteLine("PPH\t\t\t:-" + "Rp." + PPH+" [2.5%]");
            Console.WriteLine("Gaji bersih \t\t: Rp."+(int)Math.Round(hasil)); //dibulatkan "Math.Round"
            Console.ReadKey();
            

        }
    }
}
