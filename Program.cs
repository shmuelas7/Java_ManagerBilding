using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER TO NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine($"Num of elements: {num}, num to mul:{num2}");
            for (int i =0; i < arr.Length;i++)
            {
                arr[i] = i * num2;
                Console.Write(arr[i] + ", ");
            }

        }
    }
}
