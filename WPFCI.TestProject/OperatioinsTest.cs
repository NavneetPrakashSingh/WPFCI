using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WPFCI.TestProject
{
    [TestClass]
    public class OperatioinsTest
    {
        Operations operations;
        [TestInitialize]
        public void Setup()
        {
            operations = new Operations();
        }
        [TestMethod]
        public void addTwoNumbers()
        {
            int result = operations.add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
