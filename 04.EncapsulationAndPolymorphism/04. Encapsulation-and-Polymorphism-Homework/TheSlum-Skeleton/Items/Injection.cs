namespace TheSlum.Items
{
    class Injection : Bonus
    {
        public Injection(string id, int healthEffect = 200, int deffenceEffect = 0, int attackEfffect = 0) 
            : base(id, healthEffect, deffenceEffect, attackEfffect)
        {
            this.Countdown = 3;
            this.Timeout = 3;
            this.HasTimedOut = false;
        }
    }
}
