class Cuenta:

    def __init__(self):
        self._saldo = 0

    def depositar(self, monto):
        print "Depositando %s" % monto
        self._saldo = self._saldo + monto
        return self._saldo

    def extraer(self, monto):
        print "Extrayendo %s" % monto
        self._saldo = self._saldo - monto
        return self._saldo

    def getSaldo(self):
        return self._saldo

    def imprimirSaldo(self):
        print "El saldo de la cuenta es de %s" % self._saldo


# Codigo necesario para ejecutar el ejemplo
if __name__ == "__main__" :
    miCuenta = Cuenta()
    miCuenta.depositar(100)
    miCuenta.imprimirSaldo()
    miCuenta.depositar(25)
    miCuenta.imprimirSaldo()
    miCuenta.extraer(99.50)
    miCuenta.imprimirSaldo()

    
