using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypingMonkey
{
    /// <summary>
    /// RQMT_ImplementException - implementing specialized exception class.
    /// Derived from built-in exception.
    /// RQMT_Inheritance - using base class contructor.
    /// </summary>
    class InvalidInputException:Exception
    {
        private const string DEFAULT_MESSAGE = @"Input is invalid";

        public InvalidInputException():base(DEFAULT_MESSAGE)
        { 
            
        }

        /// <summary>
        /// RQMT_Overloading - Demonstrating constructor overloading 
        /// </summary>
        /// <param name="errorMessage"></param>
        public InvalidInputException(string errorMessage):base(errorMessage)
        { 
        
        }
    }
}
