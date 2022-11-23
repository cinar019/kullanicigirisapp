using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Çınar Topçınar", "Kerem Mert Eryiğit", "Sarp Toygar Akkaya", "Ezel Çetinkaya", "Efe Öğül" };
            string[] numaralar = { "500", "501", "502", "503", "504" };
            string[] kullanıcıadları = { "c.topcinar", "k.eryiğit", "s.akkaya", "e.ogul", "e. cetinkaya" };
            string[] sifreler = { "1234", "1235", "1236", "1237", "1238" };

            Console.WriteLine("---------Hoşgeldiniz---------");
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz");
            string kullanıcıadı = Console.ReadLine();

            Console.WriteLine("Lütfen şifrenizi giriniz");
            string sifre = Console.ReadLine();

            bool kullanicivarmi = false;
            int kullanciIndex = -1;

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);

                if (kullanıcıadı == kullanıcıadları[i])
                {
                    kullanicivarmi = true;
                    kullanciIndex = i;
                }
            }
            if (kullanicivarmi == true)
            {
                if (sifre == sifreler[kullanciIndex])
                {
                    Console.WriteLine("Merhaba");
                    Console.WriteLine("No: " + numaralar[kullanciIndex] + " " + isimler[kullanciIndex]);
                }
                else
                {
                    Console.WriteLine("Şifre hatalı");
                }

            }
            else
            {
                Console.WriteLine("Kullanıcı Bulunamadı"); Console.WriteLine("Kimsin sen?"); 
            }




        }


    }
}
