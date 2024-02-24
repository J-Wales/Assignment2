using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
	internal class NonNumericInputException : Exception
	{
		public NonNumericInputException() : base("Please enter valid numbers.") { }
	}
}
