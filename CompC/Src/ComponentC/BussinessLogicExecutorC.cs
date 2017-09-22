using System;
using Common;
using ComponentA;
using ComponentB;

namespace ComponentC
{
    public class BussinessLogicExecutorC
    {
        public void Test()
        {
            var h = new Helper();
            var compA = new BussinessLogicExecutorA();
            var compB = new BussinessLogicExecutorB();
            
            h.Log("BissinessLogicExecutorC");
            compA.Test();
            compB.Test();
        }
    }
}