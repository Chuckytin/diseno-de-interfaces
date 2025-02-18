using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

public class Pedido : INotifyPropertyChanged
{

    private static int ultimoId = 0;
    public event PropertyChangedEventHandler PropertyChanged;

    public int Id { get; } = ++ultimoId;
    public DateTime FechaCreacion { get; } = DateTime.Now;
    public double Total => calcularTotal();

    // Listas que contendrán la carta
    public ObservableCollection<Hamburguesa> Hamburguesas { get; set; } = new ObservableCollection<Hamburguesa>();
    public ObservableCollection<Patata> Patatas { get; set; } = new ObservableCollection<Patata>();
    public ObservableCollection<Bebida> Bebidas { get; set; } = new ObservableCollection<Bebida>();
    public ObservableCollection<Nugget> Nuggets { get; set; } = new ObservableCollection<Nugget>();
    public ObservableCollection<Postre> Postres { get; set; } = new ObservableCollection<Postre>();

    // Listas que contendrán el pedido
    public ObservableCollection<Hamburguesa> PedidoHamburguesa { get; set; } = new ObservableCollection<Hamburguesa>();
    public ObservableCollection<Patata> PedidoPatata { get; set; } = new ObservableCollection<Patata>();
    public ObservableCollection<Bebida> PedidoBebida { get; set; } = new ObservableCollection<Bebida>();
    public ObservableCollection<Nugget> PedidoNugget { get; set; } = new ObservableCollection<Nugget>();
    public ObservableCollection<Postre> PedidoPostre { get; set; } = new ObservableCollection<Postre>();

    // Propiedad para mostrar los detalles del pedido
    public string Detalles => obtenerDetalles();

    private string obtenerDetalles()
    {
        var detalles = new StringBuilder();

        // Hamburguesas
        foreach (var hamb in PedidoHamburguesa)
            detalles.AppendLine($"🍔 {hamb.Nombre}: {hamb.Precio:C}");

        // Patatas
        foreach (var patata in PedidoPatata)
            detalles.AppendLine($"🥔 {patata.Nombre}: {patata.Precio:C}");

        // Bebidas
        foreach (var bebida in PedidoBebida)
            detalles.AppendLine($"☕️ {bebida.Nombre}: {bebida.Precio:C}");

        // Nuggets
        foreach (var nugget in PedidoNugget)
            detalles.AppendLine($"🍗 {nugget.Cantidad} nuggets: {nugget.Precio:C}");

        // Postres
        foreach (var postre in PedidoPostre)
            detalles.AppendLine($"🍰 {postre.Nombre}: {postre.Precio:C}");

        return detalles.ToString().TrimEnd('\r', '\n');
    }

    // Métodos para agregar elementos al pedido
    public void AgregarHamburguesa(Hamburguesa hamburguesa)
    {
        PedidoHamburguesa.Add(hamburguesa);
        OnPropertyChanged(nameof(Total));
    }

    public void AgregarPatata(Patata patata)
    {
        PedidoPatata.Add(patata);
        OnPropertyChanged(nameof(Total));
    }

    public void AgregarBebida(Bebida bebida)
    {
        PedidoBebida.Add(bebida);
        OnPropertyChanged(nameof(Total));
    }

    public void AgregarNugget(Nugget nugget)
    {
        PedidoNugget.Add(nugget);
        OnPropertyChanged(nameof(Total));
    }

    public void AgregarPostre(Postre postre)
    {
        PedidoPostre.Add(postre);
        OnPropertyChanged(nameof(Total));
    }

    // Método para calcular el total del pedido
    public double calcularTotal()
    {
        double total = 0;
        foreach (var h in PedidoHamburguesa) total += h.Precio;
        foreach (var p in PedidoPatata) total += p.Precio;
        foreach (var b in PedidoBebida) total += b.Precio;
        foreach (var n in PedidoNugget) total += n.Precio;
        foreach (var po in PedidoPostre) total += po.Precio;
        return total;
    }

    // Método para borrar el pedido
    public void borrarPedido()
    {
        PedidoHamburguesa.Clear();
        PedidoPatata.Clear();
        PedidoBebida.Clear();
        PedidoNugget.Clear();
        PedidoPostre.Clear();
        OnPropertyChanged(nameof(Total));
    }

    // Método para notificar cambios en las propiedades
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // Si cambia cualquier elemento del pedido, actualizamos Detalles
        if (propertyName == nameof(PedidoHamburguesa) ||
            propertyName == nameof(PedidoPatata) ||
            propertyName == nameof(PedidoBebida) ||
            propertyName == nameof(PedidoNugget) ||
            propertyName == nameof(PedidoPostre))
        {
            OnPropertyChanged(nameof(Detalles));
        }
    }

    public override string ToString()
    {
        return $"#{Id} - {FechaCreacion.ToString("dd/MM/yyyy HH:mm")} - Total: {Total:C}";
    }

    /*
    //Iniciamos listas que contendran la carta
    public List<Hamburguesa> Hamburguesas = new List<Hamburguesa>();
    public List<Patata> Patatas = new List<Patata>();
    public List<Bebida> Bebidas = new List<Bebida>();
    public List<Nugget> Nuggets = new List<Nugget>();
    public List<Postre> Postres = new List<Postre>();
    //Iniciamos listas que contendran el pedido
    public List<Hamburguesa> PedidoHamburguesa = new List<Hamburguesa>();
    public List<Patata> PedidoPatata = new List<Patata>();
    public List<Bebida> PedidoBebida = new List<Bebida>();
    public List<Nugget> PedidoNugget = new List<Nugget>();
    public List<Postre> PedidoPostre = new List<Postre>();

    // Métodos para agregar elementos al pedido
    public void AgregarHamburguesa(Hamburguesa hamburguesa)
    {
        PedidoHamburguesa.Add(hamburguesa);
    }

    public void AgregarPatata(Patata patata)
    {
        PedidoPatata.Add(patata);
    }

    public void AgregarBebida(Bebida bebida)
    {
        PedidoBebida.Add(bebida);
    }

    public void AgregarNugget(Nugget nugget)
    {
        PedidoNugget.Add(nugget);
    }

    public void AgregarPostre(Postre postre)
    {
        PedidoPostre.Add(postre);
    }

    public void MostrarHamburguesas()
    {
        //Variables
        int cont = 1;
        int opcion;

        Console.WriteLine("---------------------------------");
        foreach (var h in Hamburguesas)
        {

            Console.WriteLine(cont + ". " + h.ToString());
            Console.WriteLine("*********************************");
            cont++;
        }
        Console.WriteLine("0. Volver a inicio");
        Console.WriteLine("---------------------------------");
        do
        {
            Console.Write("Introduce una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion > Hamburguesas.Count)
            {
                Console.WriteLine("Introduzca una opcion valida!");
            }
            else if (opcion > 0 && opcion <= Hamburguesas.Count)
            {
                //Aqui seleccionamos la hamburgues en la List restando 1 a la opcion
                int hamburguesa = opcion - 1;
                PedidoHamburguesa.Add(Hamburguesas[hamburguesa]);
                Console.WriteLine(Hamburguesas[hamburguesa].Nombre + " añadida!");
                opcion = 0;
            }

        } while (opcion != 0);

    }

    public void mostrarPatatas()
    {
        //Variables
        int cont = 1;
        int opcion;
        //Mostramos las patatas de la carta
        Console.WriteLine("---------------------------------");
        foreach (var p in Patatas)
        {

            Console.WriteLine(cont + ". " + p.Tipo);
            cont++;
        }
        Console.WriteLine("0. Volver a inicio");
        Console.WriteLine("---------------------------------");
        //Seleccionamos tipo de patatas
        do
        {
            Console.Write("Introduce una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            //Si elegimos patatas, elegimos tamaño
            if (opcion > 0 && opcion <= Patatas.Count)
            {
                //Variables
                int opcion2;
                int patata = opcion - 1;
                Patata seleccion;

                Console.WriteLine("-------------Tamaño-------------");
                Console.WriteLine("1. Pequeñas > 1.49 euros");
                Console.WriteLine("2. Medianas > 1.99 euros");
                Console.WriteLine("3. Grandes > 2.99 euros");
                Console.WriteLine("0. Cancelar");
                Console.WriteLine("---------------------------------");

                do
                {
                    Console.Write("Introduce una opcion: ");
                    opcion2 = int.Parse(Console.ReadLine());

                    //Ahora añadiremos las patatas con el tamaño
                    switch (opcion2)
                    {
                        case 1:
                            seleccion = new Patata(Patatas[patata].Tipo, 1.49, "Pequeñas");
                            PedidoPatata.Add(seleccion);
                            Console.WriteLine("Patatas añadidas!");
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        case 2:
                            seleccion = new Patata(Patatas[patata].Tipo, 1.99, "Medianas");
                            PedidoPatata.Add(seleccion);
                            Console.WriteLine("Patatas añadidas!");
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        case 3:
                            seleccion = new Patata(Patatas[patata].Tipo, 2.99, "Grandes");
                            PedidoPatata.Add(seleccion);
                            Console.WriteLine("Patatas añadidas!");
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        case 0:
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        default:
                            Console.WriteLine("Introduzca una opcion válida!");
                            break;
                    }

                } while (opcion2 != 0);

            }
            else if (opcion == 0)
            {
                opcion = 0;
            }
            else
            {
                Console.WriteLine("Introduzca una opcion valida!");
            }

        } while (opcion != 0);
    }

    /*
    public void mostrarBebidas()
    {
        //Variables
        int cont = 1;
        int opcion;
        //Mostramos las bebidas de la carta
        Console.WriteLine("---------------------------------");
        foreach (var b in Bebidas)
        {

            Console.WriteLine(cont + ". " + b.Nombre);
            cont++;
        }
        Console.WriteLine("0. Volver a inicio");
        Console.WriteLine("---------------------------------");
        //Seleccionamos bebida
        do
        {
            Console.Write("Introduce una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            //Si elegimos bebida, elegimos tamaño
            if (opcion > 0 && opcion <= Bebidas.Count)
            {
                //Variables
                int opcion2;
                int bebida = opcion - 1;
                Bebida seleccion;

                Console.WriteLine("-------------Tamaño-------------");
                Console.WriteLine("1. Pequeño > 1.99 euros");
                Console.WriteLine("2. Mediano > 2.99 euros");
                Console.WriteLine("3. Grande > 3.49 euros");
                Console.WriteLine("0. Cancelar");
                Console.WriteLine("---------------------------------");

                do
                {
                    Console.Write("Introduce una opcion: ");
                    opcion2 = int.Parse(Console.ReadLine());

                    //Ahora añadiremos la bebida con el tamaño
                    switch (opcion2)
                    {
                        case 1:
                            seleccion = new Bebida(Bebidas[bebida].getNombre(), 1.99, "Pequeño");
                            PedidoBebida.Add(seleccion);
                            Console.WriteLine("Bebida añadida!");
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        case 2:
                            seleccion = new Bebida(Bebidas[bebida].getNombre(), 2.99, "Mediano");
                            PedidoBebida.Add(seleccion);
                            Console.WriteLine("Bebida añadida!");
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        case 3:
                            seleccion = new Bebida(Bebidas[bebida].getNombre(), 3.49, "Grande");
                            PedidoBebida.Add(seleccion);
                            Console.WriteLine("Bebida añadida!");
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        case 0:
                            opcion = 0;
                            opcion2 = 0;
                            break;
                        default:
                            Console.WriteLine("Introduzca una opcion válida!");
                            break;
                    }

                } while (opcion2 != 0);

            }
            else if (opcion == 0)
            {
                opcion = 0;
            }
            else
            {
                Console.WriteLine("Introduzca una opcion valida!");
            }

        } while (opcion != 0);
    }

    public void mostrarNuggets()
    {
        //Variables
        int cont = 1;
        int opcion;

        Console.WriteLine("---------------------------------");
        foreach (var n in Nuggets)
        {

            Console.WriteLine(cont + ". " + n.ToString());
            cont++;
        }
        Console.WriteLine("0. Volver a inicio");
        Console.WriteLine("---------------------------------");
        do
        {
            Console.Write("Introduce una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion > Nuggets.Count)
            {
                Console.WriteLine("Introduzca una opcion valida!");
            }
            else if (opcion > 0 && opcion <= Nuggets.Count)
            {
                //Variables 
                int cantidad;
                int nugget = opcion - 1;
                Nugget seleccion;

                Console.WriteLine("---------------------------------");
                Console.Write("Cantidad: ");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad > 0)
                {
                    //Calculamos el precio de todas las unidades y añadimos
                    double precio = Nuggets[nugget].Precio * cantidad;
                    seleccion = new Nugget(Nuggets[nugget].Nombre, precio, cantidad);
                    PedidoNugget.Add(seleccion);
                    Console.WriteLine("Nuggets añadidos!");
                    opcion = 0;
                }
                else
                {
                    Console.WriteLine("Introduzca una opcion valida!");
                }
            }

        } while (opcion != 0);

    }

    public void mostrarPostres()
    {
        //Variables
        int cont = 1;
        int opcion;

        Console.WriteLine("---------------------------------");
        foreach (var po in Postres)
        {

            Console.WriteLine(cont + ". " + po.ToString());
            cont++;
        }
        Console.WriteLine("0. Volver a inicio");
        Console.WriteLine("---------------------------------");
        do
        {
            Console.Write("Introduce una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion > 0 && opcion <= Postres.Count)
            {
                //Variables 
                int cantidad;
                int postre = opcion - 1;

                PedidoPostre.Add(Postres[postre]);
                Console.WriteLine("Postre añadido!");
                opcion = 0;
            }
            else if (opcion == 0)
            {
                opcion = 0;
            }
            else
            {
                Console.WriteLine("Introduzca una opcion valida!");
            }

        } while (opcion != 0);

    }
    

    // Método para calcular el total del pedido
    public double calcularTotal()
    {
        double total = 0;
        foreach (var h in PedidoHamburguesa) total += h.Precio;
        foreach (var p in PedidoPatata) total += p.Precio;
        foreach (var b in PedidoBebida) total += b.Precio;
        foreach (var n in PedidoNugget) total += n.Precio;
        foreach (var po in PedidoPostre) total += po.Precio;
        return total;
    }

    
    public void mostrarPedido()
    {
        Console.WriteLine("---------------------------------");
        if (PedidoHamburguesa.Count > 0)
        {
            foreach (var h in PedidoHamburguesa)
            {
                Console.WriteLine(h.ToString());
                Console.WriteLine("=================================");
            }
        }

        if (PedidoPatata.Count > 0)
        {
            foreach (var p in PedidoPatata)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("=================================");
            }
        }

        if (PedidoBebida.Count > 0)
        {
            foreach (var b in PedidoBebida)
            {
                Console.WriteLine(b.ToString());
                Console.WriteLine("=================================");
            }
        }

        if (PedidoNugget.Count > 0)
        {
            foreach (var n in PedidoNugget)
            {
                Console.WriteLine(n.pedidoString());
                Console.WriteLine("=================================");
            }
        }

        if (PedidoPostre.Count > 0)
        {
            foreach (var po in PedidoPostre)
            {
                Console.WriteLine(po.pedidoString());
                Console.WriteLine("=================================");
            }
        }

        if (calcularTotal() > 0)
        {
            Console.WriteLine(".................................");
            Console.WriteLine("Total: " + calcularTotal() + " euros");
        }
        else
        {
            Console.WriteLine("Nada que mostrar");
        }
        Console.WriteLine("---------------------------------");


    }
    */

    /*
    public void borrarPedido()
    {
        //Variables
        int opcion;
        bool valido = calcularTotal() > 0;

        if (valido)
        {

            Console.WriteLine("---------------------------------");
            Console.WriteLine("¿Desea borrar el pedido?");
            Console.WriteLine("1. Si    2. No");

            do
            {

                Console.Write("Introduzca opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    PedidoHamburguesa.Clear();
                    PedidoPatata.Clear();
                    PedidoBebida.Clear();
                    PedidoNugget.Clear();
                    PedidoPostre.Clear();
                    Console.WriteLine("Pedido borrado");
                    opcion = 2;
                }

            } while (opcion != 2);
        }
    }
    

    // Método para borrar el pedido
    public void borrarPedido()
    {
        PedidoHamburguesa.Clear();
        PedidoPatata.Clear();
        PedidoBebida.Clear();
        PedidoNugget.Clear();
        PedidoPostre.Clear();
    }

    public void confirmarPedido()
    {
        //Varibles
        int opcion;
        bool valido = calcularTotal() > 0;

        if (valido)
        {

            Console.WriteLine("---------------------------------");
            Console.WriteLine("El pedido total son " + calcularTotal() + " euros");
            Console.WriteLine("¿Desea confirmar el pedido?");
            Console.WriteLine("1. Si    2. No");

            do
            {
                Console.Write("Introduzca opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {

                    Console.WriteLine("<<<<<+ PEDIDO TERMINADO +>>>>");
                    Environment.Exit(0);

                }

            } while (opcion != 2);

        }
        else
        {
            Console.WriteLine("Realice un pedido primero");
        }
    }
    */
}