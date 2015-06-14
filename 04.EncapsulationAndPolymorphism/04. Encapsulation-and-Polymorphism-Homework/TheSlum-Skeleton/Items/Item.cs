namespace TheSlum.Items
{
    class Item : GameObject
    {
        public Item(string id, int healthEffect, int deffenceEffect, int attackEfffect) : base (id)
        {
            this.AttackEffect = attackEfffect;
            this.DefenceEffect = deffenceEffect;
            this.HealthEffect = healthEffect;
        }

        public int AttackEffect { get; set; }
        public int DefenceEffect { get; set; }
        public int HealthEffect { get; set; }

    }
}
