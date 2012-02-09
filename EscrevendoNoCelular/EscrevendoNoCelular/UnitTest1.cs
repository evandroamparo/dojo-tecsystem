using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscrevendoNoCelular
{
   /// <summary>
   /// Summary description for UnitTest1
   /// </summary>
   [TestClass]
   public class UnitTest1
   {
      public UnitTest1()
      {
         //
         // TODO: Add constructor logic here
         //
      }

      private TestContext testContextInstance;

      /// <summary>
      ///Gets or sets the test context which provides
      ///information about and functionality for the current test run.
      ///</summary>
      public TestContext TestContext
      {
         get
         {
            return testContextInstance;
         }
         set
         {
            testContextInstance = value;
         }
      }

      #region Additional test attributes
      //
      // You can use the following additional attributes as you write your tests:
      //
      // Use ClassInitialize to run code before running the first test in the class
      // [ClassInitialize()]
      // public static void MyClassInitialize(TestContext testContext) { }
      //
      // Use ClassCleanup to run code after all tests in a class have run
      // [ClassCleanup()]
      // public static void MyClassCleanup() { }
      //
      // Use TestInitialize to run code before running each test 
      // [TestInitialize()]
      // public void MyTestInitialize() { }
      //
      // Use TestCleanup to run code after each test has run
      // [TestCleanup()]
      // public void MyTestCleanup() { }
      //
      #endregion

      [TestMethod]
      public void DeveRetornar2ParaA()
      {
         Celular celular = new Celular();
         celular.SetMensagem("A");
         var teclas = celular.GetTeclas();
         var resultadoEsperado = "2";
         Assert.AreEqual(resultadoEsperado, teclas);
      }

      [TestMethod]
      public void DeveRetornar22ParaB()
      {
         Celular celular = new Celular();
         celular.SetMensagem("B");
         var teclas = celular.GetTeclas();
         var resultadoEsperado = "22";
         Assert.AreEqual(resultadoEsperado, teclas);
      }

      [TestMethod]
      public void DeveRetornar222ParaC()
      {
         Celular celular = new Celular();
         celular.SetMensagem("C");
         var teclas = celular.GetTeclas();
         var resultadoEsperado = "222";
         Assert.AreEqual(resultadoEsperado, teclas);
      }

      [TestMethod]
      public void DeveRetornar3ParaD()
      {
         Celular celular = new Celular();
         celular.SetMensagem("D");
         var teclas = celular.GetTeclas();
         var resultadoEsperado = "3";
         Assert.AreEqual(resultadoEsperado, teclas);
      }

      [TestMethod]
      public void DeveRetornar5ParaJ()
      {
         Celular celular = new Celular();
         celular.SetMensagem("J");
         var teclas = celular.GetTeclas();
         var resultadoEsperado = "5";
         Assert.AreEqual(resultadoEsperado, teclas);
      }

      [TestMethod]
      public void TesteDojo()
      {
         Celular celular = new Celular();
         celular.SetMensagem("DOJO");
         var teclas = celular.GetTeclas();
         var resultadoEsperado = "36665666";
         Assert.AreEqual(resultadoEsperado, teclas);
      }

      [TestMethod]
      public void TesteTecsystemTecnologiaEmSoftware()
      {
         Celular celular = new Celular();
         celular.SetMensagem("TECSYSTEM TECNOLOGIA EM SOFTWARE");
         var teclas = celular.GetTeclas();
         var resultadoEsperado = "833222777799977778336083322266_6665556664_444203360777766633389277733";
         Assert.AreEqual(resultadoEsperado, teclas);
      }

   }
}
