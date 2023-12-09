using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Character {
    public class Skill {
        public string name { get; set; }
        public string description { get; set; }
        public int cost { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
        public string feedback { get; set; }

        public Skill(string name, string description, int cost, int damage, int healing, string feedback) {
            this.name = name;
            this.description = description;
            this.cost = cost;
            this.damage = damage;
            this.healing = healing;
            this.feedback = feedback;
        }

        public void action(ref Player owner, ref Enemy target) {
            if (owner.special >= cost) {
                target.health -= damage;
                owner.health += healing;
                owner.action = feedback;
                owner.complete = true;
            } else {
                owner.action = "Not enough special...";
            }
        }

        public void action(ref Enemy owner, ref Player target) {
            target.health -= damage;
            owner.health += healing;
            owner.action = feedback;
            owner.complete = true;
        }
    }
}