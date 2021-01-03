using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_tahmin_etme_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolay");
            Random rnd = new Random();
            int sayi = rnd.Next(1, 10);
            Console.WriteLine(sayi);
            int hak = 6;
            BasaDon:
            for (int i = 0; i <6; i++)
            {
                Console.WriteLine("Bir tahminde bulunuz");
                int tahmin=int.Parse(Console.ReadLine());

                if (sayi==tahmin)
                {
                    Console.WriteLine("Tebrikler bildiniz Puan:{0}", hak * 10);
                    break;
                }
                else if (tahmin<sayi)
                {
                    hak--;
                    if (hak==0)
                    {
                        Console.WriteLine("Kaybettiniz hakkınız kalmadı Puan:0");
                        break;
                    }
                    else
                    {
                        goto BasaDon;
                    }
                }
            }
            Console.WriteLine("Orta");
            Random rdm = new Random();
            int rakam = rdm.Next(1, 25);
            Console.WriteLine(rakam);
            int hak2 = 4;
            BASADON:
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Bir tahminde bulunuz");
                int tahmin2 = int.Parse(Console.ReadLine());
                if (rakam==tahmin2)
                {
                    Console.WriteLine("Tebrikler bildiniz Puan:{0}", hak2 * 10);
                    break;
                }
                else if (tahmin2<rakam)
                {
                    hak2--;
                    if (hak2==0)
                    {
                        Console.WriteLine("Kaybettiniz hakkınız kalmadı Puan:0");
                        break;
                    }
                    else
                    {
                        goto BASADON;
                    }
                }
            }
            Console.WriteLine("Zor");
            Random rdm1 = new Random();
            int rakam2 = rdm1.Next(1, 50);
            Console.WriteLine(rakam2);
            int hak3 = 2;
            BASAdon:
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Bİr tahminde bulunuz");
                int tahmin3 = int.Parse(Console.ReadLine());
                if (rakam2==tahmin3)
                {
                    Console.WriteLine("Tebrikler bildiniz Puan:{0}", hak3 * 10);
                    break;
                }
                else if (tahmin3<rakam2)
                {
                    hak3--;
                    if (hak3==0)
                    {
                        Console.WriteLine("Kaybettiniz hakkınız kalmadı Puan:0");
                        break;
                    }
                    else
                    {
                        goto BASAdon;
                    }
                }
            }
        }
    }
}
