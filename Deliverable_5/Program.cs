using System;
namespace Deliverable_5
{
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int input = 0;
            Boolean done = false;
            Console.WriteLine("Enter an integer number between 5 and 15");
            while (!done)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("The entry is " + input);
                    if(input >= 5 && input <= 15)
                    {
                        done = true;
                    }
                    else
                    { Console.WriteLine("The number you entered is not between 5 and 15"); 
                    }
                }
                catch
                {
                    Console.WriteLine("Please write an integer between 5 and 15");
                }
            }
           
            int[] MyArray = random_array(input);

            Console.Write("The elements in the random array are: ");
            foreach (int i in MyArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("The sum is : " + sum(MyArray));
        }
    }
}
