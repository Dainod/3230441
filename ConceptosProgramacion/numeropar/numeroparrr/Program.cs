
do {
    Console.WriteLine("ingrese el primer numero entero: ");
    var N1= Console.ReadLine(); 
    Console.WriteLine("ingrese el segundo numero entero: ");    
    var N2= Console.ReadLine(); 
    Console.WriteLine( "ingrese el tercer numero entero: ");      
    var N3= Console.ReadLine();

    if (N1 > N2 & N2 > N3)
    {
        Console.WriteLine($"el numero mayor es:{N1}");

    }
    else if (N1 > N3 & N3 > N2)
    {
        Console.WriteLine($"el numero mayor es:{N1}");

    }
    else if (N2 > N1 & N1 > N3)
    {
        Console.WriteLine($"el numero mayor es:{N2}");

    }
    else if (N2 > N3 & N3 > N1)
    {
        Console.WriteLine($"el numero mayor es:{N2}");
    }
    else if (N3 > N1 & N1 > N2)
    { 
    
        Console.WriteLine($"el numero mayor es:{N3}");  
    }
    esle 

}while(true);