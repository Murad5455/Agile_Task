﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AgileTask

{
    public class Program
    {
   
        static List<int> FibonacciSeries(int count)
        {
            List<int> series = new List<int>();

            if (count >= 1)
                series.Add(0);

            if (count >= 2)
                series.Add(1);

            FibonacciHelper(series, count - 2); 

            return series;
        }

        static void FibonacciHelper(List<int> series, int remainingCount)
        {
            if (remainingCount <= 0)
                return;

            int n = series.Count;
            int next = series[n - 1] + series[n - 2];
            series.Add(next);

            FibonacciHelper(series, remainingCount - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Ekrana nece eded ardicil fibonacci ededi cixarilsin?: ");
            int count = int.Parse(Console.ReadLine());

            List<int> fibonacciSeries = FibonacciSeries(count);

            Console.WriteLine("Fibonacci arreyi:");
            foreach (int num in fibonacciSeries)
            {
                Console.Write(num + " ");
            }
        }
    }

}


//    }
//}
//            Program program = new Program();
//            Console.WriteLine("Bir eded daxil edin");
//            int input = int.Parse(Console.ReadLine());

//            Console.WriteLine("Emeliyyatlardan birini secin \n-\n+\n*\n/");
//            string Operation = Console.ReadLine();

//            int a=0;
//            switch (Operation)
//            {
//                case "-":
//                    a = program.minus(input);

//                    break;
//                case "+":

//                   a= program.plus(input);

//                    break;
//                case "*":

//                    a=program.mult(input);
//                    break;
//                case "/":

//                    a = program.divide(input);
//                    break;

//            }

//            Console.WriteLine(a);
//            Console.WriteLine(program.DecimalToBinary(a));
//            //string sayi = Convert.ToString(program.DecimalToBinary(a));
//            Console.WriteLine(program.NumberToText(a));

//        }
//        int p;
//        public Program()
//        {

//            p = 15;

//        }
//        public int plus(int b)
//        {


//            return p + b;
//        }
//        public int minus(int b)
//        {
//            int a = p - b;
//            return a;
//        }
//        public int mult( int b)
//        {

//            return p * b;
//        }
//        public int divide( int b)
//        {

//            return p / b;
//        }

//        string l ="";

//        public string DecimalToBinary(int decimalSayi)
//        {
//            string binarySayi = "";

//            while (decimalSayi > 0)
//            {
//                int rest = decimalSayi % 2;
//                binarySayi = rest.ToString() + binarySayi;
//                decimalSayi = decimalSayi / 2;
//            }

//            l = binarySayi;

//            return l;
//        }

//        public string NumberToText(int number)
//        {

//            string[] onesPlace = { "", "bir", "iki", "üç", "dörd", "beş", "altı", "yeddi", "sekkiz", "doqquz", };
//            string[] tensPlace = { "", "on", "iyirmi", "otuz", "qırx", "elli", "altmış", "yetmiş", "səksən", "doxsan" };

//            int onesDigit = number % 10;
//            int tensDigit = number / 10;

//            return tensPlace[tensDigit] + " " + onesPlace[onesDigit] ;
//        }

//    }
//}


//Oop Task1:
//            Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
//  datalarini saxlasin.
//  Id: sadece oxuna biler auto yaradilacaq.
//  Vezife: daxil edilmeyibse nulldursa Teacher deye set edilsin.
//Ise Baslama tarixi: Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.

//            ArrayList db =new ArrayList();

//            var Th = new Teacher();
//            var Th1 = new Teacher();


//            db.Add(Th);
//            Th.Name = "Murad";
//            Th.SureName = "Qelenderli";
//            Th.DateOfBirth =1990 ;
//            db.Add(Th1);
//            Th1.Name = "Fuad";
//            Th1.SureName = "Orucov";



//            foreach (var item in db)
//            {
//                Teacher teacher = (Teacher)item;
//                Console.WriteLine("Idsi "+teacher.ID);
//                Console.WriteLine("Adi "+teacher.Name);
//                Console.WriteLine("Yasi "+teacher.DateOfBirth);
//                Console.WriteLine("Soyadi "+teacher.SureName);

//            }

//        }

//    }
//    public class Teacher
//    {
//       public int Age;

//        private static int a = 0;
//        public int ID { get; private set; }
//        public Teacher()
//        {
//            ID = ++a;
//        }

//        public string Name { get; set; }
//        public string SureName { get; set; }


//        public int DateOfBirth
//        {
//            get
//            {

//                return Age; }
//            set
//            {
//                int Year = 2023;
//                Age = Year - value;
//                if (Age > 23)
//                { Console.WriteLine("Siz muellim ola bilersiniz"); }
//                else
//                { Console.WriteLine("Siz muellim ola bilmersiniz"); }

//            }
//        }

//        public string Position { get; set; }
//        public int TimeStartWork { get; set; }
//        public string Workplace { get; set; }
//    }

//}

//Oop Task2
//Rubl və dollarla hesab qəbul edən və bütün hesablardakı məbləğin cəmin rublla göstərən funksiya yazın.



//    Console.WriteLine(Hesap(2,10));
//}
//public static double Hesap(double Dollar, double Ruble)
//{
//    double Convert = (Dollar * 100)  * 0.8017;
//    return Ruble + Convert;


//Opp Task3
//            .Kim milyonçu olmaq istəyir» oyununu tərtib edin.
//İstifadəçiyə hər hansı bir mövzuda 4 cavabdan birini seçməli üç sual verin.
//Bütün sualların cavabı düzgündürsə, "Siz qalib gəldiniz", suala səhv cavab olduqda -"Siz məğlub oldunuz" xəbərdarlığı göstərin.                          

//int Counter = 0;
//string Answer1 = "A";
//Console.WriteLine("1-ci sual");
//Console.WriteLine("Formula 1-in yaranma tarixi\n A)1955 \n B)1958 \n C)1948 \n D)1980");
//Console.WriteLine("Cavabinizi daxil edin");

//string Input1 = Console.ReadLine();
//if (Answer1 == Input1.ToUpper())
//{
//    Console.WriteLine("Cavabiniz duzdur");
//    Counter++;
//}
//else { Console.WriteLine("Cavabiniz sehvdir"); }

//string Answer2 = "B";
//Console.WriteLine("2-ci sual");
//Console.WriteLine("Formula 1-in yaranma tarixi\n A)1954 \n B)1953 \n C)1941 \n D)1988");
//Console.WriteLine("Cavabinizi daxil edin");

//string Input2 = Console.ReadLine();
//if (Answer2 == Input2.ToUpper())
//{
//    Console.WriteLine("Cavabiniz duzdur");
//    Counter++;
//}
//else { Console.WriteLine("Cavabiniz sehvdir"); }


//string Answer3 = "C";
//Console.WriteLine("3-cu sual");
//Console.WriteLine("Formula 1-in yaranma tarixi\n A)1954 \n B)1953 \n C)1941 \n D)1988");
//Console.WriteLine("Cavabinizi daxil edin");

//string Input3 = Console.ReadLine();
//if (Answer3 == Input3.ToUpper())
//{
//    Console.WriteLine("Cavabiniz duzdur");
//    Counter++;
//}
//else { Console.WriteLine("Cavabiniz sehvdir"); }

//if (Counter == 3)
//{
//    Console.WriteLine("Siz qalib oldunuz");
//}
//else { Console.WriteLine("Siz meglub oldunuz"); }

//Oop Task4
//            Klaviaturadan 1 - dən 99 - da daxil olmaqla daxil edilmiş ədədi mətnlə ​​yazan funksiya tərtib edin.
//İstifadəçidən 1 ilə 99 arasında rəqəm daxil etməsini tələb edən və onu mətn şəklində konsola çıxaran numberToText funksiyası tərtib edin.

//    Console.WriteLine("1 ile 99 arasında bir reqem daxil edin:");
//    int input = int.Parse(Console.ReadLine());

//    Console.WriteLine(NumberToText(input));

//}

//static string NumberToText(int number)
//{

//        string[] onesPlace = { "", "bir", "iki", "üç", "dörd", "beş", "altı", "yeddi", "səkkiz", "doqquz", };
//        string[] tensPlace = { "", "on", "iyirmi", "otuz", "qırx", "əlli", "altmış", "yetmiş", "səksən", "doxsan" };

//        int onesDigit = number % 10;
//        int tensDigit = number / 10;

//        return tensPlace[tensDigit] + " " + onesPlace[onesDigit];
//    }

//}



//Metod ile kalkulyatir

//    Console.WriteLine("Birci ededi girin");
//    int Number1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Ikinci eded girin");
//    int Number2 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Emeliyyatlardan birini secin  -  +  *  +");

//    string result = Console.ReadLine();

//    switch (result)
//    {
//        case "-":
//            Console.WriteLine(cixma(Number1, Number2));
//            break;
//        case "+":
//            Console.WriteLine(Toplam(Number1, Number2));
//            break;
//        case "*":
//            Console.WriteLine(Vurma(Number1, Number2));
//            break;
//        case "/":
//            Console.WriteLine(Bolme(Number1, Number2));
//            break;

//    }
//}



//public static int cixma(int Number1, int Number2)
//{
//    return Number1 - Number2;
//}
//public static int Toplam(int Number1, int Number2)
//{
//    return Number1 + Number2;
//}
//public static int Vurma(int Number1, int Number2)
//{
//    return Number1 * Number2;
//}
//public static int Bolme(int Number1, int Number2)
//{
//    return Number1 / Number2;



//Task1
//static void logGreeting()
//{
//    Console.WriteLine("Murad is backend developer");
//}
//Task2
//static void User()
//{
//    for (int i = 0; i < 3; i++)
//    {


//        var Name = Console.ReadLine();
//        Console.WriteLine(Name + " is active now");
//    }
//}
//Task3
//static  void Largest()
// {
//     int Number1 = int.Parse(Console.ReadLine());
//     int Number2 = int.Parse(Console.ReadLine());
//     int Number3 = int.Parse(Console.ReadLine());

//     var sourceArray = new int[] { Number1, Number2, Number3 };
//     Console.WriteLine(  sourceArray.Max());
// }
//Task5
//static void Small()

// {
//     int Number1 = int.Parse(Console.ReadLine());
//     int Number2 = int.Parse(Console.ReadLine());
//     int Number3 = int.Parse(Console.ReadLine());

//     var sourceArray = new int[] { Number1, Number2, Number3 };
//     Console.WriteLine(sourceArray.Min());
// }
//Task6
//static void Calc()
//  {
//      int Number1 = int.Parse(Console.ReadLine());
//      int Number2 = int.Parse(Console.ReadLine());
//      Console.WriteLine("Bir emeliyyat novu secin");
//      Console.WriteLine(" 1)- \n 2)+ \n 3)* \n 4)/");
//      int Operation = Convert.ToInt32( Console.ReadLine());

//      switch (Operation)
//      {
//          case 1:

//              Console.WriteLine(Number1 - Number2);
//              break;     case 2:

//              Console.WriteLine(Number1 + Number2);
//              break;     case 3:

//              Console.WriteLine(Number1 * Number2);
//              break;     case 4:

//              Console.WriteLine(Number1 / Number2);
//              break;
//          default:
//              Number1 = 0;
//              Number2 = 0;
//              break;
//      }
//  }
//Task7
//static void isLucky()
//{
//    int Number = Convert.ToInt32(Console.ReadLine());
//    int Sum = (Number / 100000) + ((Number / 10000) % 10) + ((Number / 1000) % 10);
//    int Sum1 = ((Number / 100)%10) + ((Number / 10) % 10) + ((Number / 1) % 10);

//    Console.WriteLine(Sum);
//    Console.WriteLine(Sum1);
//    if (Sum > Sum1)
//    {
//        Console.WriteLine( true);
//    }
//    else Console.WriteLine(false);
//}

//Task8 Alinmadi
//static void Touuper()
//{
//    string Text = Console.ReadLine();
//   string[] arr = new string[] { Text };

//    foreach (var item in arr)
//    {

//        Console.WriteLine(item.Split(" ").First().ToUpper());
//    }
//}
//Task9
//static void TrueFalse()
// {
//     int Number = Convert.ToInt32(Console.ReadLine());
//     if (Number % 2 == 0)
//     {
//         Console.WriteLine(true);
//     }
//     else Console.WriteLine(false);
// }



//Task10
//static void Force()
//{
//    int a = 1;
//    int Number = Convert.ToInt32(Console.ReadLine());
//    for (int i = 0; i < 4; i++)
//    {
//        a *= Number;
//    }
//    Console.WriteLine(a);

//}
//Task11 alinmadi
//static void isvalidnumber()
//{
//    long Number = Convert.ToInt64(Console.ReadLine());

//    string[] arr = new string[] { Number.ToString() };
//    int a = +7;


//    if (arr.==2)
//    {
//        Console.WriteLine(true);

//    }
//    else { Console.WriteLine(false); }

//Task12

//static void numCounter()
//{
//    string text = Console.ReadLine();
//    Console.WriteLine(text.Count()) ;
//}

//Task22

//static void numCounter()
//{

//    int[] arr =  { 45,-7,89,-6 };

//    foreach (var item in arr)
//    {
//        if (item < 0)
//        {

//            Console.WriteLine("Menfi ededler " +item);
//        }

//    }

//}


//Task23
//static void Counter()
//{

//    int[] arr = { 45, -7, 89, -6 };

//    foreach (var item in arr)
//    {
//        if (item > 0)
//        {

//            Console.WriteLine("Musbet ededler " + item);
//        }

//    }

//}
//Task24

//static void callback()
//{
//    string[] arr =new string[] {"Michael","Trevor","Franklin","Lamar","Jimmy" };



//        foreach (var item in arr)
//    {
//        Console.WriteLine("_ _ _ _ _\n ");

//            Console.WriteLine(item);
//        Console.WriteLine("_ _ _ _ _ ");
//    }

//    foreach (var item in arr)
//    {


//        Console.WriteLine("<3<3<3<3 "+item+ " <3<3<3<3 ");

//    }
//    foreach (var item in arr)
//    {
//        for (int i = 0; i < item.Length-5; i++)
//        {
//            Console.WriteLine(i+" - "+ item);
//        }



//    }

//}
//Task25

//static void ToUpper()
//{
//    string Text = Console.ReadLine();
//    Console.WriteLine(Text.ToUpper());
//}














//Task4
//int Counter = 0;
//string Answer1 = "A";
//Console.WriteLine("1-ci sual");
//Console.WriteLine("Formula 1-in yaranma tarixi\n A)1955 \n B)1958 \n C)1948 \n D)1980");
//Console.WriteLine("Cavabinizi daxil edin");

//string Input1 = Console.ReadLine();
//if (Answer1 == Input1.ToUpper())
//{
//    Console.WriteLine("Cavabiniz duzdur");
//    Counter++;
//}
//else { Console.WriteLine("Cavabiniz sehvdir"); }

//string Answer2 = "B";
//Console.WriteLine("2-ci sual");
//Console.WriteLine("Formula 1-in yaranma tarixi\n A)1954 \n B)1953 \n C)1941 \n D)1988");
//Console.WriteLine("Cavabinizi daxil edin");

//string Input2 = Console.ReadLine();
//if (Answer2 == Input2.ToUpper())
//{
//    Console.WriteLine("Cavabiniz duzdur");
//    Counter++;
//}
//else { Console.WriteLine("Cavabiniz sehvdir"); }


//string Answer3 = "C";
//Console.WriteLine("3-ci sual");
//Console.WriteLine("Formula 1-in yaranma tarixi\n A)1954 \n B)1953 \n C)1941 \n D)1988");
//Console.WriteLine("Cavabinizi daxil edin");

//string Input3 = Console.ReadLine();
//if (Answer3 == Input3.ToUpper())
//{
//    Console.WriteLine("Cavabiniz duzdur");
//    Counter++;
//}
//else { Console.WriteLine("Cavabiniz sehvdir"); }

//if (Counter == 3)
//{
//    Console.WriteLine("Siz qalib oldunuz");
//}
//else { Console.WriteLine("Siz meglub oldunuz"); }





























//New task:1
//Console.WriteLine("Iki reqemli eded girin");
//int Number = Convert.ToInt16(Console.ReadLine());
//int Sum = 0;
//while (Number<=100)
//{
//        Number += 7;
//    Sum = Number;
//}
//Console.WriteLine(Sum);

//new task:2
//int Number = int.Parse(Console.ReadLine());
//for (int i = 0; i < Number; i++)
//{
//    Console.WriteLine("I know how to use cycles");

//}
//new task:3

//for(int i=100; i<=1000;i++)
//   {
//       if(i%10==0)
//       { Console.WriteLine(i); }
//   }
//new task4:
//int Sum = 0;
//for (int i = 0; i < 100; i++)
//{
//    Sum += i;
//}
//Console.WriteLine(Sum);
//new task5:
// int Sum = 0;
// int Number = Convert.ToInt16(Console.ReadLine());
// for (int i = 100; i <=1000; i++)
// {
//     if (i % Number == 0)
//     {
//         Sum += i;
//         }

// }
//Console.WriteLine(Sum);

//new task:6


//    Console.WriteLine("Sade ededleri tapan proqram");
//    Console.Write("Girilen eded: ");
//    int Number = Convert.ToInt16(Console.ReadLine());

//    for (int i = 0; i <= Number; i++)
//    {

//    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)

//    {
//            Console.WriteLine(i);
//        Console.WriteLine("Bu sade edetdir");
//    }

//}
//New task: 7
//int Answer = 1;
//for (int i = 1; i <= 10; i++)
//{
//    Answer *= i;

//}
//Console.WriteLine("Cavab: "+ Answer);

//New task:8 mmm???

//string str = Console.ReadLine();
//Console.WriteLine(str.GetType());
//string NewStr = string.Join("", str.ToCharArray().Reverse());
//Console.WriteLine(NewStr);

//New task:9
//string text = Console.ReadLine();

//var a= text.IndexOf(".");
//Console.WriteLine(a);

//New task:10 alinmadi
//Console.WriteLine("Metin daxil edin");





////New task:11 alinmadi
////  int w = 0;
//int sayi = int.Parse(Console.ReadLine());
//for (int i = 1; i <= sayi; i++)
//    {
//    for (int j = -1; j < i; j++)
//    {
//        int w = i + j;


//        Console.WriteLine(w);

//    }
//    }

//Array task: 1
//string[] arr= new string[3];
//arr[0] = "Murad";
//arr[1] = "Imran";
//arr[2] = "Cavansir";
//arr[1] = "Classified";
//Console.WriteLine(arr[1]);

//Array task: 2

//int[] arr = new int[5];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = int.Parse(Console.ReadLine());

//}
//Console.WriteLine("En kicik eded"+arr.Min());




//int[] arr = new int[3];
//Console.WriteLine("********** Imtahan ortalamasini tapan proqram ***********");
//Console.WriteLine("Adnizi daxil edin");
//string Name = Console.ReadLine();
//Console.WriteLine("Soyadinizi daxil edin");
//string SurName = Console.ReadLine();
//Console.WriteLine("********** Imtahan neticelernizi girin ***********");

//int Sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    while (true)
//    {
//        try
//        {
//            Console.WriteLine(i + 1 + " -ci imtahanin neticelerini girin");
//            arr[i] = Convert.ToInt16(Console.ReadLine());
//            if (0 < arr[i] && 100>=arr[i] )
//            {
//                Sum += arr[i];
//                break;
//            }
//            else 
//            { 
//                Console.WriteLine("0 ve 100 araliginda eded girin"); 
//            }
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Simvol ve ya heriflerden istifade etmeyin");

//        }


//    }
//}
//int Avg = Sum / 3;
//Console.WriteLine("Neticeleri girilen imtahan isdirakcisinin ad ve soyadi");
//Console.WriteLine($"{Name}{" "}{SurName}");
//if (Avg >= 81)
//{

//    Console.WriteLine("Imtahan ortalamaniz "+Avg + " diplom isine dusmur");

//}
//else 
//{ 
//    Console.WriteLine("Imtahan ortalamaniz "+ Avg + " diplom isine dusur"); }






















//static void Main4(string[] args)
//{
//    Console.WriteLine("********** Imtahan ortalamasini tapan proqram ***********");
//    //Console.WriteLine("Adnizi daxil edin");
//    //string Name = Console.ReadLine();
//    //Console.WriteLine("Soyadinizi daxil edin");
//    //string SurName = Console.ReadLine();
//    Console.WriteLine("********** Imtahan neticelernizi girin ***********");





//    int def = 0;




//    //Console.WriteLine("Birinci imtahanin neticesini girin");
//    //int Imtahan1 = Convert.ToInt16(Console.ReadLine());
//    //if (0 <= Imtahan1 && 100 >= Imtahan1 || Imtahan1==default)

//    //{
//    //    def += 51;
//    //    Console.WriteLine("Eger bos kecerseniz default deyer olaraq 51 goturulecek");
//    //}
//    //else
//    //{
//    //    Console.WriteLine("0-100 arliginda eded girin");
//    //}
//    //Console.WriteLine("Ikinci imtahanin neticesini girin");
//    //int Imtahan2 = Convert.ToInt16(Console.ReadLine());
//    //if (0 <= Imtahan2 && 100 >= Imtahan2 || Imtahan2==default)

//    //{
//    //    def += 51;
//    //    Console.WriteLine("Eger bos kecerseniz default deyer olaraq 51 goturulecek");

//    //}
//    //else
//    //{
//    //    Console.WriteLine("0-100 arliginda eded girin");

//    //}
//    //Console.WriteLine("Ucuncu imtahanin neticesini girin");
//    //int Imtahan3 = Convert.ToInt16(Console.ReadLine());

//    //if (0 <= Imtahan3 && 100 >= Imtahan3 || Imtahan3==default)

//    //{
//    //    def += 51;
//    //    Console.WriteLine("Eger bos kecerseniz default deyer olaraq 51 goturulecek");

//    //}
//    //else
//    //{
//    //    Console.WriteLine("0-100 arliginda eded girin");

//    //}

//    Console.WriteLine("Birinci imtahanin neticesini girin");
//    int Imtahan1 = Convert.ToInt16(Console.ReadLine());
//    if (0 >= Imtahan1 && 100 <= Imtahan1 || Imtahan1 == default)

//    {
//        Console.WriteLine("0-100 arliginda eded girin");

//    }
//    else
//    {
//        def += 51;
//        Console.WriteLine("Eger bos kecerseniz default deyer olaraq 51 goturulecek");

//    }
//    b


//    Console.WriteLine(def+"aa");

//switch ()
//{
//    default:
//}





//    static void Main2(string[] args)
//{

//Task1:Ortalamani tapan proqram
//Console.WriteLine("Birinci imtahanin neticesini girin");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Ikinci imtahanin neticesini girin");
//int b = int.Parse(Console.ReadLine());
//int c = (a + b) / 2;
//Console.WriteLine("Iki imtahanin ortalamasi: "+c);


//Task2:Yasi tapan proqram
//Console.WriteLine("Dogum tarixnizi girin");
//int DateOfBirth = int.Parse(Console.ReadLine());
//int Year = 2023;
//int Age= Year- DateOfBirth;
//Console.WriteLine(Age+" Yasiniz var");

//Task3O:Aylari getiren proqram


//Console.WriteLine("Fesileri girdikde aylari yazdiran proqram");
//string Chapter = Console.ReadLine();
//    switch (Chapter)
//    {
//    case "Qis":
//        Console.WriteLine("Dekabr,Yanvar,Fevral");
//    break;
//    case "Yaz":
//        Console.WriteLine("Mart,Aprel,May");
//    break;
//    case "Yay":
//        Console.WriteLine("Iyun,Iyul,Avqust");
//    break;
//    case "Payiz":
//        Console.WriteLine("Sentyabr,Oktyabr,Noyabr");
//    break;
// default:Console.WriteLine("Sef girdiniz");
//    break;
//}

//task4:Yas heddi
//Console.WriteLine("***********Suruculuk vesiqesi almaq ucun muraciyet************");
//Console.WriteLine();
//Console.WriteLine("Dogum tarixinizi girin");
//int DateOfBirth = int.Parse(Console.ReadLine());
//int year = 2023;
//int Age = year - DateOfBirth;
//if(Age>18)
//{
//    Console.WriteLine("Suruculuk vesiqesi ucun muraciyyet ede bilersiniz");
//}
//if (Age < 18)
//{
//    Console.WriteLine("Suruculuk vesiqesi ucun muraciyyet ede bilmersiniz");
//    int Difference = 18 - Age;
//    Console.WriteLine("Muraciyyet etmek ucun "+Difference+" il gozlemelisiniz");
//}

//Task5 :Rasgele reqemlerle oyun
//    Random random = new Random();
//    Console.WriteLine("Ededi tapmaga calisin");
//    int a = random.Next(0,100);
//    int Number = 0;
//    int Counter = 0;
//    while (a != Number)
//    {
//        Counter++;
//        Number = Convert.ToInt16(Console.ReadLine());
//        if (a == Number)


//        {

//            Console.WriteLine("Tebrikler ededi tapdiniz");

//        }

//       if (a > Number)
//        { Console.WriteLine("Boyuk eded girin");

//        }

//         else if (a < Number)
//        { Console.WriteLine("Kicik eded girin");

//        }

//        Console.WriteLine(a);

//    }
//    Console.WriteLine(Counter + " defe yoxladiqdan sonra tapdiniz");




//static void Main1(string[] args)
//        {
//            Console.WriteLine("Sayita giris ucun adinizi daxil edin");
//            string UserName = "admin";
//            string Password = "123456";


//            string Name = Console.ReadLine();
//            Console.WriteLine("Sifrenizi daxil edin");
//            string Pass = Console.ReadLine();

//            if (UserName == Name && Pass == Password)
//            {
//                Console.WriteLine("Sayita xos geldiniz");
//            }
//           else if(UserName != Name)
//            {
//                Console.WriteLine("Bele isdifadeci adi tapilmadi");
//            }
//            else if(Password!=Pass)
//            {
//                Console.WriteLine("Sifrenizi unutdunuz");
//                Console.WriteLine("Yes ve ya no girin");

//            }
//            string a = "yes", b = "Yes";
//            string c="no",d = "No";

//            string Yoxla = Console.ReadLine();
//            if (a == Yoxla || b==Yoxla)
//            {
//                Console.WriteLine("Yeni sifrenizi daxil edin");
//                Console.ReadLine();
//                Console.WriteLine("Sifreniz ugurla yenilendi");
//            }

//            if(c==Yoxla || d==Yoxla)
//            {
//                Console.WriteLine("Login seyfesinden cixis ucun enter duymesini sixin");

//            }

//        }


