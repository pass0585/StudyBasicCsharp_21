using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtrributeTestApp;
namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3, b = 5;  
            myClass.Plus()
        }
    }
}
