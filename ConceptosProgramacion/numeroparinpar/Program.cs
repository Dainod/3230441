do
{
    Console.Write("ingrese un numero:");
    var numero = int.Parse(Console.ReadLine());

    if (numero % 3 == 0)
    {
        Console.WriteLine("Es Par");
    }
    else
    {
        Console.WriteLine("Es Impar");
    }


}while(true);
