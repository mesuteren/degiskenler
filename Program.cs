using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string ahmet;
            ahmet = "mehmet";
            Console.WriteLine("Hello World!");
            Console.WriteLine(ahmet);

            
            //string ifadeler
            string ad = "Mesut";
            string soyad ="Eren";
            string tamad = ad + " " +soyad;

            Console.WriteLine(tamad);

            //değişken dönüşümleri
            string str20="20";
            int int20=20;
            string yeniDeger=str20+int20.ToString();
            Console.WriteLine(yeniDeger); //Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //Çıktısı 40

            int int22 = int20 + int.Parse(str20); //Çıktısı 40

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

             string datetime2 = DateTime.Now.ToString("dd..MM..yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

            
            
        }
    }
}
