'''
Created on 06/03/2012

@author: Evandro
'''

class Poker(object):
    '''
    classdocs
    '''


    def __init__(self):
        '''
        Constructor
        '''
    def _converte_para_numero(self, carta):
        if carta == 'J':
            return 11
        elif carta == 'Q':
            return 12
        elif carta == 'K':
            return 13
        elif carta == 'A':
            return 14
        else:
            return carta
    
    
        
    def ValidaJogada(self, jogador_1_numero, jogador_2_numero):
        
        for valor in ['14', '13', '12', '11', '10', '9', '8', '7', '6', '5', '4', '3', '2']:
            count_jogador_1 = jogador_1_numero.count(str(valor))
            count_jogador_2 = jogador_2_numero.count(str(valor))
            if count_jogador_1 > count_jogador_2 and count_jogador_1 > 1:
                return 1
            elif count_jogador_2 > count_jogador_1 and count_jogador_2 > 1:
                return 2

                
        ultimaCartaJogador1 = self._converte_para_numero(jogador_1_numero[4])
        ultimaCartaJogador2 = self._converte_para_numero(jogador_2_numero[4])
        
        if (int(ultimaCartaJogador1) > int(ultimaCartaJogador2)):
            return 1
        elif (int(ultimaCartaJogador2) > int(ultimaCartaJogador1)):
            return 2
        else:
            return 0         
        
