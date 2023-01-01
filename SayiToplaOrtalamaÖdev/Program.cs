using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiToplaOrtalamaÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Kaç Adet Sayi Gireceğinizi Yazınız: ");
                int adet = Convert.ToInt32(Console.ReadLine());
                int toplam = 0;
                int sayi;
                for (int i = 0; i <= adet; i++)
                {
                    Console.Write("Sayi giriniz: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    toplam += sayi;
                }
                Console.WriteLine("Sayilarin Ortalaması = " + (toplam / adet));
                Console.WriteLine("Sayilarin Toplamı = " + toplam);

                Console.ReadLine();
            }
    }
}
