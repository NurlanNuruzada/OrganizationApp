using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    internal interface Interface1
    {
        public int MyProperty { get; set; }
        public int Number()
        {
            return MyProperty;
        }
    }
}
