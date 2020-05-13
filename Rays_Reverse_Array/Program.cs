using System;

namespace Rays_Reverse_Array
{
    class Program
    {

        static int getInt()
        {
            int result = 0;
            string answer = Console.ReadLine();

            Int32.TryParse(answer, out result);

            return result;
        }

        static void Main(string[] args)
        {

            int[] a = new int[5]; // Create an array of int and initialize it

            for(int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter integer " + (i+1) + " of " + a.Length + ": ");
                a[i] = getInt();
            }

            for(int i = (a.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
