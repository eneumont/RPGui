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
        public Enemy(Species species) { 
            this.species = species;
            setStats();
        }

        private void setStats() {
            switch (species) { 
                case Species.Jester:
                    name = "Jacob Church";
                    break;
                case Species.Dragon:
                    name = "Dragon";
                    break;
                case Species.Butterfly:
                    name = "Butterfly";
                    break;
            }
        }

        public void enemyTurn() { 
            Random r = new Random();
            int c = r.Next(4) + 1;
            switch (c) {
                case 1:
                    attack();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
    }
}
