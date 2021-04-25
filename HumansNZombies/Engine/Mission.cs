using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Mission
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }

        public Mission(int id, string name, string description, int rewardExperience, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
        }
    }
}
