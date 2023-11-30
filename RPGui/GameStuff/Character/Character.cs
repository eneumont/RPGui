using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Character {
    public abstract class Character : ICharacter {
        public int might { get; set; }
        public int endurance { get; set; }
        public int agility { get; set; }
        public int luck { get; set; }
        public int strength { get; set; }
        public int magic { get; set; }
        public int defense { get; set; }
        public int resistance { get; set; }
        public int speed { get; set; }
        public int dodge { get; set; }
        public int health { get; set; }
        public String name { get; set; }
        public String action { get; set; }
        public bool complete = false;

        public Character() { 
    
        }

        public void attack() { 
        
        }

        public void defend() { 
        
        }

        public void skill() { 
        
        }

        public int takeDamage(int damage, Character target) {
            return 0;
        }

        public bool hit() { 
            return true;
        }
    }
}