using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCalculator11
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            Rectangle rect = new Rectangle();
            Console.WriteLine("Please Enter the width of the rectangle");
            try
            {
                rect.Width = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please Enter number value the width of the rectangle");
                rect.Width = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please Enter the lenght of the rectangle");
            try
            {
                rect.Length = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please Enter number value the length of the rectangle");
                rect.Length = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("1.Get Recangle Lenght");
            Console.WriteLine("2.Change Recangle Lenght");
            Console.WriteLine("3.Get Recangle Width");
            Console.WriteLine("4.Change Recangle width");
            Console.WriteLine("5.Get Recangle Parimeter");
            Console.WriteLine("6.Get Recangle Area");
            Console.WriteLine("7.Exit");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if (choice == 1)
                {
                    Console.WriteLine("Please Enter the lenght of the rectangle");
                    rect.Length = Convert.ToInt32(Console.ReadLine());
                }
                if (choice == 2)
                {
                    Console.WriteLine("Please Enter the lenght of the rectangle");
                    rect.Length = Convert.ToInt32(Console.ReadLine());
                }
                if (choice == 3)
                {
                    Console.WriteLine("Please Enter the width of the rectangle");
                    rect.Width = Convert.ToInt32(Console.ReadLine());
                }
                if (choice == 4)
                {
                    Console.WriteLine("Please Enter the width of the rectangle");
                    rect.Width = Convert.ToInt32(Console.ReadLine());
                }
                if (choice == 5)
                {
                    Console.WriteLine((rect.Width * 2) + (rect.Length * 2));
                }
                if (choice == 6)
                {
                    Console.WriteLine(rect.Width * rect.Length);
                }
                if (choice == 7)
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
