using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NotasTests
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
      public void DeveRetornarUmaNotaDeDoisReaisParaDoisReais()
      {
         Caixa caixa = new Caixa();
         Dictionary<int, double> notas = caixa.RetirarValor(2);
         var resultadoEsperado = new Dictionary<int, double>();
         resultadoEsperado[2] = 1;
         Assert.AreEqual(notas[2], resultadoEsperado[2]);
         Assert.AreEqual(notas.Count, 1);

      }

      [TestMethod]
      public void NaoDevePermitirRetiradaDeNotas()
      {
         Caixa caixa = new Caixa();
         Dictionary<int, double> notas = caixa.RetirarValor(3);
         var resultadoEsperado = new Dictionary<int, double>();
         Assert.IsTrue(notas.Count == 0);
      }
   }

   public class Caixa
   {
      public Dictionary<int, double> RetirarValor(int i)
      {
         var notas = new Dictionary<int, double>();
         double valorRestante = i;
         if (i >= 100)
         {
            notas[100] = Math.Truncate(valorRestante / 100);
            valorRestante = valorRestante - notas[100] * 100;
         }
         if (valorRestante >= 50)
         {
            valorRestante = i % 50;
            notas[50] = Math.Truncate(valorRestante / 50);
         }
         if (valorRestante >= 20)
         {
            valorRestante = i % 20;
            notas[50] = Math.Truncate(valorRestante / 20);
         }

         return notas;
      }

   }
}
