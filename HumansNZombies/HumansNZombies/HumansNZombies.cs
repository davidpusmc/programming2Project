using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace HumansNZombies
{
    public partial class HumansNZombies : Form
    {
        private Player _player;
        private Zombie _currentZombie;//holds the zombie player is fighting at a anygiven location
        public HumansNZombies()
        {
            InitializeComponent();


            _player = new Player(10, 10, 20, 0, 1); //creates obj _player constructor parameters to add values to properties
            MoveTo(Realm.LocationByID(Realm.LOCATION_ID_HOME));
            _player.Inventory.Add(new InventoryItem(Realm.ItemByID(Realm.ITEM_ID_RUSTY_SWORD), 1));

            lblHp.Text = _player.CurrentHitPoints.ToString(); //visual of hitpoints
            lblGldCount.Text = _player.Gold.ToString(); //visual of Gold amount
            lblExp.Text = _player.Experience.ToString(); //visual of amount of exp obtained
            lblLvl.Text = _player.Level.ToString(); //visual of current level
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void MoveTo(Location newLocation)
        {

            //Does the location have any required items
            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                rtBoxMessages.Text += "You must have the " + newLocation.ItemRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                return;
            }

            _player.CurrentLocation = newLocation;

            // Show/hide available movement buttons
            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);
            btnWest.Visible = (newLocation.LocationToWest != null);

            // Display current location name and description
            rtBoxLocation.Text = newLocation.Name + Environment.NewLine;
            rtBoxLocation.Text += newLocation.Description + Environment.NewLine;

            // Completely heal the player each move
            _player.CurrentHitPoints = _player.MaximumHitPoints;

            // Update Hit Points in UI
            lblHp.Text = _player.CurrentHitPoints.ToString();

            //checks to see if mission is available for current location
            if (newLocation.MissionAvailableHere != null)
            {
                // See if the player already has the mission, and if they've completed it. Intial value false
                bool playerAlreadyHasMission = _player.HasThisMission(newLocation.MissionAvailableHere);
                bool playerAlreadyCompletedMission = _player.CompletedThisMission(newLocation.MissionAvailableHere);

                //initial is set to true before check at each location with mission
                if (playerAlreadyHasMission)
                {
                    if (!playerAlreadyCompletedMission)
                    {

                        bool playerHasAllItemsToCompleteMission = _player.HasAllMissionCompItems(newLocation.MissionAvailableHere);



                        if (playerHasAllItemsToCompleteMission)
                        {

                            rtBoxMessages.Text += Environment.NewLine;
                            rtBoxMessages.Text += "You've completed the '" + newLocation.MissionAvailableHere.Name + "'mission." + Environment.NewLine;

                            //if item is not in inventory
                            _player.RemoveMissionCompItems(newLocation.MissionAvailableHere);

                            //give rewards
                            rtBoxMessages.Text += "You receive: " + Environment.NewLine;
                            rtBoxMessages.Text += newLocation.MissionAvailableHere.RewardExperience.ToString() + " experience." + Environment.NewLine;
                            rtBoxMessages.Text += newLocation.MissionAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            rtBoxMessages.Text += newLocation.MissionAvailableHere.RewardItem.Name + Environment.NewLine;
                            rtBoxMessages.Text += Environment.NewLine;

                            _player.Experience += newLocation.MissionAvailableHere.RewardExperience;
                            _player.Gold += newLocation.MissionAvailableHere.RewardGold;

                            //add to reward item to inventory
                            _player.AddItemToInventory(newLocation.MissionAvailableHere.RewardItem);

                            //mark mission completed
                            _player.MarkMissionCompleted(newLocation.MissionAvailableHere);
                        }
                    }
                }
                else
                {
                    // The player does not already have the quest

                    // Display the messages
                    rtBoxMessages.Text += "You receive the mission '" + newLocation.MissionAvailableHere.Name + "'." + Environment.NewLine;
                    rtBoxMessages.Text += newLocation.MissionAvailableHere.Description + Environment.NewLine;
                    rtBoxMessages.Text += "To complete it, return with:" + Environment.NewLine;
                    foreach (MissionCompItem qci in newLocation.MissionAvailableHere.MissionCompItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtBoxMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtBoxMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rtBoxMessages.Text += Environment.NewLine;

                    // Add the quest to the player's quest list
                    _player.Missions.Add(new PlayerMission(newLocation.MissionAvailableHere));
                }
            }
            // Does the location have a Zombie?
            if (newLocation.ZombieLivingHere != null)
            {
                rtBoxMessages.Text += "You see a " + newLocation.ZombieLivingHere.Name + Environment.NewLine;

                // Make a new Zombie, using the values from the standard zombie in the Zombie.Zombie list
                Zombie standardZombie = Realm.ZombieByID(newLocation.ZombieLivingHere.ID);

                _currentZombie = new Zombie(standardZombie.ID, standardZombie.Name, standardZombie.MaximumDamage,
                    standardZombie.RewardExperience, standardZombie.RewardGold, standardZombie.CurrentHitPoints, standardZombie.MaximumHitPoints);

                foreach (LootItem lootItem in standardZombie.LootTable)
                {
                    _currentZombie.LootTable.Add(lootItem);
                }

                cbBoxWeapons.Visible = true;
                cbBoxBiteAway.Visible = true;
                btnUseWeapon.Visible = true;
                btnUseBiteAway.Visible = true;
            }
            else
            {
                _currentZombie = null;

                cbBoxWeapons.Visible = false;
                cbBoxBiteAway.Visible = false;
                btnUseWeapon.Visible = false;
                btnUseBiteAway.Visible = false;
            }
            //Update Inventory list on move
            UpdateInventoryListInUI();
            //update Mission list on move
            UpdateMissionListInUI();
            //update Weapon List on move
            UpdateWeaponListInUI();
            //updateBiteAway list on move
            UpdateBiteAwayListInUI();
        }

        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Name";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";

            dgvInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }

            private void UpdateMissionListInUI()
            {
                dgvMissions.RowHeadersVisible = false;

                dgvMissions.ColumnCount = 2;
                dgvMissions.Columns[0].Name = "Name";
                dgvMissions.Columns[0].Width = 197;
                dgvMissions.Columns[1].Name = "Done?";

                dgvMissions.Rows.Clear();

                foreach (PlayerMission playerMission in _player.Missions)
                {
                    dgvMissions.Rows.Add(new[] { playerMission.Details.Name, playerMission.IsCompleted.ToString() });
                }
            }
        

        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "attack" button
                cbBoxWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cbBoxWeapons.DataSource = weapons;
                cbBoxWeapons.DisplayMember = "Name";
                cbBoxWeapons.ValueMember = "ID";

                cbBoxWeapons.SelectedIndex = 0;
            }
        }

        private void UpdateBiteAwayListInUI()
        {
            List<BiteAway> biteAway = new List<BiteAway>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is BiteAway)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        biteAway.Add((BiteAway)inventoryItem.Details);
                    }
                }
            }


            if (biteAway.Count == 0)
            {
                // The player doesn't have any biteaway, so hide the biteaway combobox and "cure" button
                cbBoxBiteAway.Visible = false;
                btnUseBiteAway.Visible = false;
            }
            else
            {
                cbBoxBiteAway.DataSource = biteAway;
                cbBoxBiteAway.DisplayMember = "Name";
                cbBoxBiteAway.ValueMember = "ID";

                cbBoxBiteAway.SelectedIndex = 0;
            }
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            // Get the currently selected weapon from the cboWeapons ComboBox
            Weapon currentWeapon = (Weapon)cbBoxWeapons.SelectedItem;

            // Determine the amount of damage to do to the Zombie
            int damageToZombie = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            // Apply the damage to the Zombies CurrentHitPoints
            _currentZombie.CurrentHitPoints -= damageToZombie;

            // Display message
            rtBoxMessages.Text += "You hit the " + _currentZombie.Name + " for " + damageToZombie.ToString() + " points." + Environment.NewLine;

            // Check if the Zombie is dead
            if (_currentZombie.CurrentHitPoints <= 0)
            {
                // Zombie is dead
                rtBoxMessages.Text += Environment.NewLine;
                rtBoxMessages.Text += "You defeated the " + _currentZombie.Name + Environment.NewLine;

                // Give player experience points for killing the zombie
                _player.Experience += _currentZombie.RewardExperience;
                rtBoxMessages.Text += "You receive " + _currentZombie.RewardExperience.ToString() + " experience" + Environment.NewLine;

                // Give player gold for killing the zombie 
                _player.Gold += _currentZombie.RewardGold;
                rtBoxMessages.Text += "You receive " + _currentZombie.RewardGold.ToString() + " gold" + Environment.NewLine;

                // Get random loot items from the Zombie
                List<InventoryItem> lootedItems = new List<InventoryItem>();

                // Add items to the lootedItems list, comparing a random number to the drop percentage
                foreach (LootItem lootItem in _currentZombie.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercent)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                // If no items were randomly selected, then add the default loot item(s).
                if (lootedItems.Count == 0)
                {
                    foreach (LootItem lootItem in _currentZombie.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                // Add the looted items to the player's inventory
                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtBoxMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtBoxMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                    }
                }

                // Refresh player information and inventory controls
                lblHp.Text = _player.CurrentHitPoints.ToString();
                lblGldCount.Text = _player.Gold.ToString();
                lblExp.Text = _player.Experience.ToString();
                lblLvl.Text = _player.Level.ToString();

                UpdateInventoryListInUI();
                UpdateWeaponListInUI();
                UpdateBiteAwayListInUI();

                // Add a blank line to the messages box, just for appearance.
                rtBoxMessages.Text += Environment.NewLine;

                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(_player.CurrentLocation);
            }
            else
            {
                // Zombie is still alive

                // Determine the amount of damage the monster does to the player
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentZombie.MaximumDamage);

                // Display message
                rtBoxMessages.Text += "The " + _currentZombie.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

                // Subtract damage from player
                _player.CurrentHitPoints -= damageToPlayer;

                // Refresh player data in UI
                lblHp.Text = _player.CurrentHitPoints.ToString();

                if (_player.CurrentHitPoints <= 0)
                {
                    // Display message
                    rtBoxMessages.Text += "The " + _currentZombie.Name + " killed you." + Environment.NewLine;

                    // Move player to "Home"
                    MoveTo(Realm.LocationByID(Realm.LOCATION_ID_HOME));
                }
            }
        }

        private void btnUseBiteAway_Click(object sender, EventArgs e)
        {
            // Get the currently selected bite away from the combobox
            BiteAway cure = (BiteAway)cbBoxBiteAway.SelectedItem;

            // Add healing amount to the player's current hit points
            _player.CurrentHitPoints = (_player.CurrentHitPoints + cure.AmountToHeal);

            // CurrentHitPoints cannot exceed player's MaximumHitPoints
            if (_player.CurrentHitPoints > _player.MaximumHitPoints)
            {
                _player.CurrentHitPoints = _player.MaximumHitPoints;
            }

            // Remove the bite away from the player's inventory
            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Details.ID == cure.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            // Display message
            rtBoxMessages.Text += "You drink a " + cure.Name + Environment.NewLine;

            // Monster gets their turn to attack

            // Determine the amount of damage the zombie does to the player
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentZombie.MaximumDamage);

            // Display message
            rtBoxMessages.Text += "The " + _currentZombie.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

            // Subtract damage from player
            _player.CurrentHitPoints -= damageToPlayer;

            if (_player.CurrentHitPoints <= 0)
            {
                // Display message
                rtBoxMessages.Text += "The " + _currentZombie.Name + " killed you." + Environment.NewLine;

                // Move player to "Home"
                MoveTo(Realm.LocationByID(Realm.LOCATION_ID_HOME));
            }

            // Refresh player data in UI
            lblHp.Text = _player.CurrentHitPoints.ToString();
            UpdateInventoryListInUI();
            UpdateBiteAwayListInUI();
        }
    }
}
