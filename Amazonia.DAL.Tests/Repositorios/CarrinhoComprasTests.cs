using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazonia.DAL.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazonia.DAL.Entidades;

namespace Amazonia.DAL.Repositorios.Tests
{
    [TestClass()]
    public class CarrinhoComprasTests
    {
        [TestMethod()]
        public void CalcularPrecoCarrinhoLivrosImpressosTest()
        {
            //Arrange
            var livrosFake = new List<Livro>
            {
                new LivroImpresso { Preco = 10, Nome = "Impresso 01" },
                new LivroImpresso { Preco = 20, Nome = "Impresso 02" },
                new LivroImpresso { Preco = 30, Nome = "Impresso 03" }
            };

            var clienteFake = new Cliente();
            var carrinho = new CarrinhoCompras();

            var valorEsperado = 60M;

            //Act
            carrinho.Cliente = clienteFake;
            carrinho.Livros = livrosFake;
            var valorObtido = carrinho.CalcularPreco();

            //Assert
            Assert.AreEqual(valorEsperado, valorObtido);
        }

        [TestMethod()]
        public void CalcularPrecoCarrinhoLivrosDigitaisTest()
        {
            //Arrange
            var livrosFake = new List<Livro>
            {
                new LivroDigital { Preco = 10, Nome = "Digital 01" },
                new LivroDigital { Preco = 20, Nome = "Digital 02" },
                new LivroDigital { Preco = 30, Nome = "Digital 03" }
            };

            var clienteFake = new Cliente();
            var carrinho = new CarrinhoCompras();

            var valorEsperado = 54M;

            //Act
            carrinho.Cliente = clienteFake;
            carrinho.Livros = livrosFake;
            var valorObtido = carrinho.CalcularPreco();

            //Assert
            Assert.AreEqual(valorEsperado, valorObtido);
        }

        [TestMethod()]
        public void CalcularPrecoCarrinhoLivrosDigitaisEImpressosTest()
        {
            //Arrange
            var livrosFake = new List<Livro>
            {
                new LivroDigital { Preco = 10, Nome = "Digital 01" },
                new LivroDigital { Preco = 20, Nome = "Digital 02" },
                new LivroDigital { Preco = 30, Nome = "Digital 03" },
                new LivroImpresso { Preco = 10, Nome = "Impresso 01" },
                new LivroImpresso { Preco = 20, Nome = "Impresso 02" },
                new LivroImpresso { Preco = 30, Nome = "Impresso 03" },
            };

            var clienteFake = new Cliente();
            var carrinho = new CarrinhoCompras();

            var valorEsperado = 114M;

            //Act
            carrinho.Cliente = clienteFake;
            carrinho.Livros = livrosFake;
            var valorObtido = carrinho.CalcularPreco();

            //Assert
            Assert.AreEqual(valorEsperado, valorObtido);
        }

        [TestMethod()]
        public void AplicarDescontoTest()
        {
            //Arrange
            var livrosFake = new List<Livro>
            {
                new LivroImpresso { Preco = 60, Nome = "Impresso 01" },
                new LivroImpresso { Preco = 40, Nome = "Impresso 02" }
            };

            var clienteFake = new Cliente();
            var carrinho = new CarrinhoCompras();

            var valorEsperado = 80M;
            var valorDesconto = 20;
            carrinho.Cliente = clienteFake;
            carrinho.Livros = livrosFake;

            //Act
            var valorObtidoDesconto = carrinho.AplicarDesconto(valorDesconto);

            //Assert
            Assert.AreEqual(valorEsperado, valorObtidoDesconto);
        }
    }
}