using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class TestB
    {
        public void TestEx()
        {
            var t = new TestA();
            t.TestEx();
        }
    }
}
