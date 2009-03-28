using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TypingMonkey;

namespace TypingMonkey
{
    /// <summary>
    /// Input Validator class is responsible for validating MainForm input.
    /// </summary>
    public class InputValidator
    {
        /// <summary>
        /// A few constants.
        /// </summary>
        private const int MAX_INPUT_TEXT_LENGTH = 150;
        private const int MIN_INPUT_TEXT_LENGTH = 3;
        private const int MAX_POPULATION_SIZE = 500000;
        private const int MIN_POPULATION_SIZE = 10;

        public InputValidator()
        {

        }

        /// <summary>
        /// Validates Input Parameters.
        /// </summary>
        /// <param name="populationSize"></param>
        /// <param name="inputText"></param>
        /// <returns>
        /// A list of booleans to indicate if any input field failed validation.
        /// </returns>
        ///<remarks>
        /// Return type is not ideal (not type-safe and slower) but it was coded this way to demostrate boxing/unboxing.
        /// </remarks>
        public List<Object> ValidateInput(int populationSize, string inputText)
        {
            // Initialize return list with false.
            List<Object> returnList = new List<object>(2);

            returnList.Add(false);
            returnList.Add(false);

            if (populationSize < MAX_POPULATION_SIZE && populationSize > MIN_POPULATION_SIZE)
            {
                returnList[(int)InputType.PopulationSize] = true;
            }

            if (inputText.Length < MAX_INPUT_TEXT_LENGTH && inputText.Length > MIN_INPUT_TEXT_LENGTH)
            {
                returnList[(int)InputType.InputText] = true;
            }

            return returnList;
        }

        /// <summary>
        /// Public getters for validation constants.
        /// </summary>
        public int MaxInputText
        {
            get
            {
                return MAX_INPUT_TEXT_LENGTH;
            }
        }

        public int MinInputText
        {
            get
            {
                return MIN_INPUT_TEXT_LENGTH;
            }
        }

        public int MaxPopulationSize
        {
            get
            {
                return MAX_POPULATION_SIZE;
            }
        }

        public int MinPopulationSize
        {
            get
            {
                return MIN_POPULATION_SIZE;
            }
        }
    }
}
