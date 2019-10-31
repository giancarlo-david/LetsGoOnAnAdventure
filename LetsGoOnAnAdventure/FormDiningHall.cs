using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsGoOnAnAdventure
{
    public partial class FormDiningHall : Form
    {
        Stations stationPicked = 0;

        public FormDiningHall()
        {
            InitializeComponent();
        }

        enum Stations
        {
            Grill,
            Deli,
            Burger,
            Pasta
        };

        private void buttonGrill_Click(object sender, EventArgs e)
        {
            stationPicked = Stations.Grill;
            groupBoxStations.Visible = false;
            richTextBoxOptionSelected.Visible = true;

            richTextBoxOptionSelected.Text = "****************************************\n" +
                "You see some nasty broccoli and make a comment about it.\n" +
                "You don't touch the broccoli but instead get the other food in the station.\n" +
                "On your way to your table, the broccoli lady runs to you and says\n" +
                "\"I know you wanted some of these\" as she hands you a bowl of broccoli\nand stares you down\n" +
                "****************************************";

            buttonContinue.Visible = true;
        }

        private void buttonDeli_Click(object sender, EventArgs e)
        {
            stationPicked = Stations.Deli;
            groupBoxStations.Visible = false;
            richTextBoxOptionSelected.Visible = true;

            richTextBoxOptionSelected.Text = "****************************************\n" +
                 "You see no other good options so you force yourself to make a sandwich to eat.\n" +
                 "After using the panini press, you end up with a mediocre sandwich.\n" +
                 "****************************************";

            buttonContinue.Visible = true;
        }

        private void buttonBurger_Click(object sender, EventArgs e)
        {
            stationPicked = Stations.Burger;
            groupBoxStations.Visible = false;
            richTextBoxOptionSelected.Visible = true;

            richTextBoxOptionSelected.Text = "****************************************\n" +
                "You choose to get a burger because you think \"What could go wrong?\"\n" +
                "It's after you make the burger that you realize you have made a huge mistake\n" +
                "The burger is burnt and dry, and you hate yourself for every bite you take" +
                "****************************************";

            buttonContinue.Visible = true;
        }
    }
}
