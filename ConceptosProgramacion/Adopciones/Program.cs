 
    Console.WriteLine("Bienvenido al Centro de Adopciones de Animalitos");
    Console.WriteLine("Ingrese su nombre:");
      var Nom = (Console.ReadLine());
    Console.WriteLine("Ingrese su Cedula:");
      var id = int.Parse (Console.ReadLine());
    Console.WriteLine("Acontinuacion elige entre uno de estos Animalitos:");
    Console.WriteLine("1.Perro");
    Console.WriteLine("2.Gato");
    Console.WriteLine("3.Loro");
    Console.WriteLine("4.Pez");
    Console.WriteLine("5.Hanster");
    Console.WriteLine("Eliga un animalito");
    var animal = (Console.ReadLine());
    Console.WriteLine($"Gracias {Nom} de Cedula {id} por adoptar un {animal}, cuidalo mucho");

    