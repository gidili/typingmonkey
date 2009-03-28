using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypingMonkey
{
    /// <summary>
    /// Derived from built-in exception.
    /// </summary>
    class InvalidInputException:Exception
    {
        private const string DEFAULT_MESSAGE = @"Input is invalid";

        public InvalidInputException():base(DEFAULT_MESSAGE)
        { 
            
        }

        /// <summary>
        /// Constructor overloading 
        /// </summary>
        /// <param name="errorMessage"></param>
        public InvalidInputException(string errorMessage):base(errorMessage)
        { 
        
        }
    }
}
