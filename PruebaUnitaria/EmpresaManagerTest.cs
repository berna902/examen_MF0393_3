using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace PruebaUnitaria
{
    /// <summary>
    /// Summary description for EmpresaManagerTest
    /// </summary>
    [TestClass]
    public class EmpresaManagerTest
    {
        [TestMethod]
        public void NuevaTest()
        {

            Empresa e = new Empresa();
            e.nif = "75721776A";
            e.nombre = "berna";
            bool b = EmpresaManager.Nueva(e);
            Assert.AreEqual(b, true);

            EmpresaManager.Eliminar("75721776A");
        }

        [TestMethod]
        public void EliminarTest()
        {

            Empresa e = new Empresa();
            e.nif = "75721776A";
            e.nombre = "berna";
            EmpresaManager.Nueva(e);
            

            bool b = EmpresaManager.Eliminar("75721776A");
            Assert.AreEqual(b, true);
        }

        [TestMethod]
        public void ModificarTest()
        {
            Empresa e = new Empresa();
            e.nif = "75721776A";
            e.nombre = "berna";
            bool b = EmpresaManager.Modificar(e);
            Assert.AreEqual(b, true);

            e.poblacion = "almeria";
            b = EmpresaManager.Modificar(e);
            Assert.AreEqual(b, true);

            b = EmpresaManager.Modificar(null);
            Assert.AreEqual(b, false);

            EmpresaManager.Eliminar("75721776A");
        }


        [TestMethod]
        public void getTest()
        {
            Empresa e = new Empresa();
            e.nif = "75721776A";
            e.nombre = "berna";
            EmpresaManager.Nueva(e);

            Empresa a = EmpresaManager.get("75721776A");
            Assert.AreEqual(a.nombre, "berna");

            EmpresaManager.Eliminar("75721776A");
        }


    }
}
