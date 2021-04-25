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
        public HumansNZombies()
        {
            InitializeComponent();


            _player = new Player(10,10,20,0,1); //creates obj _player constructor parameters to add values to properties

            lblHp.Text = _player.CurrentHitPoints.ToString(); //visual of hitpoints
            lblGldCount.Text = _player.Gold.ToString(); //visual of Gold amount
            lblExp.Text = _player.Experience.ToString(); //visual of amount of exp obtained
            lblLvl.Text = _player.Level.ToString(); //visual of current level
        }

    }
}
