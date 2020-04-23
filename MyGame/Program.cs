using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy("Loki");
            Enemy enemy2 = new Enemy("Thor", 100, 100);
            Console.WriteLine(enemy1.Getname());
        }
    }
}
