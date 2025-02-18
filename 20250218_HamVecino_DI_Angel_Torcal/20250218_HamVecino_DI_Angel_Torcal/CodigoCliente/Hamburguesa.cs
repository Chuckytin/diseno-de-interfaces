public class Hamburguesa
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Ingredientes { get; set; }

    public Hamburguesa(string nombre, double precio, string ingredientes)
    {
        Nombre = nombre;
        Precio = precio;
        Ingredientes = ingredientes;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Precio:C} ({Ingredientes})";
    }
}