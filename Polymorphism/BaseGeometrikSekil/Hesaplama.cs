using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.BaseGeometrikSekil
{
    internal class Hesaplama
    {
        public virtual double hesapla(double genişlik, double yükseklik) // Virtual kelimesiyle bu hesaplamayı ezme yetkisini veriyoruz.
        {  
            return genişlik * yükseklik;
        }
        
    }
}
