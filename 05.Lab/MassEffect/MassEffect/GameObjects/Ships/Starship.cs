using System;
using System.Collections.Generic;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.Engine;

namespace MassEffect.GameObjects.Ships
{
    using Interfaces;
    class Starship : IStarship
    {
        private string name;
        private int health;
        private int shield;
        private int damage;
        private double fuel;
        private StarSystem location;

        public Starship(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
        }

        public IEnumerable<Enhancement> Enhancements
        {
            get { throw new NotImplementedException(); }
        }
        public void AddEnhancement(Enhancement enhancement)
        {
            throw new NotImplementedException();
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value.Trim(); }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public int Shields
        {
            get { return this.shield; }
            set { this.shield = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }
        public double Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }
        public StarSystem Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public IProjectile ProduceAttack()
        {
            throw new NotImplementedException();
        }

        public void RespondToAttack(IProjectile attack)
        {
            throw new NotImplementedException();
        }
    }
}
