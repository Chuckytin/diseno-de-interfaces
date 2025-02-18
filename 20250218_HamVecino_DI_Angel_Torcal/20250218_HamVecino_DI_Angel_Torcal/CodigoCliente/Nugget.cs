public class Nugget
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Cantidad { get; set; }

    public Nugget() { }

    public Nugget(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public Nugget(string nombre, double precio, int cantidad)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Precio:C}";
    }

    public string PedidoString()
    {
        return $"{Cantidad} {Nombre}\nPrecio: {Precio:C}";
    }
}