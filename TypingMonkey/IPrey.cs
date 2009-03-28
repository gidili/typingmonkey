using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypingMonkey.Entity
{
    interface IPrey
    {
        /// <summary>
        /// A prey mates with another prey.
        /// </summary>
        /// <param name="mate"> Prey's Mate</param>
        /// <returns> Returns a Child born from the act of mating.</returns>
        IPrey Mate(IPrey mate);

        /// <summary>
        /// Returns a deep-copy of the Prey.
        /// </summary>
        /// <returns>A deep-Copy of the prey.</returns>
        IPrey Clone();
    }
}
