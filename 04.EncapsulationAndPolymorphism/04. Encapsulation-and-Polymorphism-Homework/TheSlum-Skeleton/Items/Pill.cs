namespace TheSlum.Items
{
    class Pill : Bonus
    {
        protected Pill(string id, int healthEffect, int deffenceEffect, int attackEfffect) : base(id, healthEffect, deffenceEffect, attackEfffect)
        {
            this.Countdown = 1;
            this.Timeout = 1;
            this.HasTimedOut = false;

        }
    }
}
