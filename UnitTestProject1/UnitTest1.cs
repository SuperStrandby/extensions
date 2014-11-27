using System;
using System.Collections.Generic;
using ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelperTest()
        {
            IList<int> list = new[] { 4, 6, 4, 99, 2, 2 };
            String str = list.Concat(", ");
            

            IList<int> list2 = new[] { 4, 6, 4, 99, 2, 2 };
            String str2 = String.Join(", ", list2);
            
            Assert.AreEqual(str, str2);

        }
    }
}
