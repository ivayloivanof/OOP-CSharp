using System;
using MassEffect.Engine;
using MassEffect.GameObjects.Locations;

namespace MassEffect.GameObjects.Ships
{
    class Dreadnought : Starship
    {
        public Dreadnought(string name, StarSystem location)
            : base(name, 200, 300, 150, 700, location)
        {

        }

        public override string ToString()
        {
            return string.Format(Messages.CreatedShip, StarshipType.Dreadnought, this.Name);
        }
    }
}