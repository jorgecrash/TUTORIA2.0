using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data;
using System.Collections.Generic;
using CapaPresentacion;

namespace PruebasFormulario
{
    /*
    [TestClass]
    public class PruebasMoqDocente
    {
        [TestMethod]
        //---------------------------- test eliminar-----------------------
        public void EliminarDocenteExisteValido()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string CodDocente = "D0001";
            bool Expected = true;
            D.Setup(a => a.eliminar_docente(It.IsAny<string>())).Returns(true);
            bool actual = D.Object.eliminar_docente(CodDocente);
            Assert.AreEqual(actual, Expected);
        }

        //_____________________________________TETS MOQ EDITAR___________________________________//
        [TestMethod]
        public void Editar_docente_codnoValido()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "1";
            string Nombres = "Ana Roci";
            string Apellido = "Cardenas Maita";
            string Titulo = "Magister en Ciencias en Sistemas de Informacion";
            string Facultad = "Facultad de Ingenieria Electrica, Electronica, Informatica y Mecanica";
            string EProfesional = "Ingenieria Informatica y de Sistemas";
            string Categoria = "NOMBRADO";
            bool Expected = false;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0003";
            string Nombres = "Ana Roci";
            string Apellido = "Cardenas Maita";
            string Titulo = "Magister en Ciencias en Sistemas de Informacion";
            string Facultad = "Facultad de Ingenieria Electrica, Electronica, Informatica y Mecanica";
            string EProfesional = "Ingenieria Informatica y de Sistemas";
            string Categoria = "NOMBRADO";
            bool Expected = true;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido_nombreNUll()
        {
            //Pruena
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0003";
            string Nombres = " ";
            string Apellido = "Cardenas Maita";
            string Titulo = "Magister en Ciencias en Sistemas de Informacion";
            string Facultad = "Facultad de Ingenieria Electrica, Electronica, Informatica y Mecanica";
            string EProfesional = "Ingenieria Informatica y de Sistemas";
            string Categoria = "NOMBRADO";
            bool Expected = true;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido_todo_null()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0003";
            string Nombres = " ";
            string Apellido = " ";
            string Titulo = " ";
            string Facultad = " ";
            string EProfesional = " ";
            //no es posible poner null en  categoria por que la interfaz ,no, nos lo permite
            string Categoria = "CONTRATADO";
            bool Expected = true;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_nuLLtodoMenosTitulo()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = " ";
            string Nombres = " ";
            string Apellido = " ";
            string Titulo = "Ingeniero de Minas";
            string Facultad = " ";
            string EProfesional = " ";
            //no es posible poner null en  categoria por que la nterfaz no nos lo permite
            string Categoria = "CONTRATADO";
            bool Expected = false;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido_ApellidosNUll()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0001";
            string Nombres = "Abdon";
            string Apellido = null;
            string Titulo = "Ingeniero de Minas";
            string Facultad = "Facultad de Ingenieria Electrica, Electronica, Informatica y Mecanica";
            string EProfesional = "Ingenieria Informatica y de Sistemas";
            string Categoria = "Nombrado";
            bool Expected = false;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido_TituloNUll()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0002";
            string Nombres = "Ana Rocio";
            string Apellido = "Cardenas Maita";
            string Titulo = null;
            string Facultad = "Facultad de Ingenieria Electrica, Electronica, Informatica y Mecanica";
            string EProfesional = "Ingenieria Informatica y de Sistemas";
            string Categoria = "CONTRATADO";
            bool Expected = false;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido_FacultadyEProfesionalNUll()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0003";
            string Nombres = "Dennis Ivan";
            string Apellido = "Candia Oviedo";
            string Titulo = "Ingeniero Informatico y de Sistemas";
            string Facultad = null;
            string EProfesional = null;
            string Categoria = "Nombrado";
            bool Expected = false;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido_EProfesionalNUll()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0001";
            string Nombres = "Abdon";
            string Apellido = "Ribas Puga";
            string Titulo = "Ingeniero de Minas";
            string Facultad = "Facultad de Ingenieria Electrica, Electronica, Informatica y Mecanica";
            string EProfesional = null;
            string Categoria = "Nombrado";
            bool Expected = false;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }
        [TestMethod]
        public void Editar_docente_codValido_NombreyApellidoNUll()
        {
            Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            string codigo = "D0003";
            string Nombres = null;
            string Apellido = null;
            string Titulo = "Magister en Ciencias en Sistemas de Informacion";
            string Facultad = "Facultad de Ingenieria Electrica, Electronica, Informatica y Mecanica";
            string EProfesional = "Ingenieria Informatica y de Sistemas";
            string Categoria = "NOMBRADO";
            bool Expected = true;
            D.Setup(a => a.Editar_Docente(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            bool actual = D.Object.Editar_Docente(codigo, Nombres, Apellido, Titulo, Facultad, EProfesional, Categoria);
            Assert.AreEqual(actual, Expected);
        }


        //Buscar Docente
        
        [TestMethod]
        public void BuscarDocente()
        {
            //E_Docente edoc = new E_Docente();
            //edoc.Nombres = "Abdon";

            //string busq = "Abdon";
            //Mock<ServiciosDocente> D = new Mock<ServiciosDocente>();
            //int Expected = 1;
            //D.Setup(a => a.SearchDocente(It.IsAny<E_Docente>())).Returns(1);
            //int actual = D.Object.SearchDocente(edoc);
            //Assert.AreEqual(actual, Expected);
        }
        
    }*/
}
