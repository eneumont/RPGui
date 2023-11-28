using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGui.GameStuff.Dialogue;

namespace RPGui.GameStuff.Character {
    internal class NonPlayableCharacter : Character {
        public Response dialogue { get; set; }
    }
}
