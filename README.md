# Polymorphism.BaseGeometrikSekil

Bu proje **C#** dilinde polimorfizmi (polymorphism) basit bir geometrik şekil alanı hesaplama örneğiyle göstermektedir. Base (temel) sınıf olarak `Hesaplama` kullanılır, kare, dikdörtgen ve dik üçgen sınıfları bu sınıfı miras alarak (`inheritance`) `hesapla` metodunu kendi ihtiyaçlarına göre `override` eder.

---

## İçerik

* **Hesaplama**: Temel alan hesaplama sınıfı. `hesapla(double genislik, double yukseklik)` metodu `virtual` olarak işaretlenmiştir.
* **Kare**: `Hesaplama` sınıfından türetilir. Karenin alanını hesaplamak için base metodu kullanır.
* **Dikdörtgen**: `Hesaplama` sınıfından türetilir. Dikdörtgenin alanını hesaplamak için base metodu kullanır.
* **DikÜçgen**: `Hesaplama` sınıfından türetilir. `hesapla` metodunu override ederek üçgenin alanını `(genişlik * yükseklik) / 2` formülüyle hesaplar.
* **Program.cs**: `Main` metodu içerisinde sınıfların örneklenmesi ve metodların çalıştırılması yer alır.

---

## Gereksinimler

* .NET SDK (örneğin .NET 6.0 veya üzeri)
* C# 9.0 veya üzeri desteği

---

## Kurulum ve Çalıştırma

1. Bu deposu klonlayın:

   ```bash
   git clone <repository_url>
   cd Polymorphism.BaseGeometrikSekil
   ```

2. Projeyi derleyin ve çalıştırın:

   ```bash
   dotnet build
   dotnet run --project Polymorphism.BaseGeometrikSekil
   ```

3. Konsolda aşağıdaki gibi bir çıktı görmelisiniz:

   ```
   Dikdörtgen alanı (temel sınıfla): 550
   Dik üçgen alanı: 250
   ```

---

## Kod Yapısı

```
Polymorphism.BaseGeometrikSekil
│
├─ Hesaplama.cs       # Base sınıf, virtual metod
├─ Kare.cs            # Kare sınıfı, override ile base hesaplama
├─ Dikdörtgen.cs      # Dikdörtgen sınıfı, override ile base hesaplama
├─ DikÜçgen.cs        # Dik üçgen sınıfı, alan = (g*y)/2
└─ Program.cs         # Uygulamayı başlatan Main metodu
```

---

## Sınıflar ve Metodlar

### Hesaplama

```csharp
public class Hesaplama
{
    public virtual double hesapla(double genislik, double yukseklik)
    {
        return genislik * yukseklik;
    }
}
```

### Kare

```csharp
internal class Kare : Hesaplama
{
    public override double hesapla(double genislik, double yukseklik)
    {
        return base.hesapla(genislik, yukseklik);
    }
}
```

### Dikdörtgen

```csharp
internal class Dikdörtgen : Hesaplama
{
    public override double hesapla(double genislik, double yukseklik)
    {
        return base.hesapla(genislik, yukseklik);
    }
}
```

### DikÜçgen

```csharp
internal class DikÜçgen : Hesaplama
{
    public override double hesapla(double genislik, double yukseklik)
    {
        return (genislik * yukseklik) / 2;
    }
}
```

### Program.cs

```csharp
static void Main()
{
    var kare       = new Kare();
    var dikdortgen = new Dikdörtgen();
    var ucgen      = new DikÜçgen();

    var temel      = new Hesaplama();
    Console.WriteLine("Dikdörtgen alanı (temel sınıfla): " + temel.hesapla(10, 55));
    Console.WriteLine("Dik üçgen alanı: "          + ucgen.hesapla(50, 10));
}
```

---

## Katkıda Bulunma

* Pull request açarak veya issue bildirerek katkıda bulunabilirsiniz.

---

## Lisans

Bu proje MIT lisansı ile lisanslanmıştır. Detaylar LICENSE dosyasında yer almaktadır.
