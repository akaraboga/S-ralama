using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Collections;
using System.ComponentModel;

namespace Sıralama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cevap = string.Empty;
            ArrayList list = new ArrayList();//Bir liste oluşturuyoruz


            double ımdbPuan = 0;
            string FilmAd = string.Empty;

            Console.WriteLine("Film listesine hoş geldiniz istediğiniz kadar liste ekleyebilirsiniz");

            do
            {
                Console.WriteLine("Filmin adını giriniz");//Filmin adını kullanıcının girmesini sağlıyoruz
                FilmAd = Console.ReadLine();

                Console.WriteLine("IMDB puanını giriniz");//Imdb puanını alıyoruz
                ımdbPuan = Convert.ToDouble(Console.ReadLine());

                Fılm ekle = new Fılm(FilmAd,ımdbPuan);//Fılm calsından nesne uretiyoruz.Propertylerimize kullanıcının girdiği değerleri atıyoruz
                                                   

                list.Add(ekle);//Fılm clasından turettiğimiz nesneyi oluşturduğumuz listenin içine atıyoruz


                Console.WriteLine("Yeni film girmek istiyor musunuz? E || H");//Cevap E oldukca dongu donecek
                cevap = Console.ReadLine().ToUpper();





            } while (cevap == "E");//Cevap E oldukca dongu donecek


            Console.Clear();

            Console.WriteLine("Tüm filmler :");

            //Oluşturduğumuz listenin elemanlarını ekrana yazdırıyoruz

            foreach (Fılm tümListe in list)
            {
                Console.WriteLine("Filmin adı : {0}", tümListe.İsim);
                Console.WriteLine("IMDB puanı : {0}", tümListe.IMDB);
                Console.WriteLine();
            }


            Console.WriteLine("-------------------------------------------------------------");



            Console.WriteLine("IMDB si 4 ve 4'den yuksek Filmler");

            foreach (Fılm item in list)
            {
                if (item.IMDB >= 4 && item.IMDB <= 10)
                {
                    Console.WriteLine("Filmin adı : {0}", item.İsim);
                    Console.WriteLine("IMDB puanı : {0}", item.IMDB);
                    Console.WriteLine();

                }

            }
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("A ile başlayan filmler :");

            foreach (Fılm Harf in list)
            {
                if (Harf.İsim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Filmin adı : {0}", Harf.İsim);
                    Console.WriteLine("IMDB puanı : {0}", Harf.IMDB);
                    Console.WriteLine();
                }
            }


            Console.Read();


        }
    }
}
