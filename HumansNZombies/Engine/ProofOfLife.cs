using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class ProofOfLife
    {
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        public ProofOfLife(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
    }
}
