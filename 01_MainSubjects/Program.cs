using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("****** Yemek Kategorileri ******");
            //Console.WriteLine("");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçeçekler");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Kategorileri ******");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Ağit";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 21 72";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("****** Rezarvasyon Kartı ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName+""+customerSurname);
            //Console.WriteLine("İletişim"+customerPhone);
            //Console.WriteLine("Email Adresi:"+ customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("----------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 500 400 21 21";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + "" + customerSurname);
            //Console.WriteLine("İletişim" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("----------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı");
            Console.WriteLine();
            Console.WriteLine("------Hamburger:"+ hamburgerPrice+"₺");
            Console.WriteLine("------Pizza:"+ pizzaPrice+"₺");
            Console.WriteLine("------Kola:"+ cokePrice+"₺");
            Console.WriteLine("------Lemonade:"+ lemonadePrice+"₺");
            Console.WriteLine("------Kızartma:"+ friesPrice+"₺");
            Console.WriteLine("------Su:"+ waterPrice+"₺");
            Console.WriteLine() ;
            Console.WriteLine("------Hamburger:"+ hamburgerPrice+"₺");


            Console.WriteLine();
            int hambugerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hambugerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            
            totalHamburgerPrice= hambugerCount*hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutar:"+totalHamburgerPrice+"TL");
            Console.WriteLine("Pizza Tutar:"+ totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutar:"+ totalFriesPrice + "TL");
            Console.WriteLine("Kola Tutar:"+ totalCokePrice + "TL");
            Console.WriteLine("Limonata Tutar:"+ totalLemonadePrice + "TL");
            Console.WriteLine("Su Tutar:"+ totalWaterPrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar"+totalPrice+"TL");
            #endregion

            Console.Read();
        }
    }
}




//Yazdırma Komutları 