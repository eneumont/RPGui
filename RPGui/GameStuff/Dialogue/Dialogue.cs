using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Dialogue {
    internal class Dialogue {
        // relationship between npcs and dialogue is the responsibility of this class
        // start the dialogue (first thing said, first option etc)
        public Response dialogueStart { get; set; }
        public Dialogue() { 
            dialogueStart = new Response();
        }
    }
}