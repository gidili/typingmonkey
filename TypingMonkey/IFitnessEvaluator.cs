using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypingMonkey.Entity
{
    /// <summary>
    /// Contract that allows an object to evaluate IPrey fitness
    /// </summary>
    interface IFitnessEvaluator
    {
        /// <summary>
        /// Evaluates given prey fitness.
        /// </summary>
        /// <param name="prey"></param>
        /// <returns></returns>
        int EvaluateFitness(IPrey prey);
    }
}
