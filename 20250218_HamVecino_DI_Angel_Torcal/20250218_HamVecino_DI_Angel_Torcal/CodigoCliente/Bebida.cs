public class Bebida
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Size { get; set; }

    public Bebida() { }

    public Bebida(string nombre)
    {
        Nombre = nombre;
    }

    public Bebida(string nombre, double precio, string size)
    {
        Nombre = nombre;
        Precio = precio;
        Size = size;
    }

    public override string ToString()
    {
        return $"{Nombre} {Size}\nPrecio: {Precio:C}";
    }
}