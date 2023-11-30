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
        Response response;
        RadioButton[] radioButtons;
        public Form2(Player player) {
            InitializeComponent();
            this.player = player;
            setup();
            showDialogue();
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
                    jesterDialogue();
                    break;
                case 2:
                    enemy = new Enemy(Species.Dragon);
                    pEnemy.Image = RPGui.Properties.Resources.dragon;
                    dragonDialogue();
                    break;
                case 3:
                    enemy = new Enemy(Species.Butterfly);
                    pEnemy.Image = RPGui.Properties.Resources.butterfly;
                    butterflyDialogue();
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

        private void jesterDialogue() {
            Response fight4 = new Response();
            fight4.responseText = "@#$% you! Pocket Sand!";
            fight4.dialogueOptions.Add(
                "My eyes! (fight)",
                null);

            Response fight3 = new Response();
            fight3.responseText = "Ok... think imma just kill you now.";
            fight3.dialogueOptions.Add(
                "Oh no (fight)",
                null
                );

            Response fight2 = new Response();
            fight2.responseText = "Ow! How did you...";
            fight2.dialogueOptions.Add(
                "Die! (fight)",
                null);

            Response fight1 = new Response();
            fight1.responseText = "To die of course!";
            fight1.dialogueOptions.Add(
                "You b... (fight)",
                null);
            if(player.speed > 9) fight1.dialogueOptions.Add(
                "Throw knife",
                fight2
                );

            Response referenceSecond = new Response();
            referenceSecond.responseText = "No";
            referenceSecond.dialogueOptions.Add(
                "Yes",
                fight4
                );

            Response jokeSecond = new Response();
            jokeSecond.responseText = "Wow, that really hurt my feelings. Imma go cry now. " +
                "He leaves the stage in tears as the rest of the crowd boos you until you leave.";
            jokeSecond.dialogueOptions.Add(
                "Go home (end)",
                null
                );

            Response jokeStart = new Response();
            jokeStart.responseText = "Cause why not?";
            jokeStart.dialogueOptions.Add(
                "Cause, that's my name!",
                referenceSecond
                );
            jokeStart.dialogueOptions.Add(
                "Cause, it sucks.",
                jokeSecond
                );

            Response puzzleThird = new Response();
            puzzleThird.responseText = "Then why are you here?";
            puzzleThird.dialogueOptions.Add(
                "To get over my fear.",
                fight3
                );
            puzzleThird.dialogueOptions.Add(
                "AAAAAAAAAAAAAAAAAHHHHHH!",
                fight3
                );

            Response puzzleSecond = new Response();
            puzzleSecond.responseText = "No worries, today I want to give our " +
                "audience an amazing show and I need you to do it? So come on down! " +
                "You walk down the bleachers and unto center stage.";
            puzzleSecond.dialogueOptions.Add(
                "So, what do you need me for?",
                fight1
                );
            puzzleSecond.dialogueOptions.Add(
                "Wait a minute, is this a trap?",
                referenceSecond
                );
            puzzleSecond.dialogueOptions.Add(
                "Sorry, I'm scared of clowns.",
                puzzleThird
                );

            Response referenceStart = new Response();
            referenceStart.responseText = "No I'm not...";
            referenceStart.dialogueOptions.Add(
                "Yes you are!",
                referenceSecond
                );
            referenceStart.dialogueOptions.Add(
                "Oh my bad carry on",
                puzzleSecond
                );

            Response puzzleStart = new Response();
            puzzleStart.responseText = "The jester looks at you in disgust. " +
                "Jacob Church head of the circus you're currently attending? " +
                "How do you not know this? ";
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

            Response silentThird = new Response();
            silentThird.responseText = "...";
            silentThird.dialogueOptions.Add(
                "...",
                fight4
                );

            Response silentSecond = new Response();
            silentSecond.responseText = "You know eventually you'll have to say something.";
            silentSecond.dialogueOptions.Add(
                "...",
                silentThird
                );

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

            response = begin;
        }

        private void dragonDialogue() {
            Response begin = new Response();

            response = begin;
        }

        private void butterflyDialogue() {
            Response begin = new Response();

            response = begin;
        }

        private void showDialogue() {
            ltext.Text = response.responseText;

            for (int i = 0; i < response.dialogueOptions.Keys.ToArray().Length; i++) {
                radioButtons[i].Text = response.dialogueOptions.Keys.ToArray()[i];
            }
        }

        private void clearDialogue() {
            for (int i = 0; i < radioButtons.Length; i++) {
                radioButtons[i].Text = "";
            }
        }

        private void bConfirm_Click(object sender, EventArgs e) {
            for (int i = 0; i < radioButtons.Length; i++) {
                if (radioButtons[i].Checked && radioButtons[i].Text != "") {
                    if (radioButtons[i].Text.ToLower().Contains("fight")) {
                        var form = new Form3(player, enemy);
                        form.Location = Location;
                        form.StartPosition = FormStartPosition.Manual;
                        form.FormClosing += delegate { Close(); };
                        form.Show();
                        Hide();
                    } else if (radioButtons[i].Text.ToLower().Contains("end")) {
                        Close();
                    } else {
                        response = response.dialogueOptions[radioButtons[i].Text];
                        clearDialogue();
                        showDialogue();
                        break;
                    }
                }
            }
        }
    }
}