using System;
using MassEffect.GameObjects.Locations;
using MassEffect.Engine;

namespace MassEffect.GameObjects.Ships
{
    class Cruiser : Starship
    {
        public Cruiser(string name, StarSystem location)
            : base(name, 100, 100, 50, 300, location)
        {
        }

        public override string ToString()
        {
            return string.Format(Messages.CreatedShip, StarshipType.Cruiser, this.Name);
        }
    }
}