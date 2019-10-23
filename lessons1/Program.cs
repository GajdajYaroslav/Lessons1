using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost = 0;
            do
            {
                cost = Convert.ToInt32(Console.ReadLine());
                if (cost <= 0)
                {
                    Console.WriteLine("Please re-enter cost!");
                }
            } while (cost <= 0);
            if (cost < 80)
            {
                if (cost >= 70)
                {
                    Console.WriteLine("You can buy " + cost / 70 + " Hoegarden your rest " + cost % 70);
                }
                else
                {
                    if (cost >= 60)
                    {
                        Console.WriteLine("You can buy " + cost / 60 + " Stella your rest " + cost % 60);
                    }
                    else
                    {
                        if (cost >= 7)
                        {
                            Console.WriteLine("You can buy " + cost / 7 + " Obolon your rest " + cost % 7);
                        }
                        else
                        {
                            Console.WriteLine("You can't buy anything");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You can buy " + cost / 80 + " Leff your rest " + cost % 80);
            }

            //int num = 0;
            //do
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num <= 0)
            //    {
            //        Console.WriteLine("Please re-enter number!");
            //    }
            //} while (num <= 0);
            //if (num >= 500)
            //{
            //    Console.WriteLine("Your discount: 5% ,amount to be paid: " + (num - (num * 5) / 100));
            //}
            //else
            //{
            //    if (num >= 0 && num < 300)
            //    {
            //        Console.WriteLine("Your discount: 0% ,amount to be paid: " + num);
            //    }
            //    else
            //    {
            //        if (num >= 300 && num < 400)
            //        {
            //            Console.WriteLine("Your discount: 2% ,amount to be paid: " + (num - (num * 2) / 100));
            //        }
            //        else
            //        {
            //            if (num >= 400 && num < 500)
            //            {
            //                Console.WriteLine("Your discount: 3% ,amount to be paid: " + (num - (num * 3) / 100));
            //            }
            //        }
            //    }
            //}
        }
    }
}
