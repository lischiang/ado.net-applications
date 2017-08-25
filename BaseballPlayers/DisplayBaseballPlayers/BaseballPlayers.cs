using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BaseballClassLibrary;
using System.Data.Entity.Validation;

namespace DisplayBaseballPlayers
{
    public partial class BaseballPlayers : Form
    {
        public BaseballPlayers()
        {
            InitializeComponent();
        }

        private BaseballEntities dbcontext = new BaseballEntities();

        private void BaseballPlayers_Load(object sender, EventArgs e)
        {
            // select all the players
            dbcontext.Players
                .OrderBy(OnePlayer => OnePlayer.PlayerID)
                .Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchedLastName = txtLastName.Text; // the input value from the user

            // select the player(s) that have the last name equal to the input value
            playerBindingSource.DataSource = dbcontext.Players.Local
                .Where(OnePlayer => OnePlayer.LastName.Equals(searchedLastName))
                .OrderBy(OnePlayer => OnePlayer.PlayerID);

            playerBindingSource.MoveFirst(); // move to the first entry
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // select all the players
            dbcontext.Players
                .OrderBy(OnePlayer => OnePlayer.PlayerID)
                .Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;

            txtLastName.Clear();    // clear the content of the textbox to search
        }
    }
}
