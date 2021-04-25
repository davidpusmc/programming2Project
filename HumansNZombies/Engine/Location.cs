using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Mission MissionAvailableHere { get; set; }
        public Zombie ZombieLivingHere { get; set; }

        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Mission missionAvailableHere = null, Zombie zombieLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            MissionAvailableHere = missionAvailableHere;
            ZombieLivingHere = zombieLivingHere;
        }
    }
}
