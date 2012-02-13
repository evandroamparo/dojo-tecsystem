'''
Created on 01/02/2012

@author: Breno
'''
import random

class Teoria(object):
    '''
    classdocs
    '''


    def __init__(self, assassino, local, arma):
        '''
        Constructor
        '''
        self._assassino = assassino
        self._local = local
        self._arma = arma
        
    def validaTeoria(self, assassino, local, arma):
        if ((assassino == self._assassino) and  
            (local == self._local) and (arma == self._arma)):
            return 0       
        elif ((assassino == self._assassino) and  
            (local == self._local) and (arma != self._arma)):
            return 3      
        elif ((assassino != self._assassino) and  
            (local == self._local) and (arma != self._arma)):
            
            return 1 if (random.randint(1, 100) < 50) else 3
       
        elif ((assassino != self._assassino) and  
             (local != self._local) and (arma != self._arma)):
            return random.randint(1, 3)
        elif ((assassino != self._assassino) and  
             (local == self._local) and (arma == self._arma)): 
            return 1 
            