using System;

class Program
{
    static void Main()
    {
        // Llamando a los métodos estáticos sin crear objetos
        Saludo.MostrarSaludo("Carlos");
        Saludo.MostrarCiudad("Tocoa, Colón");
        Saludo.MostrarEdad(20);
        Saludo.MostrarDespedida();
    }
}

class Saludo
{
    // Método estático que recibe un nombre y muestra un saludo
    public static void MostrarSaludo(string nombre)
    {
        Console.WriteLine("¡Hola " + nombre + "! Bienvenido al programa.");
    }

    // Método estático que recibe una ciudad y muestra dónde vive la persona
    public static void MostrarCiudad(string ciudad)
    {
        Console.WriteLine("Vives en: " + ciudad);
    }

    // Método estático que recibe una edad y muestra un mensaje
    public static void MostrarEdad(int edad)
    {
        Console.WriteLine("Tienes " + edad + " años.");
    }

    // Método estático que muestra un mensaje de despedida
    public static void MostrarDespedida()
    {
        Console.WriteLine("¡Gracias por usar el programa! ¡Hasta luego!");
    }
}
