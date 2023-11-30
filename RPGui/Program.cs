using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGui {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form3(new GameStuff.Character.Player(GameStuff.Character.Job.Warrior), new GameStuff.Character.Enemy(GameStuff.Character.Species.Jester)));
            Application.Run(new Form1());
        }
    }
}