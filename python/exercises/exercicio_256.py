from abc import ABC , abstractmethod

class Banco(ABC):
    def __init__(self):
        self._ContaCorrente = 0
        self._ContaPoupanca = 0
    
    @property
    def ContaCorrente(self):
        return self._ContaCorrente

    @ContaCorrente.setter
    def ContaPoupanca(self , valor):
        self._ContaCorrente = valor
        




x = Banco


print(x.ContaCorrente)