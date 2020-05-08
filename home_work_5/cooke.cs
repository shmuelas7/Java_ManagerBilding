using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class car
    {
       private int speed;

        public cooke(int speed)
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
        public void dowen()
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
            Console.WriteLine("if you  wont up speed prees 1 if you wont dowen speed prees 0");
            int s = int.Parse(Console.ReadLine());
            if (s)
            {
                car1.up();
            }
            else
            {
                car1.dowen();
            }

            Console.WriteLine($"speed={car1.Speed}");
        }
    }
}
