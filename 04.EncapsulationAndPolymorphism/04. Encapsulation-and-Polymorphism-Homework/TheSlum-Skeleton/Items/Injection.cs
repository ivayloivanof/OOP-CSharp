namespace TheSlum.Items
{
    class Injection : Bonus
    {
        public Injection(string id, int healthEffect, int deffenceEffect, int attackEfffect) 
            : base(id, healthEffect, deffenceEffect, attackEfffect)
        {
            this.Countdown = 3;
            this.Timeout = 3;
            this.HasTimedOut = false;
        }
    }
}
