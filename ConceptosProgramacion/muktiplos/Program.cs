do
{
Console.WriteLine("ingrese primer numero:");
var n1 = (Console.ReadLine());

    if (int.TryParse(n1, out int n1int))
     
    {
        Console.WriteLine("ingrese segundo numero:");
        var n2 = (Console.ReadLine());
       
        if (int.TryParse(n2, out int n2int))
        {
            if (n1int % n2int == 0)
            {
                Console.WriteLine($"{n2} Es multiplo de {n1}");
            }
            else
            {
                Console.WriteLine($"{n2}, no es multiplo de: {n1}");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un numero valido.");
        }
    }
    else
    {

        Console.WriteLine("Por favor, ingrese un numero valido.");

    }
    


} while (true);