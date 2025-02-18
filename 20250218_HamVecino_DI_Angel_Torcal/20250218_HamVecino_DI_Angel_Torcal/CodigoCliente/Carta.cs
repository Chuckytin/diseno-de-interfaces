public class Carta
{
    public void CargarCarta(Pedido pedido)
    {
        // Hamburguesas
        var hamburguesa1 = new Hamburguesa("Hamburguesa Simple", 3.99, "Una carne, lechuga, tomate, queso");
        pedido.Hamburguesas.Add(hamburguesa1);

        var hamburguesa2 = new Hamburguesa("Hamburguesa Doble", 5.49, "Dos carnes, lechuga, tomate, queso, bacon");
        pedido.Hamburguesas.Add(hamburguesa2);

        var hamburguesa3 = new Hamburguesa("Hamburguesa Especial", 7.99, "Dos carnes, queso cheddar, bacon, cebolla caramelizada, salsa especial");
        pedido.Hamburguesas.Add(hamburguesa3);

        // Patatas
        var patata1 = new Patata("Normales");
        pedido.Patatas.Add(patata1);

        var patata2 = new Patata("Deluxe");
        pedido.Patatas.Add(patata2);

        // Bebidas
        var bebida1 = new Bebida("Refresco");
        pedido.Bebidas.Add(bebida1);

        var bebida2 = new Bebida("Agua");
        pedido.Bebidas.Add(bebida2);

        var bebida3 = new Bebida("Cerveza");
        pedido.Bebidas.Add(bebida3);

        // Nuggets
        var nugget1 = new Nugget("Nugget de pollo", 0.80);
        pedido.Nuggets.Add(nugget1);

        var nugget2 = new Nugget("Nugget vegetal", 1.20);
        pedido.Nuggets.Add(nugget2);

        // Postres
        var postre1 = new Postre("Helado", 3.99);
        pedido.Postres.Add(postre1);

        var postre2 = new Postre("Manzana", 1.49);
        pedido.Postres.Add(postre2);
    }
}

