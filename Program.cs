using System;
using System.Linq;

namespace AgileTask

{
    class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}



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


