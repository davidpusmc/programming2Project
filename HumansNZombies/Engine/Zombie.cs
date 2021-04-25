using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
   public class Zombie : ProofOfLife
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }

        public Zombie(int currentHitPoints, int maximumHitPoints, int id, string name, int maximumDamage, int rewardExperience, int rewardGold) : base(currentHitPoints, maximumHitPoints)//child of ProofOfLife and needs base constructor reference
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
        }
    }
}
