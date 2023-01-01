using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Animal
    {
        public virtual string Say()
        {
            return "我是某種動物";
        }
    }
}
