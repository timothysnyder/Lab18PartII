using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18PartII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, ctr;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\tThis Program Will Count the Frequency of Each Number You Enter:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t*****************************************************************\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nHow Many Numbers Would You Like in Your Array :");
            Console.ForegroundColor = ConsoleColor.White;
            n = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nPlease Enter {0} the Numbers You Want Stored in the array :\n", n);
            Console.ForegroundColor = ConsoleColor.White;
            for (i = 0; i < n; i++)
            {
                Console.Write("Enter Number for Element: * {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }


            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
                }
            }

        }
    }
}
