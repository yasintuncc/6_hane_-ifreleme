using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6_hane_şifreleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int password = random.Next(100000, 1000000);

            Console.WriteLine("Oluşturulan Şifre: " + password);

            
            for (int i = 10; i >= 0; i--)
            {
                
                Thread.Sleep(1000);
            }
            Console.WriteLine(" yeni şifreyi "  );
            Console.WriteLine("Şifre süresi doldu. Yeni bir şifre oluşturmanız gerekir ");

            Random random2 = new Random();
            int password2 = random.Next(100000, 1000000);

            Console.WriteLine("Oluşturulan Şifre: " + password2);

            Console.ReadLine();
        }
    }
 }

