﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoresLivrosTest
{
   /// <summary>
   /// Summary description for UnitTest1
   /// </summary>
   [TestClass]
   public class AutoresTest
   {
      public AutoresTest()
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
      public void TestDeveRetornarSILVAJoaoQuandoJoaoSilva()
      {
         Autores autores = new Autores();
         String nome = autores.getNomeFormatado("Joao Silva");
         Assert.AreEqual("SILVA, Joao", nome);
      }

      [TestMethod]
      public void TestDeveRetornarSomenteNome()
      {
         Autores autores = new Autores();
         String nome = autores.getNomeFormatado("Joao");
         Assert.AreEqual("JOAO", nome);
      }

      [TestMethod]
      public void TestJunior()
      {
         Autores autores = new Autores();
         String nome = autores.getNomeFormatado("Joao Silva Junior");
         Assert.AreEqual("SILVA JUNIOR, Joao", nome);
      }

      [TestMethod]
      public void TestPedroJoaoDaSilva()
      {
         Autores autores = new Autores();
         String nome = autores.getNomeFormatado("Pedro Joao da Silva");
         Assert.AreEqual("SILVA, Pedro Joao da", nome);
      }

      [TestMethod]
      public void TestIniciaisMaiusculas()
      {
         Autores autores = new Autores();
         String nome = autores.getNomeFormatado("pedro joao da silva");
         Assert.AreEqual("SILVA, Pedro Joao da", nome);
      }

      [TestMethod]
      public void TestJoaoJunior()
      {
         Autores autores = new Autores();
         String nome = autores.getNomeFormatado("Joao Junior");
         Assert.AreEqual("JUNIOR, Joao", nome);
      }
   }
}
