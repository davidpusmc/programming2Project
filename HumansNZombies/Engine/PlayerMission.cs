using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerMission //current active mission
    {
        public Mission Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerMission(Mission details)// boolean determines if mission is completed or not. True will be stored upon completion
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
