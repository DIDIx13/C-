using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoundTest
{
    [TestClass]
    public class CalculRondTest
    {
        [TestMethod]
        public void InstanceTest()
        {
            Rond rond = new Rond();
            Assert.IsNotNull(rond);
        }

        [TestMethod]
        public void DiametreTest()
        {
            Rond rond = new Rond();
            rond.setRayon(60);

            Assert.AreEqual(120, rond.Diametre());

        }

        [TestMethod]
        public void PerimetreTest()
        {
            Rond rond = new Rond();
            rond.setRayon(60);

            Assert.AreEqual(120, rond.Diametre());

        }
        [TestMethod]
        public void SurfaceTest()
        {
            Rond rond = new Rond();
            rond.setRayon(10);

            Assert.AreEqual(3.1415 * 10 * 10, rond.Surface());

        }
    }
}
