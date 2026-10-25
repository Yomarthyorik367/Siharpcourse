using System;
using System.Net.Http;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {

        // Пишите код внутри Main
        // Console.WriteLine("привет,мое имя Роберт мне 14 лет ");
        // Console.WriteLine("занимаюсь спортом ");
        //Console.WriteLine("занимаюсь музыкой");

        //string name = "Роберт";
        //Console.WriteLine("мое имя:" + name);
        //ввел переменную вней вписал имя далее вывожу через консоль "мое имя"+ переменная 
        //int age = 14;


        //Console.WriteLine("мой возраст" + age);
        // все тоже самое но выводил свой возраст "так же через консоль" а так же поменя свой возраст на 15 с помошью "age"
        //Console.WriteLine("мой возраст:" + age);
        //age = 15;
        // Console.WriteLine("мой возраст:" + age);
        // age = 16;
        //Console.WriteLine("мой возраст:" + age);

        // string name = "robert";
        // int age = 14;
        // double body=170;
        //bool farm=true;
        //Console.WriteLine("мне нравится программировать:" + farm);

        //Console.WriteLine("Hello,World");
        //Console.WriteLine("Роберт");


        //string message = ("Hello,World");
        //Console.WriteLine(message);

        //string wer = ("привет,я Роберт");
        //Console.WriteLine(wer);

        //string name = "Роберт";
        //int age = 14;
        //double hight = 170;
        //bool rty = true;
        //Console.WriteLine("имя: " + name);
        //Console.WriteLine("возраст: " + age);
        //Console.WriteLine("рост: " + hight);
        //Console.WriteLine("Мне нравится программировать: "+  rty);
        //string name = "Роберт";
        //char firstLetter= 'Р';
        //Console.WriteLine("имя:" + name   + ", Первая буква имени: "   + firstLetter);
        //const int DaysInWeek = 7;
        // int age = 14;
        //Console.WriteLine(age + DaysInWeek);

        //int a = 3;

        //int b = 4;
        //Console.WriteLine(a + b);
        //Console.WriteLine(a - b);
        //Console.WriteLine(a * b);
        //Console.WriteLine(a / b);

        //int a = 10;
        // int b = 20;

        //  Console.WriteLine(a);
        //double widht = 5.5;
        // double height = 3;
        //Console.WriteLine(widht+height+widht+height);
        //  Console.WriteLine(widht * height);


        //int it = 350;
        //int at = 120;
        //  int discount = 50;
        // C//onsole.WriteLine(it + at - discount);
        //  int number = 42;
        ///int a = 50;
        // int b = 4;
        // int c = a+b -a * 2 / b;

        // Console.WriteLine(number+a+b+c);

        //int a = 10;
        //  int b = 5;
        //  int c = 2;
        //Console.WriteLine(a * b * c / c);
        // Console.WriteLine(a * b * c);


        /// задание №1

        // Console.WriteLine("Введи первое число ");
        //  string input = Console.ReadLine();
        //int number=Convert.ToInt32(input);
        // Console.WriteLine("Введи второе число ");
        // string red= Console.ReadLine();
        //int first = Convert.ToInt32(input);

        //Задание №2
        /*
        Console.WriteLine("Введите длину комнаты");
        string length = Console.ReadLine();

         Console.WriteLine("Введите ширину комнаты");
         string width = Console.ReadLine();

         double Dlenght=Convert.ToDouble(length);
         double Dwidht= Convert.ToDouble(width);

         double sqare = Dlenght*Dwidht;
         double perimetr = 2*(Dlenght + Dwidht);
         Console.WriteLine("Площадь:"+sqare+" Периметр:"+perimetr);
         */

        //Задание №3
        Console.WriteLine("Выполнено домашнее задание ");
        string homework = Console.ReadLine();
        bool homewor = Convert.ToBoolean(homework);
        
        Console.WriteLine("Сколько минут протребовалось ");
        string timeUP = Console.ReadLine();
        int tme = Convert.ToInt32(timeUP);
       
        int hour = 60;
        double secod=(double)tme/hour;
        Console.WriteLine(secod);

    }
}