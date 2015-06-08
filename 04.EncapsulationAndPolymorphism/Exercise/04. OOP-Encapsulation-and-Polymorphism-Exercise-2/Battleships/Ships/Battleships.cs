namespace Battleships.Ships
{
    using Interfaces;

    public abstract class Battleships : Ship, IAttack
    {
        public abstract string Attack(Ship target);
        protected abstract void DestroyTarget(Ship target);
    }   
}
