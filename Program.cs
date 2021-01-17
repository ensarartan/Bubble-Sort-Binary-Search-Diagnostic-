using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Bublesortie
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecici;
            Console.Write("Sayı Adedini giriniz = ");
            int k = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] dizi = new int[k];
            for (int i = 0; i < k; i++)
            {

                dizi[i] = random.Next(k+1);
            }
            Console.WriteLine("******************************");
            Console.WriteLine("Oluşturulan Dizi");
            
            //DiziYazdir(dizi);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                for (int j = 1; j <= dizi.Length - 1; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
                //DiziYazdir(dizi);
            }
            watch.Stop();
            Console.WriteLine("Dizinin Sıralı Hali");
           // DiziYazdir(dizi);
            Console.WriteLine("Sıralama  süresi: {0}", watch.Elapsed.TotalMilliseconds + " Milisaniye");
            Console.WriteLine("--------------------");

            Console.Write("Bulmak istediğiniz sırayı yazın ");
            object s = Convert.ToInt32(Console.ReadLine());

           
            result(dizi, s);

            
            Console.ReadKey();
        }
        static void result(int[] arr2, object ki)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            int res = Array.BinarySearch(arr2, ki);

            if (res < 0)
            {
                Console.WriteLine("\nAradığınız Eleman  "
                                      + "({0}) Bulunamadı",
                                  ki);
            }

            else
            {
                Console.WriteLine("Aradığınız "
                                      + "({0}) Sayısının indeksi {1}'dir.",
                                  ki, res);
            }
            watch.Stop();
            Console.WriteLine("Sayıyı bulma  süresi: {0}", watch.Elapsed.TotalMilliseconds + " Milisaniye");
            Console.WriteLine("--------------------");
        }

        static void display(int[] arr1)
        {

           
            foreach (int i in arr1)
                Console.Write(i + " ");
        }

        public static void DiziYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}   ", dizi[i]);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");


        }
    }
}
