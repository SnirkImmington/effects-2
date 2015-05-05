using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TerrariaApi;
using TerrariaApi.Server;
using TShockAPI;
using TShockAPI.Hooks;

namespace Effects2
{
    /// <summary>
    /// Main class for the plugin.
    /// </summary>
    public class PluginMain : TerrariaPlugin
    {
        #region Plugin Properties

        public override string Name { get { return "Effects 2"; } }

        public override Version Version { get { return Assembly.GetCallingAssembly().GetName().Version; } }

        public override string Author { get { return "Snirk Immington"; } }

        public override string Description { get { return "Adds customizeable events to the world"; } }

        #endregion

        #region Main variables

        /// <summary>
        /// The collection of players whose data is used in the plugin
        /// </summary>
        internal static List<EffectPlayer> Players = new List<EffectPlayer>(20);
        /// <summary>
        /// The last time the on-second udpate was called.
        /// </summary>
        private DateTime LastUpdate = DateTime.Now;
        /// <summary>
        /// Counts every 5 updates for 5 second updates.
        /// </summary>
        private byte UpdateMode = 0;

        #endregion

        #region Initialize

        public override void Initialize()
        {
            //: Load config
            //: Load DB
            //: Attach Hooks
        }

        private static void PostInitialize()
        {
            // Call all of the API things
        }

        #endregion

        #region Hooks

        private static void OnGreet(GreetPlayerEventArgs greet)
        {
            //: Add a player to the player list
            //: Call any greet event effects?

            if (!greet.Handled)
            {
                Players[greet.Who] = new EffectPlayer(greet.Who);
            }
        }

        private static void OnLeave(LeaveEventArgs leave)
        {
            //: Save anything that needs to be saved
            //: Remove the player from the database
        }



        private static void OnUpdate()
        {

        }

        #endregion
    }
}
