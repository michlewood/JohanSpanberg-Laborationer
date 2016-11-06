using Labb_6___DungeonKryper.Classes.Environment;
using Labb_6___DungeonKryper.Classes.Objects;
using Labb_6___DungeonKryper.Classes.Objects.Armor;
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
        List<IEquipment> items;
        public List<IEquipment> Items
        {
            get
            {
                if (items == null) items = new List<IEquipment>();
                return items;
            }
        }

        List<IItems> itemsList;
        public List<IItems> ItemsList
        {
            get
            {
                if (itemsList == null) itemsList = new List<IItems>();
                return itemsList;
            }
        }

        List<ArmorItem> armorItem;
        public List<ArmorItem> ArmorItem
        {
            get
            {
                if (armorItem == null) armorItem = new List<ArmorItem>();
                return armorItem;
            }
        }

        List<ArmorSlot> armorSlot;
        public List<ArmorSlot> ArmorSlot
        {
            get
            {
                if (armorSlot == null) armorSlot = new List<ArmorSlot>();
                return armorSlot;
            }
        }

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
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Head",
                Position = 0
            }
            );

            ArmorSlot[0].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 0
            });
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Neck",
                Position = 1
            }
);
            ArmorSlot[1].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 1
            });
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Shoulders",
                Position = 2
            }
);
            ArmorSlot[2].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 2
            });
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Torso",
                Position = 3
            }
);
            ArmorSlot[3].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 3
            });
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Arms",
                Position = 4
            }
);
            ArmorSlot[4].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 4
            });
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Hands",
                Position = 5
            }
);
            ArmorSlot[5].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 5
            });
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Legs",
                Position = 6
            }
);
            ArmorSlot[6].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 6
            });
            ArmorSlot.Add(new ArmorSlot
            {
                ArmorPosition = "Feet",
                Position = 7
            }
);
            ArmorSlot[7].ArmorSlotContains.Add(new ArmorItem
            {
                ArmorName = "Empty",
                ArmorStrength = 0,
                ArmorWeight = 0,
                ArmorWorth = 0,
                Position = 7
            });


            Environment.Add(new Yard
            {
                Description = "a dark forest.",
                LongDescription = "You see a path. Its twisted and barely lit trail leads past rocks and fallen timber. You can feel all kinds of unknown animals and trolls watch you. Nobody has maintained this path in years.",
                EnvironmentLocationX = 0,
                EnvironmentLocationY = 0,
                RoomNumber = 1000,
                ExitNorth = 1001,
                ExitEast = 1010,
                ExitSouth = 0,
                ExitWest = 0,
                Contains = 1000,

            });
            Environment[0].RoomContent.Add(new Animal
            {
                Name = "nor'Grah",
                Description = "nor'Grah",
                LongDescription = "This clever and uncommon creature is a type of reptile. It's about the size of a crocodile, has no legs or arms, like a snake and a short, strong tail. They have a soft, but strong skin covered in small, coarse scales, which is usually either grey, blue or brown or a combination of these colors.",
                Speak = "Gnarl",
                Type = "norGrah",
                ObjectLocationX = 0,
                ObjectLocationY = 0,
                ObjectNumber = 1000,
                Health = 50,
                Level = 11,
                Strength = 20
            });
            Environment.Add(new Yard
            {
                Description = "a dark forest path.",
                LongDescription = "You see a path. Its twisted and barely lit trail leads past rocks and fallen timber. You can feel all kinds of unknown animals and trolls watch you. Nobody has maintained this path in years.",
                EnvironmentLocationX = 0,
                EnvironmentLocationY = 1,
                RoomNumber = 1010,
                ExitNorth = 0,
                ExitEast = 0,
                ExitSouth = 1011,
                ExitWest = 1000,
                Contains = 0,

            });
            Environment.Add(new Yard
            {
                Description = "a dark small village.",
                LongDescription = "A small abandoned village with huts to the east and west stands before you. You can't help wondering what happened to this place.",
                EnvironmentLocationX = -1,
                EnvironmentLocationY = 1,
                RoomNumber = 1011,
                ExitNorth = 1010,
                ExitEast = 1012,
                ExitSouth = 0,
                ExitWest = 1013,
                Contains = 0,

            });
            Environment.Add(new Yard
            {
                Description = "a dark small village hut.",
                LongDescription = "This hut is barely standing and the smell of rot stenches your nose.",
                EnvironmentLocationX = -1,
                EnvironmentLocationY = 2,
                RoomNumber = 1012,
                ExitNorth = 0,
                ExitEast = 0,
                ExitSouth = 0,
                ExitWest = 1011,
                Contains = 0,

            });
            Environment.Add(new Yard
            {
                Description = "a dark small village hut.",
                LongDescription = "The kitchen fire has not been used in ages. It feels desolate and abandoned.",
                EnvironmentLocationX = -1,
                EnvironmentLocationY = 0,
                RoomNumber = 1013,
                ExitNorth = 0,
                ExitEast = 1011,
                ExitSouth = 0,
                ExitWest = 0,
                Contains = 0,

            });
            Environment.Add(new Yard
            {
                Description = "a dark forest.",
                LongDescription = "You can see a small cabin to the west and nothing but dark forest to the north.",
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
                LongDescription = "The house is equipped with an old-fashioned kitchen and two bathrooms, it also has a warm living room, four bedrooms, a small dining room, a sun room and a spacious storage room. The building is square shaped.The house is fully surrounded by cloth sunscreens.",
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
                Name = "Alduin Nightgaze",
                Description = "Alduin Nightgaze",
                LongDescription = "Silver, wavy hair almost fully covers a lean, anguished face. Beady red eyes, set high within their sockets, watch lovingly over the sea they've bled for for so long. Soft skin elegantly compliments his hair and leaves a bittersweet memory of his fortunate adventures. The is the face of Alduin Nightgaze, a true winner among high elves. He stands tiny among others, despite his scraggy frame. There's something enthralling about him, perhaps it's his perseverance or perhaps it's simply his fortunate past. But nonetheless, people tend to flock towards him, while secretly training to become more like him.",
                Speak = "Come here for a while, and listen.",
                ObjectLocationX = 1,
                ObjectLocationY = -1,
                ObjectNumber = 1001,
                Health = 500,
                Level = 500,
                Strength = 500

            });

            Environment.Add(new Yard
            {
                Description = "a dimly lit yard.",
                LongDescription = "The forest clears and you can see some cut grass. To the north it looks more well maintained and to the south there is nothing but forests.",
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
                Description = "Alre Wildoak",
                LongDescription = "Pink, sleek hair neatly coiffured to reveal a bony, warm face. Small green eyes, set lightly within their sockets, watch thoughtfully over the mountains they've cared for for so long. A beard handsomely compliments his nose and mouth and leaves a pleasant memory of his upbringing. The is the face of Alre Wildoak, a true romanticist among wood elves. He stands short among others, despite his skinny frame. There's something obscure about him, perhaps it's his unfortunate past or perhaps it's simply a feeling of sadness. But nonetheless, people tend to lie about knowing him to brag, while secretly admiring him.",
                Speak = "Come here for a while, and listen.",
                ObjectLocationX = 3,
                ObjectLocationY = 0,
                ObjectNumber = 1001,
                Health = 55,
                Level = 5,
                Strength = 3
            });
            Environment.Add(new Yard
            {
                Description = "a palace entrance.",
                LongDescription = "A big marble building stands before you to the north. To the south you can see the yard.",
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
                LongDescription = "Not much to say about this furry animal",
                Speak = "The rat covers in fear.",
                ObjectLocationX = 4,
                ObjectLocationY = 0,
                ObjectNumber = 1002,
                Health = 31,
                Level = 3,
                Strength = 1
            });
            Environment[5].RoomContent.Add(new Animal
            {
                Name = "rat",
                Description = "A small rat",
                LongDescription = "This rat carries worms",
                Speak = "The rat covers in fear.",
                ObjectLocationX = 4,
                ObjectLocationY = 0,
                ObjectNumber = 1002,
                Health = 46,
                Level = 4,
                Strength = 1
            });
            Environment.Add(new Room
            {
                Description = "a palace hallway.",
                LongDescription = "The walls are plastered with beautiful paintings, the floor is reflective and the roof looks entirely new. The building draws you in further north, but you can exit in all directions.",
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
                Name = "Addison Lockwood",
                Description = "Addison Lockwood",
                LongDescription = "Gray, long hair is pulled back to reveal a bony, time-worn face. Narrow gray eyes, set seductively within their sockets, watch watchfully over the town they've defended for so long. Fair skin beautifully compliments his cheekbones and leaves a heartbreaking memory of his fortunate looks. The is the face of Addison Lockwood, a true warrior among giants. He stands seductively among others, despite his thin frame. There's something mystifying about him, perhaps it's his odd friends or perhaps it's simply his reputation. But nonetheless, people tend to shower him with gifts, while trying to avoid him.",
                Speak = "I have a possible quest for you. Type Quest accept to start your quest",
                ObjectLocationX = 6,
                ObjectLocationY = 0,
                ObjectNumber = 1004,
                Health = 99999,
                Level = 500,
                Strength = 500

            });

            Environment.Add(new Room
            {
                Description = "a palace room.",
                LongDescription = "Another big room.",
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
