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
        Stations stationPicked = Stations.None;

        public FormDiningHall()
        {
            InitializeComponent();
        }

        enum Stations
        {
            None,
            Grill,
            Deli,
            Burger,
            Pasta
        };

        private void buttonGrill_Click(object sender, EventArgs e)
        {
            stationPicked = Stations.Grill;
            groupBoxStations.Visible = false;
            displayNarration();
            buttonContinue.Visible = true;
        }

        private void buttonDeli_Click(object sender, EventArgs e)
        {
            stationPicked = Stations.Deli;
            groupBoxStations.Visible = false;
            displayNarration();
            buttonContinue.Visible = true;
        }

        private void buttonBurger_Click(object sender, EventArgs e)
        {
            stationPicked = Stations.Burger;
            groupBoxStations.Visible = false;
            displayNarration();
            buttonContinue.Visible = true;
        }

        private void buttonPasta_Click(object sender, EventArgs e)
        {
            stationPicked = Stations.Pasta;
            groupBoxStations.Visible = false;
            displayNarration();
        }

        private void displayNarration()
        {
            richTextBoxOptionSelected.Visible = true;

            switch (stationPicked)
            {
                case Stations.Grill:
                    richTextBoxOptionSelected.Text = "****************************************\n" +
                        "You see some nasty broccoli and make a comment about it.\n" +
                        "You don't touch the broccoli but instead get the other food in the station.\n" +
                        "On your way to your table, the broccoli lady runs to you and says\n" +
                        "\"I know you wanted some of these\" as she hands you a bowl of broccoli\nand stares you down\n" +
                        "****************************************";
                    break;
                case Stations.Deli:
                    richTextBoxOptionSelected.Text = "****************************************\n" +
                         "You see no other good options so you force yourself to make a sandwich to eat.\n" +
                         "After using the panini press, you end up with a mediocre sandwich.\n" +
                         "****************************************";
                    break;
                case Stations.Burger:
                    richTextBoxOptionSelected.Text = "****************************************\n" +
                        "You choose to get a burger because you think \"What could go wrong?\"\n" +
                        "It's after you make the burger that you realize you have made a huge mistake\n" +
                        "The burger is burnt and dry, and you hate yourself for every bite you take" +
                        "****************************************";
                    break;
                case Stations.Pasta:
                    richTextBoxOptionSelected.Text = "****************************************\n" +
                        "You gather the vegetables that you want in your pasta,\n and give Richard your bowl." +
                        "****************************************";
                    wantChicken();
                    pickSauce();

                    break;
                default:
                    break;
            }
        }

        private void wantChicken()
        {
            panelChicken.Visible = true;
        }

        private void pickSauce()
        {

        }

        private void buttonYesChicken_Click(object sender, EventArgs e)
        {
                
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (stationPicked == Stations.Burger || stationPicked == Stations.Grill || stationPicked == Stations.Deli)
            {
                this.Hide();
            }

            else
            {

            }
        }
    }
}
