﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_ExceptionPracticeProblem
{
    internal class CustomAgeException : Exception
    {
        public CustomAgeException(string message) : base(message)
        {

        }
    }
}
