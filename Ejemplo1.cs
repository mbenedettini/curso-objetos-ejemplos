using System;


namespace Ejemplo1
{
    class Cuenta {
        private double saldo;

        public double depositar(double monto) {
            Console.WriteLine("Depositando $" + monto);
            this.saldo = this.saldo + monto;
            return this.saldo;
        }

        public double extraer(double monto) {
            Console.WriteLine("Extrayendo $" + monto);
            this.saldo = this.saldo - monto;
            return this.saldo;
        }


        public void imprimirSaldo() {
            Console.WriteLine("El saldo de la cuenta es de $" + this.saldo);
        }
    }


    /* Codigo necesario para ejecutar el ejemplo */
    class Ejemplo1
    {
        static void Main() 
        {
            Cuenta miCuenta = new Cuenta();
            miCuenta.depositar(100);
            miCuenta.imprimirSaldo();
            miCuenta.depositar(25);
            miCuenta.imprimirSaldo();
            miCuenta.extraer(99.50);
            miCuenta.imprimirSaldo();
        }
    }
}
