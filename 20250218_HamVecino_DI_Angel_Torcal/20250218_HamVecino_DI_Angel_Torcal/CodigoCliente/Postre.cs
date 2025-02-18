public class Postre
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Postre() { }

    public Postre(string nombre, double precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Precio:C}";
    }

    public string PedidoString()
    {
        return $"{Nombre}\nPrecio: {Precio:C}";
    }
}