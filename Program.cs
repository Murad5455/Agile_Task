using System;

namespace AgileTask
{
    class Program
    {
        static void Main(string[] args)
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
