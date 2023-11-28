using RPGui.GameStuff.Character;
using RPGui.GameStuff.Dialogue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGui {
    public partial class Form2 : Form {
        Player player;
        Enemy enemy;
        Dialogue dialogue;
        Response response;
        RadioButton[] radioButtons;
        bool loop = true;
        public Form2(Player player) {
            InitializeComponent();
            this.player = player;
            setup();
            while (loop) {
                showDialogue();
            }
        }

        public void setup() {
            playersetup();
            enemysetup();
            uisetup();
        }

        private void playersetup() {
            switch (player.job) {
                case Job.Warrior:
                    pPlayer.Image = RPGui.Properties.Resources.warrior;
                    break;
                case Job.Knight:
                    pPlayer.Image = RPGui.Properties.Resources.knight;
                    break;
                case Job.Rogue:
                    pPlayer.Image = RPGui.Properties.Resources.rogue;
                    break;
                case Job.Warlock:
                    pPlayer.Image = RPGui.Properties.Resources.warlock;
                    break;
                case Job.Druid:
                    pPlayer.Image = RPGui.Properties.Resources.druid;
                    break;
                case Job.Trickster:
                    pPlayer.Image = RPGui.Properties.Resources.trickster;
                    break;

            }
            lPlayer.Text = player.name;
        }

        private void enemysetup() { 
            Random rand = new Random();
            int r = rand.Next(3) + 1;
            r = 1;
            switch (r) { 
                case 1:
                    enemy = new Enemy(Species.Jester);
                    pEnemy.Image = RPGui.Properties.Resources.jester;
                    dialogue = jesterDialogue();
                    break;
                case 2:
                    enemy = new Enemy(Species.Dragon);
                    pEnemy.Image = RPGui.Properties.Resources.dragon;
                    dialogue = dragonDialogue();
                    break;
                case 3:
                    enemy = new Enemy(Species.Butterfly);
                    pEnemy.Image = RPGui.Properties.Resources.butterfly;
                    dialogue = butterflyDialogue();
                    break;
            }
            lEnemy.Text = enemy.name;
        }

        private void uisetup() {
            gbPlayer.Text = "Player Dialogue";
            gbEnemy.Text = "Enemy Dialogue";
            bConfirm.Text = "Confirm";
            rbFirst.Text = "";
            rbSecond.Text = "";
            rbThird.Text = "";
            radioButtons = new RadioButton[3];
            radioButtons[0] = rbFirst;
            radioButtons[1] = rbSecond;
            radioButtons[2] = rbThird;
        }

        private Dialogue jesterDialogue() {
            //Response begin = new Response {
            //    responseText = "You're in a circus watching a stellar performance " +
            //    "when the main attraction Jacob Church shines the spotlight on you!",
            //    dialogueOptions = new string[] { "...", "Who?!" }
            //};
            Response referenceStart = new Response();

            Response jokeStart = new Response();

            Response puzzleThird = new Response();

            Response puzzleSecond = new Response();

            Response puzzleStart = new Response();
            puzzleStart.responseText = "The jester looks at you in disgust. " +
                "Jacob Church head of the circus you're currently attending? " +
                "How do you not known this? ";
            puzzleStart.dialogueOptions.Add(
                "Sorry my brain was just messed up for a second.",
                puzzleSecond
                );
            puzzleStart.dialogueOptions.Add(
                "But why Jacob Church of all names?",
                jokeStart
                );
            if ((player.job == Job.Warlock) || (player.job == Job.Druid) || (player.job == Job.Trickster)) { 
                puzzleStart.dialogueOptions.Add(
                    "I think someone is messing with me.",
                    referenceStart
                    );
            }

            Response silentSecond = new Response();

            Response silentStart = new Response();
            silentStart.responseText = "C'mon don't be shy. I got a special gift just for you!";
            silentStart.dialogueOptions.Add(
                "...",
                silentSecond
                );
            silentStart.dialogueOptions.Add(
                "Really?! What is it?!",
                puzzleThird
                );

            Response begin = new Response();
            begin.responseText = "You're in a circus watching a stellar performance " +
                "when the main attraction Jacob Church shines the spotlight on you!";
            begin.dialogueOptions.Add(
                "...",
                silentStart
                );
            begin.dialogueOptions.Add(
                "Who?!",
                puzzleStart
                );

            Dialogue start = new Dialogue { dialogueStart = begin };
            return start;
        }

        private Dialogue dragonDialogue() {
            Response begin = new Response();

            Dialogue start = new Dialogue { dialogueStart = begin };
            return start;
        }

        private Dialogue butterflyDialogue() {
            Response begin = new Response();

            Dialogue start = new Dialogue { dialogueStart = begin };
            return start;
        }

        private void showDialogue() {
            //ltext.Text = dialogue.dialogueStart.responseText;
            //Response response = dialogue.dialogueStart;
            ltext.Text = dialogue.dialogueStart.responseText;
            response = dialogue.dialogueStart;

            if (response.playerOptions != null) { 
                for (int i = 0; i < response.playerOptions.Length; i++) {
                    radioButtons[i].Text = response.playerOptions[i];
                }
            }

            //while (response.playerOptions != null && response.playerOptions.Length > 0) {
            //    // Display player options
            //    for (int i = 0; i < response.playerOptions.Length; i++) {
            //        radioButtons[i].Text = response.playerOptions[i];
            //    }

            //    // Get user input
            //    int choice = GetUserChoice(currentResponse.playerOptions.Length);

            //    // Get the next response based on the user's choice
            //    string selectedOption = currentResponse.playerOptions[choice - 1];
            //    if (currentResponse.dialogueOptions.TryGetValue(selectedOption, out Response nextResponse))
            //    {
            //        Console.WriteLine(nextResponse.responseText);
            //        currentResponse = nextResponse;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid option. Exiting dialogue.");
            //        break;
            //    }
            //}
        }

        private void bConfirm_Click(object sender, EventArgs e) {
            for (int i = 0; i < radioButtons.Length; i++) {
                if (radioButtons[i].Checked && radioButtons[i].Text != "") { 
                    
                }
            }
        }
    }
}