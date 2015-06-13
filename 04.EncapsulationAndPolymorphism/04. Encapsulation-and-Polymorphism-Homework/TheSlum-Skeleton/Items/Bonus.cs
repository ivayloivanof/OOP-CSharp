namespace TheSlum.Items
{
    using Interfaces;
    class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int deffenceEffect, int attackEfffect) : base(id, healthEffect, deffenceEffect, attackEfffect)
        {
        }

        public int Timeout{ get; set; }
        public int Countdown { get; set; }
        public bool HasTimedOut { get; set; }
    }
}
