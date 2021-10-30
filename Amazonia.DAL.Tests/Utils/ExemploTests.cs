using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazonia.DAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazonia.DAL.Utils.Tests
{
    [TestClass()]
    [Ignore]
    public class ExemploTests
    {
        [TestMethod()]
        public void ObterValorDoConfigTest()
        {
            //Arrange
            var valorEsperado = "lida do app.config dos testes";

            //Act
            var valorObtidoPeloMetodo = Exemplo.ObterValorDoConfig("chaveExemplo");

            //Assert
            Assert.AreEqual(valorEsperado, valorObtidoPeloMetodo);

        }
    }
}