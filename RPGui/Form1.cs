using RPGui.GameStuff.Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGui {
    public partial class Form1 : Form {
        int totalPoints = 20, mPoints = 0, ePoints = 0, aPoints = 0, lPoints = 0;
        Player player;
        public Form1() {
            InitializeComponent();
            setup();
        }

        public void setup() {
            statChanges();
            //l1.DataBindings.Add("Text", this, "mPoints", false, DataSourceUpdateMode.OnPropertyChanged);
            lmight.Text = "Might";
            lend.Text = "Endurance";
            lagl.Text = "Agility";
            lluck.Text = "Luck";
            rb1.Text = "Warrior";
            rb2.Text = "Knight";
            rb3.Text = "Rogue";
            rb4.Text = "Warlock";
            rb5.Text = "Druid";
            rb6.Text = "Trickster";
            btnStart.Text = "Start";
            gb1.Text = "Pick a Job";
            gb2.Text = "Stats";
            linfo.Text = "Pick a Job, tweak it's stats, then play!";
        }

        public void statChanges() {
            l1.Text = mPoints.ToString();
            l2.Text = ePoints.ToString();
            l3.Text = aPoints.ToString();
            l4.Text = lPoints.ToString();
            l5.Text = totalPoints.ToString() + " points left";
        }

        public void playerChange(Job job) {
            player = new Player(job);
            totalPoints = 0;
            mPoints = player.might;
            ePoints = player.endurance;
            aPoints = player.agility;
            lPoints = player.luck;
            statChanges();
        }
        
        public void minusPoints(ref int points) {
            if (points > 0) {
                points--;
                totalPoints++;
            }
            statChanges();
        }

        public void plusPoints(ref int points) {
            if (totalPoints > 0) {
                totalPoints--;
                points++;
            }
            statChanges();
        }

        private void left_might(object sender, EventArgs e) {
            minusPoints(ref mPoints);
        }

        private void left_endurance(object sender, EventArgs e) {
            minusPoints(ref ePoints);
        }

        private void left_agility(object sender, EventArgs e) {
            minusPoints(ref aPoints);
        }

        private void left_luck(object sender, EventArgs e) {
            minusPoints(ref lPoints);
        }

        private void right_might(object sender, EventArgs e) {
            plusPoints(ref mPoints);
        }

        private void right_endurance(object sender, EventArgs e) {
            plusPoints(ref ePoints);
        }

        private void right_agility(object sender, EventArgs e) {
            plusPoints(ref aPoints);
        }

        private void right_luck(object sender, EventArgs e) {
            plusPoints(ref lPoints);
        }

        private void rb_Warlock(object sender, EventArgs e) {
            playerChange(Job.Warlock);
        }

        private void rb_Warrior(object sender, EventArgs e) {
            playerChange(Job.Warrior);
        }

        private void rb_Knight(object sender, EventArgs e) {
            playerChange(Job.Knight);
        }

        private void rb_Druid(object sender, EventArgs e) {
            playerChange(Job.Druid);
        }

        private void rb_Trickster(object sender, EventArgs e) {
            playerChange(Job.Trickster);
        }

        private void rb_Rogue(object sender, EventArgs e) {
            playerChange(Job.Rogue);
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (rb1.Checked || rb2.Checked || rb3.Checked || rb4.Checked || rb5.Checked || rb6.Checked) {
                var form = new Form2(player);
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Close(); };
                form.Show();
                this.Hide();
            } else {
                linfo.Text = "Pick a class!";
            }
        }
    }
}