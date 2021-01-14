using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazır_method_kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(" cümle giriniz");
            string cumle = Convert.ToString(Console.ReadLine());
            char[] harf;
            bool result;
            harf = cumle.ToCharArray(0, cumle.Length);// dizinin uzunluğunu buyldum
            string[] kelime = cumle.Split(' ');//kelime sayısını boşlukları referans alarak buldum
            
            char basHarf = cumle[0];
            result = Char.IsUpper(basHarf);
            if(result == true)
            {
                Console.WriteLine("cumle buyuk harfle baslar");
            }
            else
            {
                Console.WriteLine("cumle kucuk harfle baslar");
            }

            int  n = 0;
            int m = 0;

            if(cumle.StartsWith("a") || cumle.StartsWith("e") || cumle.StartsWith("i") || cumle.StartsWith("u") || cumle.StartsWith("o"))// dizinin sesli harfle başlama durumunu kontrol ettim
            {
                Console.WriteLine("cumle sesli harfle baslar");
            }
            else
            {
                Console.WriteLine("cumle sessiz harfle baslar");
            }

            foreach (char c in harf)//dizideki boşlukları eleyerek harf sayısını buldum
            {
                Console.WriteLine(c);

                if(c!=' ')
                {
                    n = n + 1;
                }
                else
                {
                    n = n;
                }
                
            }

            foreach (var Kelime in kelime) //kelime sayısını buldum
            {
                m = m + 1;
            }

           
            
            Console.WriteLine("kelime sayısı '{0}' ", m);
            Console.WriteLine("harf sayısı '{0}' ",n);

            Console.ReadLine();
        }
    }
}
