using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int EnemyNr;
            Enemy[] enemies;
            Random random = new Random();

            Console.Write("Insira nr de enimigos: ");

            EnemyNr = Convert.ToInt32(Console.ReadLine());

            enemies = new Enemy[EnemyNr];

            for (int i = 0; i < EnemyNr; i++)
            {
                string name;
                Console.Write($"Insira nome de enimigo: #{i}");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name);

                if (random.NextDouble() < 0.5)
                {
                    enemies[i].PickupPowerUp(PowerUp.Shield, 50);
                }
                else
                {
                    enemies[i].TakeDamage(random.Next(100));
                }
            }


            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine(enemy.Getname());
            }

            Console.WriteLine($"{enemy.GetName()} HP= {enemy.GetHealth()} Shield= {enemy.GetShield()}");
        }
    }
}
