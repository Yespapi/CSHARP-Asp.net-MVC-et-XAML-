using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson01;

namespace Lesson01Test
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void PointAddition()
        {
            var sum = 1 + 2;
            var foo = "hello" + "world";
            var bar = foo + sum;

            Console.WriteLine(bar);
            
        }

    }
}
