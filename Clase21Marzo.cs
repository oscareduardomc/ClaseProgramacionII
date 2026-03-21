using System;

class Persona //La clase principal (padre)
{
    protected string nombre; //Puede usarse: dentro de la clase, en clases hijas
    protected int edad; //protected = herencia (solo para hijos)

    public Persona(string nombre, int edad) // Inicializa los datos basicos
    {
        this.nombre = nombre; 
        this.edad = edad;
    }
    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}
class Estudiante : Persona
{
    public string carrera;
    public Estudiante(string nombre, int edad, string carrera)
        : base(nombre, edad)
    {
        this.carrera = carrera;
    }
    public void MostrarEtudiante()
    {
        MostrarDatos();
        Console.WriteLine("Carrera: " + carrera);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Estudiante est = new Estudiante("Oscar", 29, "Ingenieria en Sistemas");
        est.MostrarEtudiante();
        Console.ReadLine();
    }
}

//Clase Base | Clase Derivada
//Persona        Estudiante
//Vehiculo        Carro
//Empleado        Gerente

