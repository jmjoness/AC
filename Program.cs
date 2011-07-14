using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Peter's github test change.
// Adding a comment to test github.

namespace AC {
   static class Program {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Form1());
      }
   }
}