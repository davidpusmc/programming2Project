using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : ProofOfLife //both Player and Zombie utilize max and current hitpoints so we created a different class for them to inherit from
    {
        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public Location CurrentLocation { get; set; }
        public List <InventoryItem> Inventory { get; set; }
        public List<PlayerMission> Missions { get; set; }
        

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experience, int level)
            : base(currentHitPoints, maximumHitPoints)//child of ProofOfLife there for needs base constructor values to build constructor
        {
            Gold = gold;
            Experience = experience;
            Level = level;

            Inventory = new List<InventoryItem>(); //makes list empty so things can be added later
            Missions = new List<PlayerMission>(); //makes list empty so missions can be added later
        }
        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location.ItemRequiredToEnter == null)
            {
                // There isn't a required item for this location
                return true;
            }

            //check inventory for required item
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    // found item return true
                    return true;
                }
            }

            // didn't find item so false
            return false;
        }

        public bool HasThisMission(Mission mission)
        {
            foreach (PlayerMission playerMission in Missions)
            {
                if (playerMission.Details.ID == mission.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CompletedThisMission(Mission mission)
        {
            foreach (PlayerMission playerMission in Missions)
            {
                if (playerMission.Details.ID == mission.ID)
                {
                    return playerMission.IsCompleted;
                }
            }

            return false;
        }

        public bool HasAllMissionCompItems(Mission mission)
        {
            // See if the player has all the items needed to complete the quest here
            foreach (MissionCompItem qci in mission.MissionCompItems)
            {
                bool foundItemInPlayersInventory = false;

                // Check each item in the player's inventory, to see if they have it, and enough of it
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID) // The player has the item in their inventory
                    {
                        foundItemInPlayersInventory = true;

                        if (ii.Quantity < qci.Quantity) // The player does not have enough of this item to complete the quest
                        {
                            return false;
                        }
                    }
                }

                // The player does not have any of this quest completion item in their inventory
                if (!foundItemInPlayersInventory)
                {
                    return false;
                }
            }

            // If we got here, then the player must have all the required items, and enough of them, to complete the quest.
            return true;
        }

        public void RemoveMissionCompItems(Mission mission)
        {
            foreach (MissionCompItem mci in mission.MissionCompItems)
            {
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == mci.Details.ID)
                    {
                        // Subtract the quantity from the player's inventory that was needed to complete the quest
                        ii.Quantity -= mci.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Item itemToAdd)
        {
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == itemToAdd.ID)
                {
                    // They have the item in their inventory, so increase the quantity by one
                    ii.Quantity++;

                    return; // We added the item, and are done, so get out of this function
                }
            }

            // They didn't have the item, so add it to their inventory, with a quantity of 1
            Inventory.Add(new InventoryItem(itemToAdd, 1));
        }

        public void MarkMissionCompleted(Mission mission)
        {
            // Find the quest in the player's quest list
            foreach (PlayerMission pm in Missions)
            {
                if (pm.Details.ID == mission.ID)
                {
                    // Mark it as completed
                    pm.IsCompleted = true;

                    return; // We found the quest, and marked it complete, so get out of this function
                }
            }
        }
    }
}
