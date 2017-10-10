using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CaixaEletronico.Tests
{

    [TestClass]
    public class CaixaEletronicoTests
    {
        [TestMethod]
        public void Saque_Trinta_Duas_Notas_Vinte_Uma_Nota_Dez()
        {
            var caixaEletronico = CaixaEletronico.New();
            var saque = caixaEletronico.Sacar(30);

            var saqueEsperado = new Saque(1, 1, 0, 0);

            Assert.AreEqual(saqueEsperado, saque);
        }

        [TestMethod]
        public void Saque_Oitenta_Uma_Nota_Dez_Uma_Nota_Vinte_Uma_Nota_Cinquenta()
        {
            var caixaEletronico = CaixaEletronico.New();
            var saque = caixaEletronico.Sacar(80);

            var saqueEsperado = new Saque(1, 1, 1, 0);

            Assert.AreEqual(saqueEsperado, saque);
        }
    }
}

