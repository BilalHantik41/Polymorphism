using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.BaseGeometrikSekil
{
    internal class DikÜçgen : Hesaplama
    {
        public override double hesapla(double genişlik, double yükseklik)
        {
            //return base.hesaplama(genişlik, yükseklik); // bu kodu yorum satırı yapıp çalıştırmak istediğimiz şeklini yazıyoruz.
            return (genişlik * yükseklik) / 2;

        }



    }
}
