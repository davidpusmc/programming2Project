using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : ProofOfLife //both Player and Zombie utilize max and current hitpoints so we created a different class for them to inherit from
    {
        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experience, int level) : base(currentHitPoints, maximumHitPoints)//child of ProofOfLife there for needs base constructor values to build constructor
        {
            Gold = gold;
            Experience = experience;
            Level = level;
        }
    }
}
