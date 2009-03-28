using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypingMonkey.Entity
{
    /// <summary>
    ///  RQMT_AbstractClass - an abstract class implements common features.
    ///  RQMT_GenericClass
    ///  This method is very powerful combined with Interfaces.
    /// </summary>
    abstract class APrey<T>:IPrey
    {
        /// <summary>
        /// MUTATION_RATE is common to all our possible preys.
        /// </summary>
        protected const double MUTATION_RATE = 0.25;

        protected T chromosome;

        /// <summary>
        /// Generic method to reset prey chromosome.
        /// RQMT_GenericMethod
        /// </summary>
        /// <param name="newChromosome">New Generic Chromosome.</param>
        public void ResetChromosome(T newChromosome)
        {
            this.chromosome = newChromosome;
        }

        #region IPrey Members

        abstract public IPrey Mate(IPrey mate);

        abstract public IPrey Clone();

        #endregion
    }
}
