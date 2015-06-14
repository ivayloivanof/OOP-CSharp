namespace TheSlum.Items
{
    class Pill : Bonus
    {
        public Pill(string id, int healthEffect = 0, int deffenceEffect = 0, int attackEfffect = 100) 
            : base(id, healthEffect, deffenceEffect, attackEfffect)
        {
            this.Countdown = 1;
            this.Timeout = 1;
            this.HasTimedOut = false;
        }
    }
}
