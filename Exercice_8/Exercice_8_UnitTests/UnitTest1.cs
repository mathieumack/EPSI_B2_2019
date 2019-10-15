using Exercice_8_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercice_8_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculatrice cal = new Calculatrice();
            double resultat = cal.Additionne(10, 22);

            Assert.IsTrue(resultat == 32);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculatrice cal = new Calculatrice();
            double resultat = cal.Additionne(23, 22);

            Assert.IsTrue(resultat == 55);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculatrice cal = new Calculatrice();
            double resultat = cal.Additionne(10, 22);

            Assert.IsFalse(resultat == 20);
        }
    }
}
