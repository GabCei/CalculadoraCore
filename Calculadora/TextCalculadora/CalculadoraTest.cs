using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextCalculadora
{
    [TestClass]
    public class CalculadoraTest
    {
        int numero1;
        int numero2;

        Core.Calculadora calculadora;

        [TestInitialize]
        public void InicializarTest()
        {
            this.calculadora = new Core.Calculadora();
            this.numero1 = 4;
            this.numero2 = 5;
        }

        [TestMethod]

        public void Suma()
        {
            //Arrange
            int suma = 0;
            //Act
            suma = calculadora.Suma(numero1, numero2);
            //Assert
            Assert.IsTrue(suma.Equals(9));

        }

        [TestMethod]

        public void Negativos()
        {
            //Arrange
            int sumaNeg = 0;
            //Act
            sumaNeg = calculadora.Suma(-1, -2);
            //Assert
            Assert.IsTrue(sumaNeg.Equals(-3));
        }
    }
}
