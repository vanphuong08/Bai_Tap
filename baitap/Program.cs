using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            //tamgiacdaonguoc();
            //chuvidientichhinhtron();
            /*chanle()*/;
            //daoso();
            //dientichthetichhinhcau();
            tes();
        }
        public static void tamgiacdaonguoc()
        {
            int length = 10;

            for (int i = length; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void chuvidientichhinhtron()
        {
            double r, cv, dt;
            double PI = 3.14;
            Console.Write("Nhap ban kinh duong tron: ");
            r = Convert.ToDouble(Console.ReadLine());
            cv = 2 * PI * r;
            Console.WriteLine("Chu vi duong tron la: {0}", cv);
            dt = PI * 2*r;
            Console.WriteLine("Dien tich duong tron la: {0}", dt);


            



            Console.ReadKey();
        }
        public static void chanle()
        {
            int i;
            do
            {


                Console.Write("Moi ban nhap so: ");
                i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                    Console.WriteLine("{0}: la so chan", i);
                else
                    Console.WriteLine("{0}: la so le", i);
            } while (i > 0);
            Console.ReadLine();
            Console.ReadKey();

        }
        public static void daoso()
        {
            Console.Write("Moi ban nhap day so: ");
            string a = Console.ReadLine();
            string rev = " ";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                rev += a[i];
            }
            Console.WriteLine("So dao nguoc là: {0}",rev);
            Console.ReadKey();

        }
        public static void dientichthetichhinhcau()
        {
            //float r;
            //float pi = 3.1415926535f;
            //Console.Write("Nhap so thu 1: ");
            //int so1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap so thu 2: ");
            //int so2 = Convert.ToInt32(Console.ReadLine());

            //int thuong = so1 / so2;
            //Console.WriteLine("{0} / {1} ={2} ", so1, so2, thuong);
           
            float r;
            double pi = 3.14;

            Console.Write("Nhap ban kinh hinh cau: ");
            r =Convert.ToInt32(Console.ReadLine());

            Console.Write("Dien tich hinh cau la: ");
            Console.WriteLine(4 * pi * (r * 2));

            Console.Write("The tich hinh cau la: ");
            Console.WriteLine(4 / 3 * pi * (r* 3));

            Console.ReadKey();
        }
        public static void tes()
        {
            string user, pass;
            int count = 0;
            Console.Write("Kiem tra ten dang nhap va mat khau:\n");
            Console.Write("Gia tri mac dinh la: user va password\n");
            Console.Write("---------------------------------\n");

            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();

                Console.Write("Mat khau: ");
                pass = Console.ReadLine();

                count++;

            }
            while (((user != "user") || (pass != "password"))
                && (count != 3));

            if (count == 3)
                Console.Write("Dang nhap that bai!");
            else
                Console.Write("Mat khau chinh xac. Ban da dang nhap thanh cong!");

            Console.ReadKey();
        }
    }
}
