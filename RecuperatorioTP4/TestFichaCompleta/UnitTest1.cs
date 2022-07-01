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
            Perro p = new Perro("",7);
            p.Peso = 20;
            p.Raza = "mestizo";
            p.Vacunado = true;
            bool actual;
            //Act
            actual = p.FichaCompleta();
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenEdadEsCero_DebeSerFalse()
        {
            //Arrange
            Perro p = new Perro("Milo",0);
            p.Peso = 20;
            p.Raza = "mestizo";
            p.Vacunado = true;
            bool actual;
            //Act
            actual = p.FichaCompleta();
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenSinRaza_DebeSerFalse()
        {
            //Arrange
            Perro p = new Perro("Milo",7);
            p.Peso = 20;
            p.Raza = "";
            p.Vacunado = true;
            bool actual;
            //Act
            actual = p.FichaCompleta();
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenSinVacunas_DebeSerFalse()
        {
            //Arrange
            Perro p = new Perro("Milo",7);
            p.Peso = 20;
            p.Raza = "mestizo";
            p.Vacunado = false;
            bool actual;
            //Act
            actual = p.FichaCompleta();
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void FichaCompleta_WhenTodoCompleto_DeberiaSerTrue()
        {
            //Arrange
            Perro p = new Perro("Milo",7);
            p.Peso = 20;
            p.Raza = "mestizo";
            p.Vacunado = true;
            bool actual;
            //Act
            actual = p.FichaCompleta();
            //Assert
            Assert.IsTrue(actual);
        }
    }
}
