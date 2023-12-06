using RPGui.GameStuff;
using RPGui.GameStuff.Character;
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
    public partial class Form3 : Form {
        Battle b;
        public Form3(Player player, Enemy enemy) {
            InitializeComponent();
            b = new Battle(player, enemy);
            setup();
            b.run();
            updateText();
        }

        private void setup() { 
            playersetup();
            enemysetup();
            uisetup();
        }

        private void playersetup() { 
            switch(b.player.job) {
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
        }

        private void enemysetup() {
            switch (b.enemy.species) {
                case Species.Jester:
                    pEnemy.Image = RPGui.Properties.Resources.jester;
                    break;
                case Species.Dragon:
                    pEnemy.Image = RPGui.Properties.Resources.dragon;
                    break;
                case Species.Butterfly:
                    pEnemy.Image = RPGui.Properties.Resources.butterfly;
                    break;
            }
        }

        private void uisetup() {
            lPlayerAction.Text = b.player.action;
            lEnemyAction.Text = b.enemy.action;
            lPlayer.Text = b.player.name;
            lEnemy.Text = b.enemy.name;
            lPHealth.Text = b.player.health + "";
            lEHealth.Text = b.enemy.health + "";
            lPSpecial.Text = b.player.special + "";
            gPHealth.Text = "Player Health/Special";
            gEHealth.Text = "Enemy Health";
            gCommands.Text = "Command Menu";
            bAttack.Text = "Attack";
            bDefend.Text = "Defend";
            bSkill.Text = "Skill";
            bItem.Text = "Item";
            gSkill1.Visible = false;
            gSkill2.Visible = false;
            gSkill3.Visible = false;
        }

        private void updateText() {
            lPlayerAction.Text = b.player.action;
            lEnemyAction.Text = b.enemy.action;
            lPlayer.Text = b.player.name;
            lEnemy.Text = b.enemy.name;
            lPHealth.Text = b.player.health + "";
            lEHealth.Text = b.enemy.health + "";
            lPSpecial.Text = b.player.special + "";
        }

        private void bAttack_Click(object sender, EventArgs e) {
            if (!b.done) {
                b.player.attack(b.enemy.defense, b.enemy.resistance, b.enemy.defending, b.enemy.name);
                b.enemy.health -= b.player.damage;
            }
            b.run();
            updateText();
        }

        private void bDefend_Click(object sender, EventArgs e) {
            if (!b.done) {
                b.player.defend();
            }
            b.run();
            updateText();
        }

        private void bSkill_Click(object sender, EventArgs e) {
            gSkill1.Visible = !gSkill1.Visible;
            gSkill2.Visible = !gSkill2.Visible;
            gSkill3.Visible = !gSkill3.Visible;
        }

        private void bSkill1_Click(object sender, EventArgs e) {

        }

        private void bSkill2_Click(object sender, EventArgs e) {

        }

        private void bSkill3_Click(object sender, EventArgs e) {

        }

        private void bItem_Click(object sender, EventArgs e) {

        }
    }
}