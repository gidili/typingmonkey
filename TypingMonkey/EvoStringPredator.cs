using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypingMonkey.Entity
{
    /// <summary>
    /// This Predator hunts EvoString Objects
    /// </summary>
    class EvoStringPredator:IPredator
    {
        private EvoString target;

        public EvoStringPredator(EvoString target)
        {
            this.target = target;
        }

        private int EvaluateFitness(EvoString preyEvoString)
        {
            if (preyEvoString == null)
            {
                throw new Exception("Predator doesn't like this prey!");
            }

            return this.target.Compare(preyEvoString);
        }

        #region IFitnessEvaluator Members

        public int EvaluateFitness(IPrey prey)
        {
            return EvaluateFitness(prey as EvoString);
        }

        #endregion

    }
}
