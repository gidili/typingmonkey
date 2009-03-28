using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TypingMonkey.Entity;

namespace TypingMonkey.Control
{
    /// <summary>
    /// Factory class for Predator Objects
    /// </summary>
    static class PredatorFactory
    {
        /// <summary>
        /// Creates an EvoStringPredator.
        /// </summary>
        /// <param name="target">Around here a predator is defined by its target.</param>
        /// <returns></returns>
        public static IPredator CreateEvoStringPredator(EvoString target)
        {
            return new EvoStringPredator(target);
        }
    }
}
