using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lingkaran.Luas;
using Lingkaran.Keliling;
using System.Data;

namespace Lingkaran
{
    class Program
    {
        static void Main(string[] args)
        {
            try //pengecekan
            {
                Console.WriteLine("Menghitug luas/Keliling Lingkaran :");
                Console.Write("Silahkan Pilih Opsi : ");
                String? opsi = Console.ReadLine();
                Console.Write("Masukkan Jari-Jari : ");
                String? data_jari = Console.ReadLine();
                int jari2 = Convert.ToInt32(data_jari);

                //Proses
                //Menghitung Luas
                if (opsi == "luas")
                {
                    Luas.Luas hasil = new Luas.Luas();
                    hasil.Hitung(jari2);
                    Console.ReadKey();
                }
                else if (opsi == "Luas")
                {
                    Luas.Luas hasil = new Luas.Luas();
                    hasil.Hitung(jari2);
                    Console.ReadKey();
                }

                //Menghitung Keliling
                else if (opsi == "keliling")
                {
                    Keliling.Keliling hasil = new Keliling.Keliling();
                    hasil.Hitung(jari2);
                    Console.ReadKey();
                }
                else if (opsi == "Keliling")
                {
                    Keliling.Keliling hasil = new Keliling.Keliling();
                    hasil.Hitung(jari2);
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("Anda tidak dapat menginputkan data selain (Luas/Keliling) pada pilihan opsi." +
                        $"\ndata yang anda input sebelumnya adalah : { opsi }");
                }
            }
            catch (Exception kesalahan) //penanganan
            {
                Console.WriteLine("data tidak Valid ! \n" + 
                    kesalahan.Message);
            }

            finally 
            {
                Console.WriteLine("Program telah selesai.");
            }
           
        }
    }
}