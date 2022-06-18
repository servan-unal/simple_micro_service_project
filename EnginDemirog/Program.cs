using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace EnginDemirog
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "ŞERVAN";
            person1.LastName = "ÖNAL";
            person1.NationalIdentity = 11111111111; // yanlış olan Tc
            person1.DateofBirthYear = 1998;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }        
    }
}


/*

Artık List yerine GenericKoleksiyon kullanılıyor.

List<string> YeniSehirler = new List<string> {"Ankara"....};
GenericKoleksiyonlar girilen kadar değer kaplar. ve girilecek değerin tipini de yazmak gerekir <string>
**List bir sınıftır. o yüzden referans tiplidir.
 */
//sınıflar default olarak internal olur. bunu başka projede kullanmak için public yapmak gerekir.


//mesela farklı sınıflarda selam yazdırıcam. Yazdırdığım selamın sonrasında değiştirmek istedim
//gibip o selamı değişkene atıyorum ve değişkenin adını sınıflarda yazdırıyorum.
//artık sadece değişkenin içini değiştirdiğimde diğer sınıflarda da değişmiş oluyor.
//** kodları seçip refactoring yapınca otomatik olarak mehtodu oluşturup
//main içine methofun ismini yazıyor.
//degiskenler();

/* PAscal case yani kelimelerin ilk harfi büyük gerisi küçük.
Örn: Ogrenciadi
Camelcase ise ilk harfi büyük ve birleşik olan 2. kelimesinin ilk harfi de büyüktür.
Örn: OgrencAdi
*/

//Arrays
/*
 Arrayler, classlar, İnterfaceler, Abstraclar ; bunların tamamı referans
tipi olarak bellekte tutuluyor.
Mesela string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kasım";
ogrenciler[2] = "Ahmet";
diye bir array oluşturdum. ve sonrasında diyorumki bu arrayime 4. elemanı eklemek istiyorum.
ogrenciler = new string[4];
ogrenciler[3] = "Ahmet";

dersem ve sonrasında bunu çalıştırırsam program bana newlediğim arrayi getirecek. yani 
içinde sadece 3. indexinde olan new lediğim arrayi getirecek.

yani stack te ogrenciler adlı array im duruyor o da heapteki [] içindeki
isimleri tutuyor.

new ogrenciler dediğimde

stack teki ogrenciler arrayi benim new lediğim 
heapteki [ , , , Ahmet] arrayini çapğırıyor.

ben bir referans tipli değişken oluşturduğumda yani array mesela.
o array stacteki array ismi bir referans numarası alıyor, arrayleri
eşitlediğimizde arrayin içindekini atmıyoruz sadece referans numarasını diğer değişkene atıyoruz.
bu sefer 2 değişkende aynı alanları referans ediyor oluyorlar.

Değer tipli değişkenlerde int, bool, double
bunlardaki tüm işlemler bellekteki stack te yapılır. yani değişken adı da ve içindeki değer de 
stack içindedir. onun için bir değer tipliden diğer değer tipliye atama yapmak istediğimizde
içindeki değerler atanır.

mantığı da şuradan gelir değer tipli değişkenler eşitlendiğinde birbirlerine değer atarlar,
referans tipli değişkenler birbirlerine referans atarlar. array, class, interface, abstact.
Yani referans tiplinin oku eşitlenen referans tiplinin değişkenine yönelir. 

meselaa 
int a = 10
int b = 20
b = a ;
a = 20 dediğimde ;;
b nedir??

a =>b ye 3. satırda zaten değer gönderdi ve o değer orada kaldı. bir daha a nın değerini değiştirmem b yi
değiştirmez artık o a nın ilk değerini aldı.

Değişken türleri:  "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
Referans türleri:  "string", "object", "class", "interface", "array", "delegate", "pointer"
 * */

//string[] ogrenciler = new string[3];
//ogrenciler[0] = "Engin";
//ogrenciler[1] = "Kasım";
//ogrenciler[2] = "Ahmet";

//for (int i = 0; i < ogrenciler.Length; i++)
//{
//    Console.WriteLine(ogrenciler[i]);
//}


