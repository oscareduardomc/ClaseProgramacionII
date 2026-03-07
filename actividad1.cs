/*
 1.  Método estático que reciba un nombre y muestre un saludo.
 2.  Método estático que reciba una ciudad y muestre un mensaje indicando dónde vive la persona.
 3.  Método estático que reciba una edad y muestre un mensaje indicando cuántos años tiene la persona.
 4.  Método estático que muestre un mensaje de despedida.
*/

using System;

class Saludo
{
  
    public static void MostrarSaludo(string nombre)
    {
        Console.WriteLine("Hola mi Nombre es " + nombre);
    }

   
    public static void MostrarCiudad(string ciudad)
    {
        Console.WriteLine("Vivo en " + ciudad + ".");
    }

   
    public static void MostrarEdad(int edad)
    {
        Console.WriteLine("Tengo " + edad + " años.");
    }


    public static void MostrarDespedida()
    {
        Console.WriteLine("!Nos vemos pronto!");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Saludo.MostrarSaludo("Dary");
        Saludo.MostrarCiudad("Saba Colon");
        Saludo.MostrarEdad(20.6);
        Saludo.MostrarDespedida();

        Console.ReadLine(); 
    }
}

//¿Por qué no fue necesario crear un objeto para usar los métodos?
//Dado que los métodos fueron declarados como static, no fue necesario 
//generar un objeto. Eso quiere decir que son parte de la clase en sí, no de un 
//objeto. Por eso, es posible utilizarlos llamándolos con el nombre de la clase 
//sin tener que usar new.
