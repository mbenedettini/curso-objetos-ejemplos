<?php
class Cuenta {
    var $saldo = 0;

    public function depositar($monto) {
        print "Depositando $monto\n";
        $this->saldo = $this->saldo + $monto;
        return $this->saldo;
    }

    public function extraer($monto) {
        print "Extrayendo $monto\n";
        $this->saldo = $this->saldo - $monto;
        return $this->saldo;
    }

    public function imprimirSaldo() {
        print "El saldo de la cuenta es de $" . $this->saldo . "\n";
    }

}

$miCuenta = new Cuenta();
$miCuenta->depositar(100);
$miCuenta->imprimirSaldo();
$miCuenta->depositar(25);
$miCuenta->imprimirSaldo();
$miCuenta->extraer(99.50);
$miCuenta->imprimirSaldo();

?>
