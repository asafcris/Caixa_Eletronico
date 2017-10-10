using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaixaEletronico.Tests
{
    [TestClass]
    public class SaqueTest
    {

        [TestMethod]
        public void RetornoDeNotas()
        {
            var saque = new Saque(1, 1, 1, 1);

            Assert.AreEqual(1, saque.NotasDeDez);
            Assert.AreEqual(1, saque.NotasDeVinte);
            Assert.AreEqual(1, saque.NotasDeCinquenta);
            Assert.AreEqual(1, saque.NotasDeCem);
        }
    }
}
