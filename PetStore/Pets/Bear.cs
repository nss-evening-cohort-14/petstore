using System;

namespace PetStore.Pets
{
    class Bear
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public int NumberOfFishEaten { get; private set; }

        //property with a default value
        public string EducationLevel { get; set; } = "GED";
        public Tiger BestTigerFriend { get; set; }

        //read only property
        //public bool LovesHoney { get; }

        //expression-bodied readonly property
        public bool LovesHoney => Name == "Winnie the Pooh";

        public Bear(string name, string type)
        {
            Name = name;
            Type = type;
            EducationLevel = "GED";

           if (name == "Yogi")
            {
                EducationLevel = "Above Average";
            }
        }


        //expression bodied method
        public Bear(string name, string type, string educationLevel) : this(name,type) => EducationLevel = educationLevel;
        //{
        //    EducationLevel = educationLevel;
        //}

        public Bear(string name, string type, string educationLevel, int howManyFish) : this(name,type,educationLevel)
        {
            NumberOfFishEaten = howManyFish;
        }

        public void EatFish(int howMany)
        {
            if (howMany <= 0) return;

            NumberOfFishEaten += howMany;
        }

        public void HangOutWithBestFriend()
        {
            var output = $"{Name} the bear is hanging out with " +
                $"its best tiger friend, {BestTigerFriend.Name} " +
                $"the {BestTigerFriend.Size} sized tiger";

            Console.WriteLine(output);
        }

    }
}
