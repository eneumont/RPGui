using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Character {
    public enum Job {
        Warrior,
        Knight,
        Rogue,
        Warlock,
        Druid,
        Trickster
    }

    public class Player : Character {
        int special { get; set; }
        public Job job { get; }
        Item[] inventory;
        Skill[] skills;
        public Player(Job job) {
            this.job = job;
            setStats();
        }
        private void setStats() { 
            switch (job) {
                case Job.Warrior:
                    might = 11;
                    endurance = 2;
                    agility = 4;
                    luck = 3;
                    health = 30;
                    special = 20;
                    strength = might * 2;
                    magic = might;
                    defense = endurance;
                    resistance = endurance;
                    speed = (int)(agility * 1.5);
                    dodge = agility;
                    name = "Warrior";
                    break; 
                case Job.Knight:
                    might = 4;
                    endurance = 8;
                    agility = 3;
                    luck = 5;
                    health = 30;
                    special = 20;
                    strength = (int)(might * 1.5);
                    magic = might;
                    defense = endurance * 2;
                    resistance = endurance;
                    speed = agility;
                    dodge = agility;
                    name = "Knight";
                    break; 
                case Job.Rogue:
                    might = 2;
                    endurance = 4;
                    agility = 10;
                    luck = 4;
                    health = 30;
                    special = 20;
                    strength = might;
                    magic = might;
                    defense = (int)(endurance * 1.5);
                    resistance = endurance;
                    speed = agility * 2;
                    dodge = agility;
                    name = "Rogue";
                    break;
                case Job.Warlock:
                    might = 10;
                    endurance = 4;
                    agility = 3;
                    luck = 3;
                    health = 30;
                    special = 20;
                    strength = might;
                    magic = might * 2;
                    defense = endurance;
                    resistance = (int)(endurance * 1.5);
                    speed = agility;
                    dodge = agility;
                    name = "Warlock";
                    break;
                case Job.Druid:
                    might = 3;
                    endurance = 10;
                    agility = 4;
                    luck = 3;
                    health = 30;
                    special = 20;
                    strength = might;
                    magic = might;
                    defense = endurance;
                    resistance = endurance * 2;
                    speed = (int)(agility * 1.5);
                    dodge = agility;
                    name = "Druid";
                    break;
                case Job.Trickster:
                    might = 5;
                    endurance = 3;
                    agility = 9;
                    luck = 3;
                    health = 30;
                    special = 20;
                    strength = might;
                    magic = (int)(might * 1.5);
                    defense = endurance;
                    resistance = endurance;
                    speed = agility;
                    dodge = agility * 2;
                    name = "Trickster";
                    break;
            }
        }

        public void playerTurn() {
            while (!complete) { 
                
            }
        }
    }
}