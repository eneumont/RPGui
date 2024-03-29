﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGui.GameStuff.Dialogue {
    public class Response {
        public string responseText { get; set; }
        public Dictionary<string, Response> dialogueOptions { get; set; }

        public Response() { 
            responseText = string.Empty;
            dialogueOptions = new Dictionary<string, Response>();
        }
    }
}