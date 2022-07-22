using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizitekmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç sayılık dizi oluşturacaksınız?");
            int kacsayi = Convert.ToInt32(Console.ReadLine());
            List<int> sayilar = new List<int>();
            List<int> fazlasayi = new List<int>();
            Console.WriteLine("sayıları giriniz..");
            for(int i = 0; i < kacsayi; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);

            }
            sayilar.Sort();
            foreach(int a in sayilar.ToList()){
                sayilar.Remove(a);
                int kackere = 0;
                foreach(int b in sayilar)
                {
                    if(b == a)
                    {
                        kackere++;
                    }
                    

                }
                if(kackere == 0)
                {
                    fazlasayi.Add(a);
                }
                sayilar.Add(a);
            }
            Console.WriteLine("Dizide bir adet olan sayılar..");
            for(int i = 0; i < fazlasayi.Count; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(fazlasayi[i]);
            }
            Console.ReadLine();




        }
    }
}
