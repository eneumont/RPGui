using RPGui.GameStuff.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff {
    internal class Battle {
        public Player player;
        public Enemy enemy;
        public bool done = false;

        public Battle(Player player, Enemy enemy) {
            this.player = player;
            this.enemy = enemy;
        }

        public void run() {
            if (!done) {
                if (player.speed > enemy.speed) {
                    if (!player.complete) player.playerTurn();
                    if (!enemy.complete) enemy.enemyTurn(ref player);
                } else if (enemy.speed > player.speed) {
                    if (!enemy.complete) enemy.enemyTurn(ref player);
                    if (!player.complete) player.playerTurn();
                } else {
                    Random r = new Random();
                    int first = r.Next(2);
                    switch (first) {
                        case 0:
                            if (!enemy.complete) enemy.enemyTurn(ref player);
                            if (!player.complete) player.playerTurn();
                            break;
                        case 1:
                            if (!player.complete) player.playerTurn();
                            if (!enemy.complete) enemy.enemyTurn(ref player);
                            break;
                    }
                }
                done = checkHealth();
                if (player.complete && enemy.complete) {
                    player.complete = false;
                    player.defending = false;
                    player.damage = 0;
                    enemy.complete = false;
                    enemy.defending = false;
                    enemy.damage = 0;
                }
            } else { 
                if (player.health <= 0) {
                    player.action = player.name + " died! Try Again...";
                } else {
                    enemy.action = enemy.name + " died! You win!";
                }
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