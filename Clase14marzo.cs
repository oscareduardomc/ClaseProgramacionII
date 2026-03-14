using System; //Permite usar herramientas como: Console.WriteLine()

class Inventario //Representa un inventario de Productos
{
    //private significa: solo esta clase puede usarlo
    private string[] productos; //Aqui guardamos los productos

    //Constructor
    public Inventario()
    {
        productos = new string[5]; //Aqui creamos el arreglo de 5 espacios
    }

    //Indexador
    public string this[int index] //Permite usar el objeto como si fuera un arreglo
    {
        get // se ejecuta cuando leemos el valor
        {
            return productos[index];
        }
        set // se ejecuta cuando asignamos un valor
        {
            productos[index] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Inventario inventario = new Inventario(); //Aqui se ejecuta el constructor
        inventario[0] = "Laptop"; // Esto ejecuta el set
        inventario[1] = "Mouse";
        inventario[2] = "Teclado";

        Console.WriteLine("Productos en inventario:");
        Console.WriteLine(inventario[0]); //Esto ejecuta el get
        Console.WriteLine(inventario[1]);
        Console.WriteLine(inventario[2]);
        Console.ReadLine();
    }
}
