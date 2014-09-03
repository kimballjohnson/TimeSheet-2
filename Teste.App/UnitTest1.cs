using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Timesheet.DataBase;

namespace Teste.App
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ContextXML xml = new ContextXML();
            Assert.IsTrue(true);
        }
    }
}
