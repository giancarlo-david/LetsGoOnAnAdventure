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
    public partial class FormMain : Form
    {

        string userName = null;
        Companion Gian = new Companion(true, "Gian's eyebrow's twitch", "Gian says \"Don't worry about it\"", "Gian talks about Melee", 0, 0);
        Companion Michael = new Companion(true, "Michael sighs and looks cranky (As usual)", "Michael squints at you", "Michael starts singing 'Bohemian Rhapsody'", 0, 0);
        Companion Rebekah = new Companion(true, "Rebekah compulsively fills the silence with talking", "Rebekah says \"Isn't this FANTABULAMAZING\"", "Rebekah talks about being Mormon", 0, 0);
        Companion Kenny = new Companion(false, "Kenny laughs and says \"Feelsbadman\"", "Kenny says \"Same\"", "Kenny says \"Ma heart\"", 2, 2);
        Companion Kevin = new Companion(false, "Kevin groans and says \"Not like this\"", "Kevin stares at you", "Kevin puts his earbuds in", 3, 2);
        Companion Melissa = new Companion(false, "Melissa purrs", "Melissa continues to watch anime", "Melissa looks ready to practice jiu jitsu on you", 50, 10);
        Companion Victoria = new Companion(false, "Victoria makes a pun", "Victoria makes random movements", "Victoria talks about science", 10, 5);

        int numEvent = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            userName = textBoxName.Text;

            if (userName != "")
            {
                labelTitle.Visible = false;
                textBoxName.Visible = false;
                labelName.Visible = false;
                buttonBegin.Visible = false;

                richTextBoxNarration.Visible = true;
                buttonContinue.Visible = true;

                richTextBoxNarration.Text = "****************************************\n" +
                                            "Welcome " + userName + ", the adventure simulator is about to begin...\n" +
                                            "****************************************";
            }

            else
            {
                MessageBox.Show("Enter a name to begin simulation");
            }
        }

        private void narration()
        {
            switch (numEvent)
            {
                case 0:
                    richTextBoxNarration.Text = "****************************************\n" +
                        "You are currently in your room after a long day of school.\n" +
                        "It is currently 6 P.M. and the group chat has decided to get dinner and you notice your stomach rumble.\n" +
                        "You decide to go to the dining hall in hopes of getting a delicious meal.\n" +
                        "****************************************";
                    break;

                case 2:
                    richTextBoxNarration.Text = "****************************************\n" +
                        "You eat with your friends Michael, Melissa, Kenny, Victoria, Kevin, Rebekah, and Gian.\n" +
                        "Conversation flows as you all eat your meals.\n" +
                        "****************************************";
                    break;

                case 3:
                    richTextBoxNarration.Text = "****************************************\n" +
                        "Once everyone is done, you all put up your dishes and head over to Residence Hall South in order " +
                        "to commence friendshiping.\n" +
                        "****************************************";
                    break;

                case 4:
                    richTextBoxNarration.Text = "****************************************\n" +
                        "While at south, you all end up doing homework.\n" +
                        "Michael, Melissa and Victoria are working on Calculus.\n" +
                        "Kenny and Gian are working on Chemistry.\n" +
                        "Kevin and Rebekah are working on Computer Science.\n" +
                        "****************************************";
                    break;

                case 5:
                    richTextBoxNarration.Text = "\n\n\n\n\n********* A FEW HOURS PASS  *********";
                    break;

                case 6:
                    richTextBoxNarration.Text = "****************************************\n" +
                        "After a few hours of homework, the room has turned into chaos.\n" +
                        "****************************************";
                        break;

                case 7:
                    richTextBoxNarration.Text = "****************************************\n" +
                        "Michael, Melissa, and Victoria are now throwing Hot Tamales at each other.\n";
                    break;

                case 8:
                    richTextBoxNarration.Text += "Gian is shouting as he gets every ALEKS question wrong.\n";
                    break;

                case 9:
                    richTextBoxNarration.Text += "Kenny is trying to help Rebekah and Kevin with their homework.\n";
                    break;

                case 10:
                    richTextBoxNarration.Text += "Kevin has now given up at this point and lies down listening to music.\n";
                    break;

                case 11:
                    richTextBoxNarration.Text += "Rebekah struggles to understand Kenny's explanation for the program.\n" +
                        "****************************************";
                    break;

                case 12:
                    richTextBoxNarration.Text = "****************************************\n" +
                        "Seeing this, you decide it's time for a break and ask\n" +
                        "\"Who is up for an adventure?\"\n";
                    break;

                case 13:
                    richTextBoxNarration.Text += "Michael, Rebekah, and Gian are up for the adventure.\n" +
                        "While the others are kind of on the fence.\n";
                    break;

                case 14:
                    richTextBoxNarration.Text += "You decide to play \"What are the odds?\" " +
                        "with each person to see if you can get them to come.\n" +
                        "****************************************";
                    break;
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            switch(numEvent)
            {
                case 0:
                    narration();
                    numEvent++;
                    break;
                case 1:
                    // Insert open Dining hall form function
                    numEvent++;
                    break;
                case 2:
                    narration();
                    numEvent++;
                    break;
                case 3:
                    narration();
                    numEvent++;
                    break;
                case 4:
                    narration();
                    numEvent++;
                    break;
                case 5:
                    narration();
                    numEvent++;
                    break;
                case 6:
                    narration();
                    numEvent++;
                    break;
                case 7:
                    narration();
                    numEvent++;
                    break;
                case 8:
                    narration();
                    numEvent++;
                    break;
                case 9:
                    narration();
                    numEvent++;
                    break;
                case 10:
                    narration();
                    numEvent++;
                    break;
                case 11:
                    narration();
                    numEvent++;
                    break;
                case 12:
                    narration();
                    numEvent++;
                    break;
                case 13:
                    narration();
                    numEvent++;
                    break;
                case 14:
                    narration();
                    numEvent++;
                    break;
                case 15:
                    // OddsToGo function here
                    break;
            }
        }
    }
}
