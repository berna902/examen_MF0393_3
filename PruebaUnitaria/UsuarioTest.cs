using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;
using System.Security.Cryptography;

namespace PruebaUnitaria
{
    /// <summary>
    /// Summary description for UsuarioTest
    /// </summary>
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void validarTest()
        {
            
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes("aaa111..."));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            string pass = sb.ToString();

            Usuario u = new Usuario();
            u.passwd = pass;

            bool b = u.validar("aaa111...");
            Assert.AreEqual(b, true);
        }
    }
}
