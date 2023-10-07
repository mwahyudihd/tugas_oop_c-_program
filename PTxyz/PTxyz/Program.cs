using System;
using PTxyz.Gaji.Total;

namespace PTxyz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rician Gaji Karyawan PT XYZ");
            Gajitotal Gaji = new Gajitotal();
            Console.Write("Silahkan Masukkan Data Gaji Pokok Anda : Rp.");
            Gaji.Tambahan((int)Math.Round(Convert.ToDouble(Console.ReadLine()))); //user menginputkan gaji pokok
        }
    }
}
