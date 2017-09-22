using System;
using Common;
using ComponentC;

namespace ComponentD
{
    public class BussinessLogicExecutorD
    {
        public void Test()
        {
            var h = new Helper();
            var compC = new BussinessLogicExecutorC();
            h.Log("BussinessLogicExecutorD");
            compC.Test();
        }
    }
}