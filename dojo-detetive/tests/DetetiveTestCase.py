# -*- coding: UTF-8 -*-
'''
Created on 01/02/2012

@author: Breno
'''
from teoria.Detetive import Teoria
import unittest


class Test(unittest.TestCase):
    def setUp(self):
        self._teoria = Teoria(3, 1, 4)


    def tearDown(self):
        pass

    def testRetorna0CasoTeoriaCorreta(self):
        self.assertEqual(0, self._teoria.validaTeoria(3, 1, 4), "Teoria não correta!")


    def testRetorna3ArmaIncorreta(self):
        self.assertEqual(3, self._teoria.validaTeoria(3, 1, 5), "Teoria não correta!")
        
    def testRetorna1ou3SomenteLocalCorreto(self):
        retorno = self._teoria.validaTeoria(2, 1, 1)
        self.assertTrue(retorno in [1, 3], "Teoria não correta!")

    def testRetorna1ou2ou3SeErrouTodos(self):
        retorno = self._teoria.validaTeoria(5, 2, 3)
        self.assertTrue(retorno in [1, 2, 3], "Teoria não correta!")
    
    def testRetorna1AssasinoIncorreto(self):
        self.assertEqual(1, self._teoria.validaTeoria(5, 1, 4), "Teoria não correta!")
          
if __name__ == "__main__":
    #import sys;sys.argv = ['', 'Test.testName']
    unittest.main()
