namespace MyGame
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
        public Enemy(string name, float health, float shield)
        {
            SetName(name);
            this.health = health;
            this.shield = shield;
        }

        public string Getname() => name;

        public float GetTotPower() => health + shield;

        public float GetHealth() => health;
        public float GetShield() => shield;

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageLeft = -shield;
                health -= damageLeft;
                if (health < 0) health = 0;
            }
        }
    }
}