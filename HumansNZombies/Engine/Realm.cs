using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Realm
    {
        //static list variables to be referenced from the rest of the game
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Zombie> Zombies = new List<Zombie>();
        public static readonly List<Mission> Missions = new List<Mission>();
        public static readonly List<Location> Locations = new List<Location>();
        //constants to reference each item in game by specific id
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_WALKER_FINGER = 2;
        public const int ITEM_ID_ROTTING_SKIN = 3;
        public const int ITEM_ID_SCREAMER_TONSIL = 4;
        public const int ITEM_ID_SCREAMER_LUNG = 5;
        public const int ITEM_ID_PALADIN_LANCE = 6;
        public const int ITEM_ID_BITE_AWAY = 7;
        public const int ITEM_ID_SPITTER_VOMIT = 8;
        public const int ITEM_ID_SPITTER_STOMACH = 9;
        public const int ITEM_ID_SECRET_SAUCE = 10;

        public const int ZOMBIE_ID_WALKER = 1;
        public const int ZOMBIE_ID_SCREAMER = 2;
        public const int ZOMBIE_ID_SPITTER = 3;

        public const int MISSION_ID_CLEAR_BLUE_HOLE = 1;
        public const int MISSION_ID_CLEAR_NUNS_CATACOMBS = 2;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_WALKING_TRAILS = 2;
        public const int LOCATION_ID_CLOCK_TOWER = 3;
        public const int LOCATION_ID_NUNS_CATACOMBS = 4;
        public const int LOCATION_ID_ADMIN_CAGES = 5;
        public const int LOCATION_ID_AVOCA_VILLAGE = 6;
        public const int LOCATION_ID_SKYVIEW_REALM_OF_FIRE = 7;
        public const int LOCATION_ID_BONILLA_SCIENCE_PIT = 8;
        public const int LOCATION_ID_BLUE_HOLE = 9;
        //static constructor to populate every list when game starts.
        static Realm()
        {
            PopulateItems();
            PopulateZombies();
            PopulateMissions();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
            Items.Add(new Item(ITEM_ID_WALKER_FINGER, "Walker Finger", "Walker Fingers"));
            Items.Add(new Item(ITEM_ID_ROTTING_SKIN, "Rotting Skin", "Pieces of Rotting Flesh"));
            Items.Add(new Item(ITEM_ID_SCREAMER_TONSIL, "Screamer Tonsil", "Screamer Tonsils"));
            Items.Add(new Item(ITEM_ID_SCREAMER_LUNG, "Screamer Lung", "Screamer Lungs"));
            Items.Add(new Weapon(ITEM_ID_PALADIN_LANCE, "Paladin's Lance", "Palaidns' Lances", 5, 15));
            Items.Add(new BiteAway(ITEM_ID_BITE_AWAY, "Bite Away", "Bite Aways", 5));
            Items.Add(new Item(ITEM_ID_SPITTER_VOMIT, "Spitter Vomit", "Spitters' Vomits"));
            Items.Add(new Item(ITEM_ID_SPITTER_STOMACH, "Spitter Stomach", "Spitters' stomachs"));
            Items.Add(new Item(ITEM_ID_SECRET_SAUCE, "SECRET SAUCE ;)", "SECRET SAUCES ;)"));
        }

        private static void PopulateZombies()
        {
            Zombie walker = new Zombie(ZOMBIE_ID_WALKER, "Walker", 5, 3, 10, 3, 3);
            walker.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WALKER_FINGER), 75, false));
            walker.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROTTING_SKIN), 75, true));

            Zombie screamer = new Zombie(ZOMBIE_ID_SCREAMER, "Screamer", 5, 3, 10, 3, 3);
            screamer.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SCREAMER_TONSIL), 75, false));
            screamer.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SCREAMER_LUNG), 75, true));

            Zombie spitter = new Zombie(ZOMBIE_ID_SPITTER, "Spitter", 20, 5, 40, 10, 10);
            spitter.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPITTER_VOMIT), 75, true));
            spitter.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPITTER_STOMACH), 25, false));

            Zombies.Add(walker);
            Zombies.Add(screamer);
            Zombies.Add(spitter);
        }

        private static void PopulateMissions()
        {
            Mission clearBlueHole =
                new Mission(
                    MISSION_ID_CLEAR_BLUE_HOLE,
                    "Clear the Blue Hole",
                    "Exterminate the walkers contaminating the water from the Blue Hole and bring back 3 walker fingers. You will receive a healing potion and 10 gold pieces.", 20, 10);
            //utilizes parameters from Mission constructor id, name, description, rewardExp,and rewardGold

            clearBlueHole.MissionCompItems.Add(new MissionCompItem(ItemByID(ITEM_ID_WALKER_FINGER), 3));

            clearBlueHole.RewardItem = ItemByID(ITEM_ID_BITE_AWAY);
            clearBlueHole.RewardItem = ItemByID(ITEM_ID_PALADIN_LANCE);

            Mission clearNunsCatacombs =
                new Mission(
                    MISSION_ID_CLEAR_NUNS_CATACOMBS,
                    "Clear the Nuns' Catacombs",
                    "Kill the Screamers in the Nuns' Catacombs and bring back 3 screamers lungs. You will receive the secret sauce and 20 gold pieces.", 20, 20);

            clearNunsCatacombs.MissionCompItems.Add(new MissionCompItem(ItemByID(ITEM_ID_SCREAMER_LUNG), 3));

            clearNunsCatacombs.RewardItem = ItemByID(ITEM_ID_SECRET_SAUCE);

            Missions.Add(clearBlueHole);
            Missions.Add(clearNunsCatacombs);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place, what a terrible student.");

            Location clockTower = new Location(LOCATION_ID_CLOCK_TOWER, "Clock Tower", "You see a giant clock tower, with paths leading in 4 directions.");

            Location walkingTrails = new Location(LOCATION_ID_WALKING_TRAILS, "Walking Trails", "There are many strange plants along the walk ways, the pieces of the damned litter the floor. The air is thick with rot.");
            walkingTrails.MissionAvailableHere = MissionByID(MISSION_ID_CLEAR_BLUE_HOLE);

            Location blueHole = new Location(LOCATION_ID_BLUE_HOLE, "Blue Hole", "The communities clean drinking water flows into here for storage..");
            blueHole.ZombieLivingHere = ZombieByID(ZOMBIE_ID_WALKER);

            Location adminCages = new Location(LOCATION_ID_ADMIN_CAGES, "Admin Cages", "There is a Fortress of Stone walls filled bars, not a single window in sight. Rumors have been heard of a secret catacombs burried beneath it.");
            adminCages.MissionAvailableHere = MissionByID(MISSION_ID_CLEAR_NUNS_CATACOMBS);

            Location nunsCatacombs = new Location(LOCATION_ID_NUNS_CATACOMBS, "Nuns' Catacombs", "It's dark and cold in here. A heavy sense of blood lust seems encompass the area.");
            nunsCatacombs.ZombieLivingHere = ZombieByID(ZOMBIE_ID_SCREAMER);
            //LAST UPDATED HERE 4/26/2021 -- continue from here!!!!!---------------------------------------------

            Location avocaVillage = new Location(LOCATION_ID_AVOCA_VILLAGE, "Avoca Village", "The female villagers refuse to let you pass without revealing your secrets!", ItemByID(ITEM_ID_SECRET_SAUCE));

            Location bonillaSciencePit = new Location(LOCATION_ID_BONILLA_SCIENCE_PIT, "Bonilla Science Pit", "A fiery pit of rotting souls with a thin strip of land passing through called the 2.0 GPA, watch your step!");

            Location skyViewRealmOfFire = new Location(LOCATION_ID_SKYVIEW_REALM_OF_FIRE, "Skyview Realm of Fire", "The most demonic creatures dwell here, the worst creatures in history are born here.");
            skyViewRealmOfFire.ZombieLivingHere = ZombieByID(ZOMBIE_ID_SPITTER);

            // Link the locations together
            home.LocationToNorth = clockTower;

            clockTower.LocationToNorth = walkingTrails;
            clockTower.LocationToSouth = home;
            clockTower.LocationToEast = avocaVillage;
            clockTower.LocationToWest = adminCages;

            adminCages.LocationToEast = clockTower;
            adminCages.LocationToWest = nunsCatacombs;

            nunsCatacombs.LocationToEast = adminCages;

            walkingTrails.LocationToSouth = clockTower;
            walkingTrails.LocationToNorth = blueHole;

            blueHole.LocationToSouth = walkingTrails;

            avocaVillage.LocationToEast = bonillaSciencePit;
            avocaVillage.LocationToWest = clockTower;

            bonillaSciencePit.LocationToWest = avocaVillage;
            bonillaSciencePit.LocationToEast = skyViewRealmOfFire;

            skyViewRealmOfFire.LocationToWest = bonillaSciencePit;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(clockTower);
            Locations.Add(avocaVillage);
            Locations.Add(walkingTrails);
            Locations.Add(blueHole);
            Locations.Add(adminCages);
            Locations.Add(nunsCatacombs);
            Locations.Add(bonillaSciencePit);
            Locations.Add(skyViewRealmOfFire);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Zombie ZombieByID(int id)
        {
            foreach (Zombie zombie in Zombies)
            {
                if (zombie.ID == id)
                {
                    return zombie;
                }
            }

            return null;
        }

        public static Mission MissionByID(int id)
        {
            foreach (Mission quest in Missions)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
