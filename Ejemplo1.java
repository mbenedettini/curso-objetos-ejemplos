class Cuenta {
    private double saldo;

    public double depositar(double monto) {
        System.out.println("Depositando $" + monto);
        this.saldo = this.saldo + monto;
        return this.saldo;
    }

    public double extraer(double monto) {
        System.out.println("Extrayendo $" + monto);
        this.saldo = this.saldo - monto;
        return this.saldo;
    }


    public void imprimirSaldo() {
        System.out.println("El saldo de la cuenta es de $" + this.saldo);
    }
}

/* Codigo necesario para ejecutar el ejemplo */
public class Ejemplo1 {
    public static void main(String args[]) {
        Cuenta miCuenta = new Cuenta();
        miCuenta.depositar(100);
        miCuenta.imprimirSaldo();
        miCuenta.depositar(25);
        miCuenta.imprimirSaldo();
        miCuenta.extraer(99.50);
        miCuenta.imprimirSaldo();
    }
}
