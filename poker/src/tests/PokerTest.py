# -*- coding: utf-8 -*-
'''
Created on 06/03/2012

@author: Evandro

Paus P
Ouro O
Copas C
Espada E

1 - Carta mais alta
2 - Dupla 5C 5D
3 - Duas duplas 3D 3C 9S 9C 
4 - Trinca
5 - Sequencia em naipe 2E 3O 4P 5O
6 - Cinco cartas do mesmo naipe, sem sequencia 2o, 5o, 8o, Vo, Ao
7 - Trinca e Dupla
8 - Quatro cartas mesmo número
5 - Sequencia mesmo naipe 
'''
import unittest
from main.Poker import Poker


class Test(unittest.TestCase):


    def setUp(self):
        self.poker = Poker()


    def tearDown(self):
        pass


    def testCartaMaisAlta(self):
        jogador_1_numero = ('2', '5', '7', '8', '11')
        jogador_2_numero = ('2', '5', '7', '8', '9')
        
        Retorno = self.poker.ValidaJogada(jogador_1_numero, jogador_2_numero)
        assert(Retorno == 1)
    
    def testDupla(self):
        jogador_1_numero = ('2', '7', '7', '8', '9')
        jogador_2_numero = ('5', '5', '7', '8', '11')
        Retorno = self.poker.ValidaJogada(jogador_1_numero, jogador_2_numero)
        print Retorno
        assert(Retorno == 1)
        
if __name__ == "__main__":
    #import sys;sys.argv = ['', 'Test.testName']
    unittest.main()