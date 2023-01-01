using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class Dog : Animal
    {
        public override string Say()
        {
            return "旺旺旺";
        }
    }
}
