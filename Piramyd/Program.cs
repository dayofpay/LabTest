using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramyd
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = gatherServerInfo.getCos; i >= gatherServerInfo.getAngle; i--)
            {
                if (i == gatherServerInfo.getAngle)
                {
                    for(int b = gatherServerInfo.getCos; b >= gatherServerInfo.getAngle; b--)
                    {
                        if (b == gatherServerInfo.getAngle)
                        {
                            b -= Math.Min(b,i); // << Изваждаме стойноста докато ъглите не съвпаднат със картината, която е генерирана от изкуствения интелект
                        }
                        else
                        {
                            Console.WriteLine(Math.Sqrt(i) + i * Math.Tan(b)); // Намираме корена на стойноста i, след което го прибавяме към стойноста на тангенса на b
                        }
                    }
                    for(int c = gatherServerInfo.getCos; c >= gatherServerInfo.getAngle; c--)
                    {
                        if (c == gatherServerInfo.getAngle)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(Math.Cos(c) + i / gatherServerInfo.getCos * 2 * (gatherServerInfo.getCos * gatherServerInfo.getAngle));
                        } // Измерване на ъглите в картината, която е зададена от потребителя
                    }
                    for(int d = gatherServerInfo.getCos; d>= gatherServerInfo.getAngle; d--)
                    {
                        if (d == gatherServerInfo.getAngle)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Statement 4");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Statement 1 ");
                }
            }
        }
        // *
        // **
        // ***
        /// <summary>
        /// ****
        /// </summary>
        /// 
        public static void ResetMatrix()
        {
            int sideLength = int.Parse(Console.ReadLine());
            for (int row = 1; row <= sideLength; row++)
            {
                for (int col = 1; col <= sideLength; col++)
                {
                    if (col <= row)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Math.Sqrt(col) + "*@");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Math.Sin(row) + "*/*" + Math.Cos(Math.Sqrt(col)));
                    }
                }
                Console.WriteLine();
            }
        }
        public static void TestNonPositive()
        {
            for (int row = 8; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public static void Test2()
        {
            int sideLength = 50;
            for (int row = 1; row <= sideLength; row++)
            {
                for (int col = 1; col <= sideLength; col++)
                {
                    if (col <= row)
                        Console.Write('*');
                    else
                        Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}
