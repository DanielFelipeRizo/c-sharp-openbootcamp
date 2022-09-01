//do while

int entradaDoWhile = 1;
int contadorPositivos = 0;
int contadorNegativos = 0;


do
{
	Console.WriteLine("ingrese un numero entero: ");
	entradaDoWhile = Convert.ToInt16(Console.ReadLine());
	if (entradaDoWhile > 0)
	{
		contadorPositivos++;
		Console.WriteLine("van " + contadorPositivos + " numeros positivos");
	}
	else if (entradaDoWhile < 0)
	{
		contadorNegativos++;
		Console.WriteLine("van " + contadorNegativos + " numeros negativos");
	}


} while (entradaDoWhile != 0);
Console.WriteLine("Ingreso el numero cero");
