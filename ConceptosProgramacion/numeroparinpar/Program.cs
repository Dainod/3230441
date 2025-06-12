do
{
    Console.Write("ingrese un numero:");
    var numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("Es Par");
    }
    else
    {
        Console.WriteLine("Es Impar");
    }


}while(true);
Console.WriteLine("ingrese segundo numero:");
var n2 = int.Parse(Console.ReadLine());

if (n1 % n2 == 0)
{
    Console.WriteLine($"{n1} Es multiplo de {n2}");
}
else
{
    Console.WriteLine($"{n1} No es multiplo de {n2}");
}
""
