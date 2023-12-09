using RPGui.GameStuff.Dialogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Character {
    public enum Species { 
        Jester,
        Dragon,
        Butterfly
    }
    public class Enemy : Character {
        public Species species { get; set; }
        public Response response { get; set; }
        public Enemy(Species species) { 
            this.species = species;
            setStats();
        }

        private void setStats() {
            switch (species) { 
                case Species.Jester:
                    name = "Jacob Church";
                    might = 5;
                    endurance = 5;
                    agility = 9;
                    luck = 10;
                    health = 300;
                    strength = (int)(might * 1.5);
                    magic = (int)(might * 1.5);
                    defense = (int)(endurance * 1.5);
                    resistance = (int)(endurance * 1.5);
                    speed = agility * 2;
                    dodge = agility;
                    break;
                case Species.Dragon:
                    name = "Dragon";
                    might = 10;
                    endurance = 10;
                    agility = 4;
                    luck = 3;
                    health = 600;
                    strength = might * 2;
                    magic = might;
                    defense = endurance * 2;
                    resistance = endurance;
                    speed = agility;
                    dodge = agility;
                    break;
                case Species.Butterfly:
                    name = "Butterfly";
                    might = 7;
                    endurance = 7;
                    agility = 7;
                    luck = 7;
                    health = 450;
                    strength = might;
                    magic = might * 2;
                    defense = endurance;
                    resistance = endurance * 2;
                    speed = agility;
                    dodge = agility * 2;
                    break;
            }
        }

        public void enemyTurn(ref Player target) {
            if (health > 0) {
                Random r = new Random();
                int c = r.Next(4) + 1;
                c = 1;
                switch (c) {
                    case 1:
                        attack(target.defense, target.resistance, target.defending, target.name);
                        target.health -= damage;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
            complete = true;
        }
    }
}
