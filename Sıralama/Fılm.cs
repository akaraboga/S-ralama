using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sıralama
{
    public class Fılm//Oluşturduğumuz fıl clası ve 2 tane propertysi
    {

        public string İsim { get; set; }

        public double IMDB { get; set; }

         
        public Fılm(string ad, double puan)
        {
            İsim = ad;
            IMDB = puan;
        }
         


    }
}
