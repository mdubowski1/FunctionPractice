using System;

namespace practicecSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            //String name = "Matthew";
            //Console.WriteLine(name);

            int length = name.Length;
            //Console.WriteLine(length);


            String newName = "";
            */
            /* Print name backwords
            for(int i = name.Length - 1; i >= 0; i--)
            {
                newName += name[i];
                //Console.WriteLine(newName); 
            }
            */
            /* Print Every other letter
            for(int i = 0; i < length; i++)
            {
                
                Console.WriteLine(name[i]);
                i++;
            }
            String capName = name.ToUpper();

            Console.WriteLine(name);
            Console.WriteLine(capName);
            */
            /*
            int[] newArray = new int[5];
            newArray[0] = 3;
            Console.WriteLine(newArray[0]);
            */

            /*EXPONENT
            static double Ex(double x, double y)
            {

                if(y == 0)
                {
                    x = 1;
                }
                else
                {
                    for (double i = 1; i < y; i++)
                    {
                        x *= x;
                    }
                }
                

                return x;
            }
            Console.WriteLine("What is your base number?");
            double Xin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your exponent number?");
            double Yin = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(Ex(Xin, Yin));
            */

            int i = 17 % 3;
            Console.WriteLine(i);

            



            /*
            double m = Math.Pow(5, 2);
            Console.WriteLine(m);
            */

        }
    }
}