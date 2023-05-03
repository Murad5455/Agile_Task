using System;

namespace AgileTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2:
            //    int FirestNumber = int.Parse(Console.ReadLine());
            //    if (10 > FirestNumber)
            //    {
            //        Console.WriteLine("10-dan boyuk eded girdiniz");
            //        Console.ReadLine();

            //    }

            //    else if ( FirestNumber <= 100)
            //    {

            //        Console.WriteLine("aa");
            //        Console.ReadLine();
            //    }

            //    else if (100 < FirestNumber)
            //    { 
            //        Console.WriteLine("100-den balaca eded girn");

            //        Console.ReadLine();
            //    }
            //
            //


            //Task1:
            //Console.WriteLine("Birinci imtahanin neticesini girin");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ikinci imtahanin neticesini girin");
            //int b = int.Parse(Console.ReadLine());
            //int c = (a + b) / 2;
            //Console.WriteLine("Iki imtahanin ortalamasi: "+c);


            //Task2:
            //Console.WriteLine("Dogum tarixnizi girin");
            //int DateOfBirth = int.Parse(Console.ReadLine());
            //int Year = 2023;
            //int Age= Year- DateOfBirth;
            //Console.WriteLine(Age+" Yasiniz var");

            //Task3


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

            //task4
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

            //Task5 
            Random random = new Random();
            Console.WriteLine("Ededi tapmaga calisin");
            int a = random.Next(0,100);
            int Number = 0;
            int Counter = 0;
            while (a != Number)
            {
                Counter++;
                Number = Convert.ToInt16(Console.ReadLine());
                if (a == Number)
                  
                        
                {
                
                    Console.WriteLine("Tebrikler ededi tapdiniz");
                   
                }
                   
               if (a > Number)
                { Console.WriteLine("Boyuk eded girin");
                    
                }

                 else if (a < Number)
                { Console.WriteLine("Kicik eded girin");
                    
                }
              
                Console.WriteLine(a);
               
            }
            Console.WriteLine(Counter + " defe yoxladiqdan sonra tapdiniz");

        }


            static void Main1(string[] args)
        {
            Console.WriteLine("Sayita giris ucun adinizi daxil edin");
            string UserName = "admin";
            string Password = "123456";
            

            string Name = Console.ReadLine();
            Console.WriteLine("Sifrenizi daxil edin");
            string Pass = Console.ReadLine();
          
            if (UserName == Name && Pass == Password)
            {
                Console.WriteLine("Sayita xos geldiniz");
            }
           else if(UserName != Name)
            {
                Console.WriteLine("Bele isdifadeci adi tapilmadi");
            }
            else if(Password!=Pass)
            {
                Console.WriteLine("Sifrenizi unutdunuz");
                Console.WriteLine("Yes ve ya no girin");
               
            }
            string a = "yes", b = "Yes";
            string c="no",d = "No";
           
            string Yoxla = Console.ReadLine();
            if (a == Yoxla || b==Yoxla)
            {
                Console.WriteLine("Yeni sifrenizi daxil edin");
                Console.ReadLine();
                Console.WriteLine("Sifreniz ugurla yenilendi");
            }
          
            if(c==Yoxla || d==Yoxla)
            {
                Console.WriteLine("Login seyfesinden cixis ucun enter duymesini sixin");

            }
            
        }
    }
}
