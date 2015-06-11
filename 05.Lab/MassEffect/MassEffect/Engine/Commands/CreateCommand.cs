using System;
using System.Linq;
using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;
    using MassEffect.GameObjects.Ships;
    using MassEffect.GameObjects.Locations;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string typeShip = commandArgs[1];
            string name = commandArgs[2];
            string space = commandArgs[3];
            string enhancment = commandArgs[4];
            
            StarshipType type = (StarshipType) Enum.Parse(typeof (StarshipType), typeShip);
            StarSystem location = this.GameEngine.Galaxy.GetStarSystemByName(space);

            if (this.GameEngine.Starships.Any(ship => ship.Name == name))
            {
                throw new ShipAwaysIsCreated(Messages.DuplicateShipName);
            }

            this.GameEngine.Starships.Add(this.GameEngine.ShipFactory.CreateShip(type, name, location));
            //IStarship.AddEnhancement();
        }
    }
}
