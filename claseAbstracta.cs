//Clases abstractas
using System;

abstract class Figura
{
    public abstract double CalcularArea();
}

class Cuadrado : Figura
{
    public double lado;
    public Cuadrado(double lado)
    {
        this.lado = lado; 
    }
    public override double CalcularArea()
    {
        return lado * lado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figura f = new Cuadrado(5);
        Console.WriteLine("Area: " + f.CalcularArea());
        Console.ReadLine();
    }
}
