﻿namespace Battleships.Ships
{
    using System;

    public class Warship : Battleships
    {
        private string name;
        private double lengthInMeters;
        private double volume;

        public Warship(string name, double lengthInMeters, double volume)
        {
            this.Name = name;
            this.LengthInMeters = lengthInMeters;
            this.Volume = volume;
            this.IsBattleship = true;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }
        public double LengthInMeters
        {
            get
            {
                return this.lengthInMeters;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of a ship cannot be negative.");
                }

                this.lengthInMeters = value;
            }
        }
        public double Volume
        {
            get
            {
                return this.volume;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The volume of a ship cannot be negative.");
                }

                this.volume = value;
            }
        }

        public override string Attack(Ship target)
        {
            this.DestroyTarget(target);
            return "Victory is ours!";
        }

        protected override void DestroyTarget(Ship target)
        {

        }
    }
}
