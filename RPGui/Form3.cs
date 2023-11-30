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
        Player player;
        Enemy enemy;
        Battle battle;
        public Form3(Player player, Enemy enemy) {
            InitializeComponent();
            this.player = player;
            this.enemy = enemy;
            battle = new Battle(ref player, ref enemy);
            setup();
        }

        private void setup() { 
            playersetup();
            enemysetup();
            uisetup();
        }

        private void playersetup() { 
            switch(player.job) {
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
            switch (enemy.species) {
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
            lPlayerAction.Text = player.action;
            lEnemyAction.Text = enemy.action;
            lPlayer.Text = player.name;
            lEnemy.Text = enemy.name;
            gCommands.Text = "Command Menu";
            bAttack.Text = "Attack";
            bDefend.Text = "Defend";
            bSkill.Text = "Skill";
            bItem.Text = "Item";
            gSkill1.Visible = false;
            gSkill2.Visible = false;
            gSkill3.Visible = false;
        }

        private void bAttack_Click(object sender, EventArgs e) {
            player.attack();
        }

        private void bDefend_Click(object sender, EventArgs e) {
            player.defend();
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