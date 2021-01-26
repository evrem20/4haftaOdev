using System;

namespace _4haftaOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(86, "Eren");
            ogrenci.Add(20, "Merve");
            ogrenci.Add(34, "Kerem");
            ogrenci.Add(36, "Aslı");
            ogrenci.Add(59, "Ayşe");
            ogrenci.Add(44, "Emre");

            Console.WriteLine("Öğrenci No" + ":" + ogrenci.No[0] + " " + "Öğrenci İsmi" + ":" + ogrenci.Isim[0]);
            Console.WriteLine("Öğrenci No" + ":" + ogrenci.No[1] + " " + "Öğrenci İsmi" + ":" + ogrenci.Isim[1]);
            Console.WriteLine("Öğrenci No" + ":" + ogrenci.No[2] + " " + "Öğrenci İsmi" + ":" + ogrenci.Isim[2]);
            Console.WriteLine("Öğrenci No" + ":" + ogrenci.No[3] + " " + "Öğrenci İsmi" + ":" + ogrenci.Isim[3]);
            Console.WriteLine("Öğrenci No" + ":" + ogrenci.No[4] + " " + "Öğrenci İsmi" + ":" + ogrenci.Isim[4]);
            Console.WriteLine("Öğrenci No" + ":" + ogrenci.No[5] + " " + "Öğrenci İsmi" + ":" + ogrenci.Isim[5]);
        }
    }
}
