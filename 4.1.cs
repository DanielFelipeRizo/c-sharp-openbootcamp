//While

Console.WriteLine("ingrese el numero de la tabla: ");
int entadaWhile = Convert.ToInt16(Console.ReadLine());
int i = 1;
int mult;

while (i<11)
{
    mult = entadaWhile * i;
    Console.WriteLine(entadaWhile + " x "+ i +" = "+ mult);
    i++;
}
