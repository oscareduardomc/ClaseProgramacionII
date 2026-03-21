//Vector
using System;

class Vector
{
    public int x;
    public int y;
    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.x + v2.x, v1.y + v2.y);
    }
    public void Mostrar()
    {
        Console.WriteLine("X: " + x + " Y: " + y);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(2,3);
        Vector v2 = new Vector(4, 5);
        Vector v3 = v1 + v2;
        v3.Mostrar();
        Console.ReadLine();
    }
}
