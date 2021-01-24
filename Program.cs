using System;
using System.Collections.Generic; //sonradan eklenen kütüphane

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"engin", "murat","kerem","halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler.Add("ilker");
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //array de sabitlik vardır.
            //toplu yorum satırı alma kısayolu: ctrl+k,c


            List<string> isimler2 = new List<string> { "engin","murat","kerem","halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            // koleksiyonlarda bilgi kaybedilmeden yazılabilir.
        }
    }
}
