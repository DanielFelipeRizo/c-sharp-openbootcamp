Console.WriteLine("ingrese el ancho: ");
int ancho = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("ingrese el alto: ");
int alto = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("ingrese si es relleno o no: ");
Boolean relleno = Convert.ToBoolean(Console.ReadLine());


Console.WriteLine("ingrese la cantidad de rectangulos: ");
int cantRectangulos = Convert.ToInt16(Console.ReadLine());

while (cantRectangulos != 0)
{

    cantRectangulos--;

    for (int i = 1; i <= alto; i++)
    {
        if (relleno == true)
        {
            for (int j = 1; j <= ancho; j++)
            {
                Console.Write("*");
            }
        }

        else if (relleno == false)
        {
            if (i == 1 || i == alto)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                for (int j = 1; j <= ancho; j++)
                {
                    if (j == 1 || j == ancho)
                        Console.Write("*");
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        Console.Write("\n");
    }

    Console.Write("\n");
}
