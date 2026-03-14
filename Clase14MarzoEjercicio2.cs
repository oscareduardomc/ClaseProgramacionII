//Ejemplo 2 para clase
using System;

class CuentaBancaria
{
    public readonly string NumeroCuenta; //Solo  puede asignarse en el constructor
    private double saldo; // El saldo no puede modificarse directamente, debe usarse un metodo
    public string Titular;
    internal string Sucursal; //Solo puede usarse dentro del proyecto

    public CuentaBancaria(string numero)
    {
        NumeroCuenta = numero;
        saldo = 0;
    }
    public void Depositar(double monto) //Permite modificar el saldo de forma controlada
    {
        saldo = saldo + monto;
    }
    public void MostrarDatos()
    {
        Console.WriteLine("Cuenta: " + NumeroCuenta);
        Console.WriteLine("Titular: " + Titular);
        Console.WriteLine("Surcursal: " + Sucursal);
        Console.WriteLine("Saldo: " + saldo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria("001-ABC");
        cuenta.Titular = "Oscar Martinez";
        cuenta.Sucursal = "Choluteca";
        cuenta.Depositar(500);
        cuenta.Depositar(200);
        cuenta.MostrarDatos();
        Console.ReadLine();
    }
}
