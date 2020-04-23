using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int EnemyNr;
            Enemy[] enemies;

            Console.Write("Insira nr de enimigos: ");

            EnemyNr = Convert.ToInt32(Console.ReadLine());

            enemies = new Enemy[EnemyNr];

            for (int i = 0; i < EnemyNr; i++)
            {
                string name;
                Console.Write($"Insira nome de enimigo: #{i}");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name);
            }


            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine(enemy.Getname());
            }
        }
    }
}
