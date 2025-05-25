using Polymorphism.BaseGeometrikSekil;

Kare kare = new Kare(); 
Dikdörtgen dikdörtgen = new Dikdörtgen();
DikÜçgen dikÜçgen = new DikÜçgen();
Hesaplama hesapMakinası = new Hesaplama();




double hesap = hesapMakinası.hesapla(10,55);

Console.WriteLine("Sonuç: " + hesap);


double ucgenAlani = dikÜçgen.hesapla(50, 10);

Console.WriteLine("Ucgenın Alanı: " + ucgenAlani);