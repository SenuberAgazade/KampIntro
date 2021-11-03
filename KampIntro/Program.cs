using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Urun urun1 = new Urun();
            //urun1.Adi = "Elma";
            //urun1.Fiyati = 15;
            //urun1.Aciklama = "Amasya elmasi";

            Hesablamalar<int> inttopla = new Hesablamalar<int>();
            inttopla.topla(3, 4);

            Hesablamalar<double> doubletopla = new Hesablamalar<double>();
            doubletopla.cikar(9.8, 1.7);
        }
    }

    public interface IMatematik<T> 
    {
        void topla(T a, T b);
        void cikar(T a, T b);
        void Carp(T a, T b);
        void Bol(T a, T b);
    }

    public class Hesablamalar<T> : IMatematik<T>
    {
        public void topla(T a, T b)
        {
            dynamic x = a, y = b;
            Console.WriteLine($"Toplam : {x} + {y} = {x+y}");
        }

        public void cikar(T a, T b)
        {
            dynamic x = a, y = b;
            Console.WriteLine($"Toplam : {x} - {y} = {x - y}");
        }

        public void Carp(T a, T b)
        {
            dynamic x = a, y = b;
            Console.WriteLine($"Toplam : {x} * {y} = {x * y}");
        }

        public void Bol(T a, T b)
        {
            dynamic x = a, y = b;
            Console.WriteLine($"Toplam : {x} / {y} = {x / y}");
        }

    }
}
