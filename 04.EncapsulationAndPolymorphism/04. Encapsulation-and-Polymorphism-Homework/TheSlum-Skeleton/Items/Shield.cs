namespace TheSlum.Items
{
    class Shield : Bonus
    {
        public Shield(string id, int healthEffect = 0, int deffenceEffect = 50, int attackEfffect = 0) 
            : base(id, healthEffect, deffenceEffect, attackEfffect)
        {
        }
    }
}
