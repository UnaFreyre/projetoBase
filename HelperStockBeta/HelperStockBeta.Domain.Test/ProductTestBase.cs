using FluentAssertions;
using HelperStockBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Test
{
    #region Casos de testes positivos
    public class CategoryUnitTestBase
    {
        [Fact(DisplayName="product no present id parameter")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, "nome do produto", "descri��o do produto", 5, 1, "imagem produto");
            action.Should().NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "product properties is not null")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, "nome do produto", "descri��o do produto", 5, 1, "imagem produto");
            action.Should().NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }
    #endregion
    #region Casos de testes negativos
        [Fact(DisplayName = "negative id exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(-1, "nome do produto", "descri��o do produto", 5, 1, "imagem produto");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("invalid id, id cannot be negative");
        }
        [Fact(DisplayName = "product name null exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, null, "descri��o do produto", 5, 1, "imagem produto");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("invalid product name, product name cannot be blank");
        }
        [Fact(DisplayName = "short product name exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, "p", "descri��o do produto", 5, 1, "imagem produto");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("invalid product name, product name needs to be at least 3 characters long");
        }
        [Fact(DisplayName = "product description null exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, "nome do produto", null, 5, 1, "imagem produto");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("invalid product description, production description cannot be blank");
        }
        [Fact(DisplayName = "short product description exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, "nome do produto", "d", 5, 1, "imagem produto");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("invalid product description, product description needs to be at least 3 characters long");
        }
        [Fact(DisplayName = "product price negative exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, "nome do produto", "descri��o do produto", -5, 1, "imagem produto");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("invalid price, product price cannot be negative");
        }
        [Fact(DisplayName = "stock number negative exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, "nome do produto", "descri��o do produto", 5, -1, "imagem produto");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("stock number invalid, stock number cannot be negative");
        }
        [Fact(DisplayName = "long image url exception")]
        public void CreateProduct_withParameters_ResultValid()
        {
            Action action = () => new Product(1, null, "descri��o do produto", 5, 1, "ajsifhasioghaosughaosuhaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaadoaushfoaiushfouashfoiashfiaoshgoasihgaiposfjapiduasgihasihdpiashdkslgkasjglkajlkdjasligjasijaisgjasl�dkjask�ljfaslk�jdfkaspogpogpocpococapsopcasopcaospcoaspcoaps");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>().WithMessage("invalid image url, max 250 characters");
        }
    #endregion
    }
}