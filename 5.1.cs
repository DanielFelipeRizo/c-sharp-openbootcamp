String nombre = "";
while (nombre != "salir")
{

    Console.WriteLine("ingrese el nombre: ");
    nombre = Console.ReadLine();

    /*Console.WriteLine("ingrese el email: ");
    String email = Console.ReadLine();
    */
    Console.WriteLine("ingrese el cupon: ");
    String cupon = Console.ReadLine();

    String[] cuponesActivos = { "CUPONDIEZ", "10PORCIEN", "ABC" };

    List<productos> listProductos = new List<productos>()
{
    new productos(){nombreProdcuto = "FRUTAS", precio = 5000},
    new productos(){nombreProdcuto = "VERDURAS", precio = 6000},
    new productos(){nombreProdcuto = "CARNES", precio = 10000}
};

    Double[] ProdConDescuento = { 0, 0, 0 };

    for (int i = 0; i < listProductos.Count; i++)
    {
        ProdConDescuento[i] = listProductos[i].precio - listProductos[i].precio * 0.1;

    }

    int tieneoNo = 0;

    for (int i = 0; i < cuponesActivos.Length; i++)
    {
        if (cupon.ToUpper() == cuponesActivos[i])
        {
            tieneoNo = 1;

        }

    }

    if (tieneoNo == 0)
    {
        Console.WriteLine("El cupon '" + cupon + "' no esta activo");
        Console.WriteLine("Lista de precios: " + listProductos[0].precio + ", " + listProductos[1].precio + ", " + listProductos[2].precio);
    }
    else
    {
        Console.WriteLine("cliente '" + nombre + "' tiene cupon de 10%");
        Console.WriteLine("Lista de precios con descuento: " + ProdConDescuento[0] + ", " + ProdConDescuento[1] + ", " + ProdConDescuento[2]);
    }
    Console.WriteLine("________________________________________________________");
}

class productos
{
    public string nombreProdcuto { get; set; }

    public Double precio { get; set; }
}
