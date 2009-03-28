using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TypingMonkey;
using TypingMonkey.Utility;

namespace TypingMonkey.Entity
{
    /// <summary>
    /// Concrete Prey - in our case is just a common string (fighting for survival!).
    /// RQMT_UsingGenericClass
    /// RQMT_Inheritance
    /// </summary>
    class EvoString:APrey<string>
    {
        // This is a typical std::C++ value for maximum random numbers.
        private const double MAX_RAND = 32767.00;

        public EvoString(string chromosome)
        {
            this.chromosome = chromosome;
        }

        /// <summary>
        /// In Nature there's a pseudo-random chance the newborn chromosomes will mutate...
        /// </summary>
        private void Mutate()
        {
            int marker = Dice.Roll(0, this.chromosome.Length - 1);
            int delta = Dice.Roll(0, this.chromosome.Length - marker);

            TypingMonkey monkey = new TypingMonkey();
            string mutatedGenes = monkey.TypeAway(delta);

            char[] genes = this.chromosome.ToCharArray();

            // Override mutated genes.
            for (int i = 0; i < delta; i++)
            {
                genes[marker++] = mutatedGenes[i]; 
            }

            this.chromosome = new string(genes);
        }

        public override IPrey Mate(IPrey mate)
        {
            string childChromosome = string.Empty;

            EvoString evoStringMate = mate as EvoString;

            if (evoStringMate == null || (this.chromosome.Length != evoStringMate.chromosome.Length))
            {
                throw new Exception("Cross-species mating is not allowed ... yet!");
            }

            // 1. Do chromosome cross-over.
            int chromosomeLenght = this.chromosome.Length;
            int marker = Dice.Roll(0, chromosomeLenght - 1);
            childChromosome = this.chromosome.Substring(0, marker) + evoStringMate.chromosome.Substring(marker, chromosomeLenght - marker); 

            // 2. Spawn child.
            EvoString child = new EvoString(childChromosome);

            // 3. Roll dice to mutate child.
            if (Dice.Roll(0, (int)MAX_RAND) > MAX_RAND * MUTATION_RATE)
            {
                child.Mutate();
            }

            return child;
        }

        /// <summary>
        /// Compares EvoString genetic heritage.
        /// </summary>
        /// <param name="lookAlike"></param>
        /// <returns>Diff between chromosomes, if chromosomes are different in lenght the delta adds up.</returns>
        public int Compare(EvoString lookAlike)
        {
            return StringDistanceCalculator.Levenshtein(this.chromosome, lookAlike.chromosome);
        }

        /// <summary>
        /// Serialize EvoString chromosome.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.chromosome;
        }

        /// <summary>
        /// Clone.
        /// </summary>
        /// <returns>Deep-Copy of the object.</returns>
        public override IPrey Clone()
        {
            return new EvoString(this.chromosome);
        }
    }
}
