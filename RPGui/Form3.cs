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
        public Form3(Player player, Enemy enemy) {
            InitializeComponent();
            this.player = player;
            this.enemy = enemy;
        }

    }
}