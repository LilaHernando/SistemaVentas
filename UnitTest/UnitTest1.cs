using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaEntidad;
using CapaNegocio;
using System.Collections.Generic;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            CN_Preventa cN_Preventa = new CN_Preventa();
            List<CE_Preventa> list = cN_Preventa.listar_Preventas();
           
        }
    }
}
