using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShockAPI;

namespace Effects2
{
    /// <summary>
    /// Represents additional Effects2 information on each player.
    /// </summary>
    public class EffectPlayer
    {
        /// <summary>
        /// The index of the corresponding player.
        /// </summary>
        public int Index { get; private set; }

        /// <summary>
        /// The corresponding TSPlayer.
        /// </summary>
        public TSPlayer TSPlayer { get { return TShock.Players[Index]; } }

        public EffectPlayer(int index)
        {
            Index = index;
        }
    }
}
