
do
{
    Console.WriteLine("ingresa tu nombre:");
    var nom = Console.ReadLine();

    bool doc1 = true;
    do
    {

        Console.WriteLine("ingresa tu documento:");
        var doc = Console.ReadLine();
        if (int.TryParse(doc, out int docint))
        {

            doc1 = true;
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un Documento Valido.");
            doc1 = false;
        }
    } while (doc1 == false);


    bool co= true;
    do
    {
        Console.WriteLine("Elige un Color de esta lista:");
        Console.WriteLine("Rojo");
        Console.WriteLine("Verde");
        Console.WriteLine("Azul");
        Console.WriteLine("Amarillo");
        Console.WriteLine("Naranja");
        Console.WriteLine("Morado");
        Console.WriteLine("Rosa");
        Console.WriteLine("blanco");
        Console.WriteLine("negro");
        Console.WriteLine("majenta");
        var colorse = Console.ReadLine();

        if (colorse == "rojo" || colorse == "verde" || colorse == "azul" || colorse == "amarillo" || colorse == "naranja" || colorse == "morado" || colorse == "rosa" || colorse == "blanco" ||
            colorse == "negro")
        {
            Console.WriteLine($"{nom} tu color Favorito es el {colorse}");
            co = true;
        }

        else if (colorse == "majenta")
        {
            Console.WriteLine($"{nom} tu color Favorito es el Majenta y Recibiras un premio");
            co = true;
        }
        else
        {
            Console.WriteLine($"No es un Color Valido, {nom} por favor ingrese un color de la lista");
            co = false;
        }
    }while(co==false);


} while (true);  