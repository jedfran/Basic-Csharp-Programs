using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryandCatch_Assignment_2
{
    public class WrongAge : Exception
    {
        public WrongAge()
            :base() { }
        public WrongAge(string message)
            :base(message) { }
    }
}
