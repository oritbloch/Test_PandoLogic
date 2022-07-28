using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using classTestFromDB;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetData()
        {
            ClassConsumeFromDB cl = new ClassConsumeFromDB();
            cl.GetData(DateTime.Today.AddDays(-6), DateTime.Today);
            

        }
    }
}
