using System;

namespace dortislem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dört işlem c# konsol uygulaması --> www.eraycakmak.com & www.kodyazar.com

            int sayia, sayib, topla, carp, cikar, bol;

            Console.Write("Birinci sayıyı girin = ");
            sayia = int.Parse(Console.ReadLine());   

            Console.Write("İkinci sayıyı girin = ");
            sayib = int.Parse(Console.ReadLine());

            topla = sayia + sayib;

            carp = sayia * sayib;

            cikar = sayia - sayib;

            bol = sayia / sayib;

            Console.WriteLine("Toplama işleminin sonucu = " + topla);
            Console.WriteLine("Çarpma işleminin sonucu = " + carp);
            Console.WriteLine("Çıkarma işleminin sonucu = " + cikar);
            Console.WriteLine("Bölme işleminin sonucu = " + bol);


            Console.ReadKey();


        }
    }
}
