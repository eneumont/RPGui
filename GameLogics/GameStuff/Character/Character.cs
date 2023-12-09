using RPGui.GameStuff.Dialogue;
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
        public string name { get; set; }
        public string action { get; set; }
        public bool complete = false;
        public bool defending = false;
        public int damage = 0;
        protected Skill[] skills = new Skill[3];

        public void attack(int d, int r, bool g, string n) {
            if (hit()) {
                if (strength > magic) {
                    damage = takeDamage(strength, d, g);
                } else {
                    damage = takeDamage(magic, r, g);
                }
                action = name + " hit " + n;
            } else {
                damage = 0;
                action = name + " missed their attack!";
            }
            complete = true;
        }

        public void defend() { 
            defending = true;
            action = name + " is guarding.";
            complete = true;
        }

        public void skill() { 
        
        }

        public int takeDamage(int damage, int defense, bool defending) {
            if (defending) {
                return damage / 2;
            } else {
                return damage;
            }
        }

        public bool hit() { 
            return true;
        }
    }
}