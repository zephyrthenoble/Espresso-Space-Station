#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Espresso_Space_Station
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new EspressoSpaceStation())
                game.Run();
        }
    }
#endif
}
