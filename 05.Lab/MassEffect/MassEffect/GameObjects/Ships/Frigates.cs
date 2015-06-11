using System;
using MassEffect.Engine;
using MassEffect.GameObjects.Locations;

namespace MassEffect.GameObjects.Ships
{
    class Frigate : Starship
    {
        public Frigate(string name, StarSystem location)
            : base(name, 60, 50, 30, 220, location)
        {
        }

        public override string ToString()
        {
            return string.Format(Messages.CreatedShip, StarshipType.Frigate, this.Name);
        }
    }
}
