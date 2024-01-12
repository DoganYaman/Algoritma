using System;

namespace algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen aralarında virgül olacak şekilde bir adet string değer ve bir adet index numrası giriniz : ");
            string ifade = Console.ReadLine();
            Algoritma(ifade);
            
        }

        static void Algoritma(string ifade)
        {
            string[] dizi = ifade.Split(',');
            string yazi = dizi[0];
            int sayi = int.Parse(dizi[1]);
            if(sayi <= dizi[0].Length)
                yazi = yazi.Remove(sayi,1);
            Console.WriteLine(yazi);
        }
    }
}
