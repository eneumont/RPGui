using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Character {
    internal interface ICharacter {
        void attack(Character character);

        void defend();

        void skill();

        int takeDamage(int damage, Character target);

        bool hit();
    }
}