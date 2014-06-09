using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace PruebaUnitaria
{
    /// <summary>
    /// Summary description for UserManagerTest
    /// </summary>
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void CrearAdminTest()
        {

            UserManager.CrearAdmin();
            Usuario u = UserManager.get("admin");
            Assert.IsNotNull(u);
        }

        [TestMethod]
        public void getAllTest()
        {
            List<Usuario> lst = UserManager.getAll();
            Assert.AreEqual(1, lst.Count);

        }
    }
}
