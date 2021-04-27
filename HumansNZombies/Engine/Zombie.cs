using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Zombie : ProofOfLife
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public List <LootItem> LootTable { get; set; }

        public Zombie(int id, string name, int maximumDamage, int rewardExperience, int rewardGold, int currentHitPoints, int maximumHitPoints)
            : base(currentHitPoints, maximumHitPoints)//child of ProofOfLife and needs base constructor reference
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();//creates empty list for storing later
        }
    }
}
