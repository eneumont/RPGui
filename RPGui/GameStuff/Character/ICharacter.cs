using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Character {
    internal interface ICharacter {
        void attack(int d, int r, bool g, string n);

        void defend();

        void skill();

        int takeDamage(int damage, int defense, bool defending);

        bool hit();
    }
}