using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnet_factorial.recursive;
using dotnet_factorial.iterative;

namespace dotnet_factorial.unittests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual(362880, recursivefunctions.factorial (9));
            Assert.AreEqual(362880, recursivefunctions.factorial_tr(9));
            Assert.AreEqual(362880, iterativefunctions.factorial_it(9));

            Assert.AreEqual(7.257415615307994e+306, recursivefunctions.factorial(170));
            Assert.AreEqual(7.257415615308004e+306, recursivefunctions.factorial_tr(170));
            Assert.AreEqual(7.257415615308004e+306, iterativefunctions.factorial_it(170));
        }
    }
}
