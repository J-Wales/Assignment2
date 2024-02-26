using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    internal class InvalidInputException : Exception
    {   
            public InvalidInputException() : base("Enter a ToDo item with special characters (Only these are not allowed: @#$%).") { }
        
    }
}
