String[] lenguajesProg = { "C#", "Java", "Python", "JavaScript" };

for (int i = 0; i < lenguajesProg.Length; i++)
{
    Console.WriteLine(i + 1 + ". " + lenguajesProg[i]);
}

try
{
    Console.WriteLine("Seleccione un lenguaje por su numero: ");
    int seleccionado = Convert.ToInt16(Console.ReadLine());


    switch (seleccionado)
    {

        case 1:
            Console.WriteLine("Selecciono el lenguaje: " + lenguajesProg[0]);
            break;

        case 2:
            Console.WriteLine("Selecciono el lenguaje: " + lenguajesProg[1]);
            break;
        case 3:

            Console.WriteLine("Selecciono el lenguaje: " + lenguajesProg[2]);
            break;
        case 4:

            Console.WriteLine("Selecciono el lenguaje: " + lenguajesProg[3]);
            break;

        default:
            Console.WriteLine("no esta en la lista");
            break;

    }

}
catch (Exception)
{
    Console.WriteLine(" Ingreso un tipo de dato incorrecto");

}
