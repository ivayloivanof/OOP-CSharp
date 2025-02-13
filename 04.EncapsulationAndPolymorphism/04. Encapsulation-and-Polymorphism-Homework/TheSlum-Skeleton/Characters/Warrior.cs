﻿using System.Collections.Generic;
using System.Linq;

namespace TheSlum.Characters
{
    using Interfaces;
    class Warrior : Character, IAttack
    {
        public Warrior(string id, int x, int y, int health, int defence, int attackPoints, Team team, int range) 
            : base(id, x, y, health, defence, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetList)
        {
            var target = targetList.FirstOrDefault(character => (character.Team != this.Team && character.IsAlive));
            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.AddToInventory(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.RemoveFromInventory(item);
            this.RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Attack: {0}", this.AttackPoints);
        }
    }
}
