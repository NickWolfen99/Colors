using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of colors:");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter: 1 for red; 2 for blue; 3 for white.  ");

            string[] colorsarray = new string[n];

            string[] colors = { "red","blue","white" };

            for (int i = 0; i < n; i++)
            {
                int index = Convert.ToInt16(Console.ReadLine());
                colorsarray[i] = colors[index-1];
            }

            Console.WriteLine("Your colors are:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(colorsarray[i]);

            int counter = 0;
            string swap;
            for (int i = 0; i < n; i++)
            {
                if (colorsarray[i] == "red")
                {
                    if(counter!=i)
                    {
                        swap = colorsarray[counter];
                        colorsarray[counter] = colorsarray[i];
                        colorsarray[i]=swap;
                    }
                    counter++;

                }
            }
            for (int i = 0; i < n; i++)
            {
                if (colorsarray[i] == "blue")
                {
                    if (counter != i)
                    {
                        swap = colorsarray[counter];
                        colorsarray[counter] = colorsarray[i];
                        colorsarray[i] = swap;
                    }
                    counter++;

                }
            }

            Console.WriteLine("");
            Console.WriteLine("Your arranged colors are:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(colorsarray[i]);

            Console.ReadLine();
        }
    }
}
