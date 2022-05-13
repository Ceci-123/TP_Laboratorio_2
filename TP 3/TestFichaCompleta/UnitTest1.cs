using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestFichaCompleta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FichaCompleta_WhenSinNombre_DebeSerFalse()
        {
            //Arrange
            Perro p = new Perro("");
            p.Edad = 7;
            p.Peso = 20;
            p.Raza = "mestizo";
            p.Vacunado = true;
            bool expected = false;
            bool actual;
            //Act
            actual = Perro.FichaCompleta(p);
            //Assert
            //Assert.AreEqual(expected, actual);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenEdadEsCero_DebeSerFalse()
        {
            //Arrange
            Perro p = new Perro("Milo");
            p.Edad = 0;
            p.Peso = 20;
            p.Raza = "mestizo";
            p.Vacunado = true;
            bool expected = false;
            bool actual;
            //Act
            actual = Perro.FichaCompleta(p);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenSinRaza_DebeSerFalse()
        {
            //Arrange
            Perro p = new Perro("Milo");
            p.Edad = 7;
            p.Peso = 20;
            p.Raza = "";
            p.Vacunado = true;
            bool expected = false;
            bool actual;
            //Act
            actual = Perro.FichaCompleta(p);
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenSinVacunas_DebeSerFalse()
        {
            //Arrange
            Perro p = new Perro("Milo");
            p.Edad = 7;
            p.Peso = 20;
            p.Raza = "";
            p.Vacunado = false;
            bool expected = false;
            bool actual;
            //Act
            actual = Perro.FichaCompleta(p);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenTodoCompleto_DeberiaSerTrue()
        {
            //Arrange
            Perro p = new Perro("Milo");
            p.Edad = 7;
            p.Peso = 20;
            p.Raza = "";
            p.Vacunado = true;
            bool expected = true;
            bool actual;
            //Act
            actual = Perro.FichaCompleta(p);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
