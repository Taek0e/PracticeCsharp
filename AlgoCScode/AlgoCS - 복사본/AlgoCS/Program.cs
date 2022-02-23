using System;

namespace AlgoCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int count = 0;

            if (N >= 3 && N <= 5000)
            {
                while (N > 0)
                {
                    if (N % 5 == 0)
                    {
                        N -= 5;
                        count++;
                    }
                    else if (N % 3 == 0)
                    {
                        N -= 3;
                        count++;
                    }
                    else if (N >= 5)
                    {
                        N -= 5;
                        count++;
                    }
                    else if (N >= 3)
                    {
                        N -= 3;
                        count++;
                    }
                    else
                    {
                        count = -1;
                        break;
                    }
                }

                Console.WriteLine(count);
            }
            
            



        }
    }
}
