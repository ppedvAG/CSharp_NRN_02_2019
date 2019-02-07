using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaffeeBibliothek;
using FloatHelper;

namespace KaffeeBibliothekTests
{
    //Attribute
    [TestClass]
    public class KaffeeTests
    {
        [TestMethod]
        public void TestBefüllung()
        {
            PadMaschine padmaschine = new PadMaschine(0.6f);
            padmaschine.FülleWasserEin(0.3f);
            Assert.AreEqual(0.9f, padmaschine.Wasserstand);
        }

        [TestMethod]
        public void TestFloatHelper()
        {
            int z = 2222;
            z = z.Quersumme();
            //Assert.AreEqual(8, z);

            float f1 = 0.0f;
            f1 = f1.Add(0.6f);
            f1 = f1.Add(0.3f);

            Assert.AreEqual(0.9f, f1);

            f1 = f1.Sub(0.4f);
            Assert.AreEqual(0.5f, f1);

        }
    }
}
