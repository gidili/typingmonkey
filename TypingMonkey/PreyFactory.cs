using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TypingMonkey;
using TypingMonkey.Entity;

namespace TypingMonkey.Control
{
    /// <summary>
    /// Factory class for Prey Objects 
    /// </summary>
    static class PreyFactory
    {

        /// <summary>
        /// Gets a randomly shuffled DNA EvoString prey.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        /// <remarks>
        /// There's a Typing Monkey inside this factory method! Cool!
        /// </remarks>
        public static IPrey CreateRandomEvoStringPrey(int size)
        {
            TypingMonkey monkey = new TypingMonkey();
            string chromosome = monkey.TypeAway(size);

            return new EvoString(chromosome);
        }

        /// <summary>
        /// Gets an EvoString Prey with given chromosome string.
        /// </summary>
        /// <param name="chromosome"></param>
        /// <returns></returns>
        public static IPrey CreateEvoStringPrey(string chromosome)
        {
            return new EvoString(chromosome);   
        }

    }
}
