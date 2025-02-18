public class Patata
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Tamano { get; set; }

    public Patata() { }

    public Patata(string tipo)
    {
        Nombre = tipo;
    }

    public Patata(string tipo, double precio, string size)
    {
        Nombre = tipo;
        Precio = precio;
        Tamano = size;
    }

    public override string ToString()
    {
        return $"Patatas {Nombre} {Tamano}\nPrecio: {Precio:C}";
    }
}