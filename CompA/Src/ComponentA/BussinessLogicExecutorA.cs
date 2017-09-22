using System;
using Common;

namespace ComponentA
{
    public class BussinessLogicExecutorA
    {
        public void Test()
        {
            var h = new Helper();
            h.Log("Hello from ComponentA");
        }
    }
}