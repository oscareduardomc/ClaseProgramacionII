using System;

class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
}
class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Perro();
        Animal a2 = new Gato();
        a1.HacerSonido();
        a2.HacerSonido();
        Console.ReadLine();
    }
}

