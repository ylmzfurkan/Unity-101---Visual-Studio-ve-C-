//Hello World yazdırma.
Console.WriteLine("Hello, World!");
Console.WriteLine("Furkan");
Console.WriteLine("C# ile programlama öğreniyorum");
//İnt değişken tanımlama.
int oyuncuPuani = 100;
Console.WriteLine(oyuncuPuani);
//Str değişken tanımlama.
string oyuncuAdi = ("Furkan");
Console.WriteLine(oyuncuAdi);
//Yaş tanımlama.
int oyuncuYasi = 26;
Console.WriteLine(oyuncuYasi);
//Değişmeyen değişken atama
const int maksimumHiz = 200;
Console.WriteLine(maksimumHiz);
//Değişken toplama.
oyuncuPuani += 30;
Console.WriteLine(oyuncuPuani);
//Değişken çıkarma.
oyuncuPuani -= 17;
Console.WriteLine(oyuncuPuani);
//Değişken çarpma.
oyuncuPuani *= 5;
Console.WriteLine(oyuncuPuani);
//Değişken bölme.
oyuncuPuani /= 2;
Console.WriteLine(oyuncuPuani);
//Toplu yazdırma.
Console.WriteLine("Oyuncunun Adı : " + oyuncuAdi + " Oyuncunun Yaşı : " + oyuncuYasi + " Oyuncunun Puanı : " + oyuncuPuani);
//Yaş hesaplama.
int dogumYili = 1996;
int Yil = 2023;
Console.WriteLine("Benim Yaşım:" + (Yil - dogumYili));
//Oyun süresi hesaplama.
int oynananSaniye = 3456453;
float oynananDakika = oynananSaniye / 60f;
Console.WriteLine("Oynanan dakika: " + oynananDakika);
//Üçgen alanı bulma.
int dikKenar1 = 21;
int dikKenar2 = 23;
Console.WriteLine("Dik Üçgenin 2 kenarının uzunlukları 21 ve 23");
Console.WriteLine("Bu üçgenin alanı, 2 kenarın çarpımı bölü 2 ' den " + (dikKenar1 * dikKenar2) / 2f + "dir");
