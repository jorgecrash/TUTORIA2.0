using CapaPresentacion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PruebasFormulario
{
    [TestClass]
    public class PruebasUnitariasLogin
    {
        [TestMethod]
        [DataRow("ana", "ana", true)]
        public void SesionValido( string x, string y , bool expectedResult)
        {
            // 1. Arrange
            Login L = new Login();
            // 2. Act
            bool T = L.logins(x, y);
            //assert
            Assert.AreEqual(expectedResult, T);
        }


        [TestMethod]
        public void SesionValido()
        {
            Login L = new Login();
            //arange
            string usuario = "ana";
            string clave = "ana";
            bool ResultadoEsperado = true;

            //act
            bool T = L.logins(usuario, clave);

            //assert
            Assert.AreEqual(ResultadoEsperado, T);
        }
        [TestMethod]
        public void SesionIncorrectoClave()
        {
            Login L = new Login();
            //arange
            string usuario = "Cata";
            string clave = "lucia";
            bool ResultadoEsperado = false;

            //act
            bool T = L.logins(usuario, clave);

            //assert
            Assert.AreEqual(ResultadoEsperado, T);
        }
        /*
        [TestMethod]
        public void SesionIncorrectoUsuario()
        {
            Login L = new Login();
            //arange
            string usuario = "Maria";
            string clave = "cata";
            bool ResultadoEsperado = false;

            //act
            bool T = L.logins(usuario, clave);

            //assert
            Assert.AreEqual(ResultadoEsperado, T);
        }
        [TestMethod]
        public void SesionIncompletoUsuario()
        {
            Login L = new Login();
            //arange
            string usuario = " ";
            string clave = "cata";
            bool ResultadoEsperado = false;

            //act
            bool T = L.logins(usuario, clave);

            //assert
            Assert.AreEqual(ResultadoEsperado, T);
        }

        [TestMethod]
        public void SesionIncompletoClave()
        {
            Login L = new Login();
            //arange
            string usuario = "Cata";
            string clave = " ";
            bool ResultadoEsperado = false;

            //act
            bool T = L.logins(usuario, clave);

            //assert
            Assert.AreEqual(ResultadoEsperado, T);
        }

        [TestMethod]
        public void SesionIncompleto()
        {
            Login L = new Login();
            //arange
            string usuario = " ";
            string clave = " ";
            bool ResultadoEsperado = false;

            //act
            bool T = L.logins(usuario, clave);

            //assert
            Assert.AreEqual(ResultadoEsperado, T);
        }
        */
    }
   
}
