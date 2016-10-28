using Labb_6___DungeonKryper.Classes.Environment;
using Labb_6___DungeonKryper.Classes.Objects;
using Labb_6___DungeonKryper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___DungeonKryper.Classes.Lists
{
    class MyLists
    {
        public List<INonPlayerCharacter> NonPlayerCharacters { get; set; }
        List<IEnvironment> environment;
        public List<IEnvironment> Environment
        {
            get
            {
                if (environment == null) environment = new List<IEnvironment>();
                return environment;
            }
        }

        public MyLists()
        {

            Environment.Add(new Yard
            {
                Description = "a dark forest.",
                LongDescription = "There really is nothing to see. You see a path going north.",
                Exits = "North",
                EnvironmentLocationX = 0,
                EnvironmentLocationY = 0,
                RoomNumber = 1000,
                ExitNorth = 1001,
                ExitEast = 0,
                ExitSouth = 0,
                ExitWest = 0,
                Contains = 1000,

            });
            Environment[0].RoomContent.Add(new Animal
            {
                Name = "dog",
                Description = "A tiny dog",
                Speak = "Woof",
                Type = "Dog",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1000,
                Health = 5,
                Level = 1

            });

            Environment.Add(new Yard
            {
                Description = "a dark forest.",
                LongDescription = "You can see a small cabin to the west and nothing but dark forest to the north.",
                Exits = "North, South, West",
                EnvironmentLocationX = 1,
                EnvironmentLocationY = 0,
                RoomNumber = 1001,
                ExitSouth = 1000,
                ExitNorth = 1003,
                ExitWest = 1002,
                ExitEast = 0,
                Contains = 0
            });

            Environment.Add(new Room
            {
                Description = "a light cabin.",
                LongDescription = "This small cabin have seen better days. The only exit is the door you came in through.",
                Exits = "East",
                EnvironmentLocationX = 1,
                EnvironmentLocationY = -1,
                RoomNumber = 1002,
                ExitEast = 1001,
                ExitSouth = 0,
                ExitWest = 0,
                ExitNorth = 0,
                Contains = 1001
            });
            Environment[2].RoomContent.Add(new Human
            {
                Name = "regular man",
                Description = "A tall man",
                Speak = "Come here for a while, and listen.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1001,
                Health = 8,
                Level = 1,

            });

            Environment.Add(new Yard
            {
                Description = "a dimly lit yard.",
                LongDescription = "The forest clears and you can see some cut grass. To the north it looks more well maintained and to the south there is nothing but forests.",
                Exits = "North, South",
                EnvironmentLocationX = 2,
                EnvironmentLocationY = 0,
                RoomNumber = 1003,
                ExitSouth = 1001,
                ExitNorth = 1004,
                ExitWest = 1002,
                ExitEast = 0,
                Contains = 0
            });
            Environment.Add(new Yard
            {
                Description = "a bright yard.",
                LongDescription = "The grass is well cut and you can see a freshly renovated pathway leading north. To the south it looks darker.",
                Exits = "North, South",
                EnvironmentLocationX = 3,
                EnvironmentLocationY = 0,
                RoomNumber = 1004,
                ExitSouth = 1003,
                ExitNorth = 1005,
                ExitEast = 0,
                ExitWest = 0,
                Contains = 1001
            });
            Environment[4].RoomContent.Add(new Human
            {
                Name = "regular man",
                Description = "A tall man",
                Speak = "Come here for a while, and listen.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1001,
                Health = 3,
                Level = 1
            });
            Environment.Add(new Yard
            {
                Description = "a palace entrance.",
                LongDescription = "A big marble building stands before you to the north. To the south you can see the yard.",
                Exits = "North, South",
                EnvironmentLocationX = 4,
                EnvironmentLocationY = 0,
                RoomNumber = 1005,
                ExitSouth = 1004,
                ExitNorth = 1006,
                ExitEast = 0,
                ExitWest = 0,
                Contains = 1002
            });
            Environment[5].RoomContent.Add(new Animal
            {
                Name = "rat",
                Description = "A small rat",
                Speak = "The rat covers in fear.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1002,
                Health = 2,
                Level = 1
            });
            Environment[5].RoomContent.Add(new Animal
            {
                Name = "rat",
                Description = "A small rat",
                Speak = "The rat covers in fear.",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1002,
                Health = 3,
                Level = 1
            });
            Environment.Add(new Room
            {
                Description = "a palace hallway.",
                LongDescription = "The walls are plastered with beautiful paintings, the floor is reflective and the roof looks entirely new. The building draws you in further north, but you can exit in all directions.",
                Exits = "North, South, East, West",
                EnvironmentLocationX = 5,
                EnvironmentLocationY = 0,
                RoomNumber = 1006,
                ExitSouth = 1005,
                ExitNorth = 1007,
                ExitEast = 1008,
                ExitWest = 1009,
                Contains = 0
            });
            Environment.Add(new Room
            {
                Description = "a throne room.",
                LongDescription = "The most gold filled room you have ever seen. In the middle there is a man looking fierce. You may exit to the south.",
                Exits = "South",
                EnvironmentLocationX = 6,
                EnvironmentLocationY = 0,
                RoomNumber = 1007,
                ExitSouth = 1006,
                ExitNorth = 0,
                ExitEast = 0,
                ExitWest = 0,
                Contains = 1003
            });
            Environment[7].RoomContent.Add(new Questor
            {
                Name = "questor",
                Description = "A influental man giving out quests. Listen to him.",
                Speak = "I have a possible quest for you. Type Quest accept to start your quest",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1004,
                Health = 99999,
                Level = 201,

            });

            Environment.Add(new Room
            {
                Description = "a palace room.",
                LongDescription = "Another big room.",
                Exits = "West",
                EnvironmentLocationX = 5,
                EnvironmentLocationY = 1,
                RoomNumber = 1008,
                ExitSouth = 0,
                ExitNorth = 0,
                ExitEast = 0,
                ExitWest = 1006,
                Contains = 0
            });
            Environment.Add(new Room
            {
                Description = "a palace room.",
                LongDescription = "Another big room.",
                Exits = "East",
                EnvironmentLocationX = 5,
                EnvironmentLocationY = -1,
                RoomNumber = 1009,
                ExitSouth = 0,
                ExitNorth = 0,
                ExitEast = 1006,
                ExitWest = 0,
                Contains = 0
            });

            // -------------------------------------
            // Slut på rum
            // -------------------------------------

        }
    }
}
