using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
  
            string[][] matrix4 = new string[2][];
            for (int i = 0; i > matrix4.Length; i++)
            {
                for (int j = 0;j> matrix4[i].Length ; j++)
                {
                    if (i == j)
                        matrix4[i][j] = "Main";
                    if (i == j && (i + j == matrix4.Length))
                        matrix4[i][j] = "center";
                    else
                    if (j > i&& i + j != matrix4.Length)
                        matrix4[i][j] = "up";
                    else
                    if (i > j && i+j != matrix4.Length)
                        matrix4[i][j] = "down";
                    else
                        matrix4[i][j] = "sub";
                }

            }


            for (int row = 0; row < matrix4.Length; row++)
            {
                for (int col = 0; col < matrix4[row].Length; col++)
                {
                    Console.Write($"[ {matrix4[row][col]} ]");
                }
                Console.ReadKey();

            }
        }
    }
}
