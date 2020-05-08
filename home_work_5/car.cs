using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
  

        class car
        {
            private int speed;

            public car(int speed)
            {
                this.speed = speed;
            }
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            public void up()
            {
                this.speed++;
            }
            public void down()
            {
                this.speed--;
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter speed car");
                int x = int.Parse(Console.ReadLine());
                car car1 = new car(x);
                Console.WriteLine("if you  wont add speed add number if you wont dwon spees sub number if you wont stop enter 999");
                int s = int.Parse(Console.ReadLine());
            if (s == 999) 
            {
                car1.Speed = 0;
                Console.WriteLine($"car stop speed={car1.Speed}");
            }
            else
                if (s<0)
                    {
                        s = s * -1;
                for (int i = 1; i < s; i++)
                    car1.down();
                    }
                else
                {
                for (int i = 1; i < s; i++)
                    car1.up();
            }
            Console.WriteLine($"speed={car1.Speed}");
            car1.down();
            car1.down();
            Console.WriteLine($"speed={car1.Speed}");
            car1.Speed = 0;
            Console.WriteLine($"car stop speed={car1.Speed}");


        }
        }
  
     
}
