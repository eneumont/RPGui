using RPGui.GameStuff;
using RPGui.GameStuff.Character;

namespace RPGMaui {
	public partial class BattlePage : ContentPage {
		Battle b;
		public BattlePage(Player player, Enemy enemy) {
            InitializeComponent();
			b = new Battle(player, enemy);
            setup();
            b.run();
            updateText();
		}

        private void setup() {
            playersetup();
            enemysetup();
        }

        private void playersetup() {
            switch (b.player.job) {
                case Job.Warrior:
                    iPlayer.Source = ImageSource.FromFile("warrior.jpg");
                    break;
                case Job.Knight:
                    iPlayer.Source = ImageSource.FromFile("knight.jpg");
                    break;
                case Job.Rogue:
                    iPlayer.Source = ImageSource.FromFile("rogue.jpg");
                    break;
                case Job.Warlock:
                    iPlayer.Source = ImageSource.FromFile("warlock.jpg");
                    break;
                case Job.Druid:
                    iPlayer.Source = ImageSource.FromFile("druid.jpg");
                    break;
                case Job.Trickster:
                    iPlayer.Source = ImageSource.FromFile("trickster.jpg");
                    break;
            }
        }

        private void enemysetup() {
            switch (b.enemy.species) {
                case Species.Jester:
                    iEnemy.Source = ImageSource.FromFile("jester.jpg");
                    break;
                case Species.Dragon:
                    iEnemy.Source = ImageSource.FromFile("dragon.jpg");
                    break;
                case Species.Butterfly:
                    iEnemy.Source = ImageSource.FromFile("butterfly.jpg");
                    break;
            }
        }

        private void updateText() {
            lplayerAction.Text = b.player.action;
            lenemyAction.Text = b.enemy.action;
            lplayerName.Text = b.player.name;
            lenemyName.Text = b.enemy.name;
            lplayerCondition.Text = "Health: " + b.player.health + " Special: " + b.player.special;
            lenemyCondition.Text = "Health: " + b.enemy.health;
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