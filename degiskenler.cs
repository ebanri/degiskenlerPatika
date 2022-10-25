using System;
 
static void Main(string[] args)
{
    string deger = "naber";  //Sınırsız yer kaplıyor.

    int sayi = 15;
    Console.WriteLine(deger + sayi); //int ataması yapıldıktan sonra string değer ile birleşimi ve çıktısı

    //byte b = 5;      byte 0||255 arasında değer alabilir
    sbyte a = -5;   // sbyte -128||127 arasında değer alabilir
    Console.WriteLine(a);
    //Int16 i16 = 2;  2 byte yer kaplar
    //Int32 i32 = 4;  4 byte yer kaplar 
    //Int64 i64 = 5;  8 byte yer kaplar

    float f = 7.1F; //Ondalıklı sayı , 4 byte yer kaplar
    Console.WriteLine(f); // float sayıyı yazdırmak

    double d = 7.5; //8 byte yer kaplar
    Console.WriteLine(d);

    decimal dec = 21.1M;
    Console.WriteLine(dec);
    //16 byte
    char harf = 'c';
    Console.WriteLine(harf);

    DateTime dt = DateTime.Now; // DateTime kütüphanesinden çağrılır, "DateTime.Now" kodu ile sistemin tarihinin anlık değerini alır.
    Console.WriteLine(dt); // tarihi yazdırmak için

    //Objelere akla gelebilecek her değer atanabilir.
    object o1 = "fatih";
    object o2 = 'f';
    object o3 = 7;
    object o4 = 7.5;
    object o5 = DateTime.Now;
    Console.WriteLine(o1 + " " + o2 + " " + o3 + " " + o4 + " " + o5);

    bool z = true;  //mantıksal, sadece doğru ve yanlış değerlerini alır
    if (z == true)
    {
        Console.WriteLine("z doğrudur");
    }
    else
    {
        Console.WriteLine("z yanlıştır");
    }

    //Değişken Dönüşümleri

    string str20 = "20";
    int int20 = 22;

    string yeni = str20 + int20.ToString();
    Console.WriteLine(yeni);

    int int21 = int20 + Convert.ToInt32(str20);
    Console.WriteLine(int21);

    //Convert.To... ile farklı farklı dönüşümler yapılabilir

    int int22 = int20 + int.Parse(str20);   //42
                                            //Parse string'den dönüşüm için kullanılır

    string tarih = DateTime.Now.ToString("dd.MM.yyyy"); //M=month; m=minute
    Console.WriteLine(tarih);
    //tarihi string değere çevirmek

    //saat
    string saat = DateTime.Now.ToString("HH:mm:ss");
    Console.WriteLine(saat);
