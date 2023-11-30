using RPGui.GameStuff.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff {
    internal class Battle {
        public Player player { get; set; }
        public Enemy enemy { get; set; }
        public bool done { get; set; }

        public Battle(ref Player player, ref Enemy enemy) {
            this.player = player;
            this.enemy = enemy;
        }

        public void run() {
            done = checkHealth();
            while (!done) {
                if (player.speed > enemy.speed) {
                    player.playerTurn();
                    enemy.enemyTurn();
                } else if (enemy.speed > player.speed) {
                    enemy.enemyTurn();
                    player.playerTurn();
                } else {
                    Random r = new Random();
                    int first = r.Next(2);
                    switch (first) {
                        case 0:
                            enemy.enemyTurn();
                            player.playerTurn();
                            break;
                        case 1:
                            player.playerTurn();
                            enemy.enemyTurn();
                            break;
                    }
                }
                done = checkHealth();
            }
        }

        bool checkHealth() {
            if (player.health <= 0 || enemy.health <= 0) {
                return true;
            }
            return false;
        }   
    }
}