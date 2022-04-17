using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class AxisException : Exception
    {
        public AxisException(string message) : base(message) { }
    }

    internal class AngleException : Exception
    {
        public AngleException(string message) : base(message) { }
    }
}
