class Programa
    
{static void Main()
    {int numero;
        string entrada;
        
        do
        {Console.WriteLine("Teclea un número entre 7 y 22 (o 'salir' para finalizar): ");
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "salir")
            {Console.WriteLine("Saliendo");
                return;}

            if (int.TryParse(entrada, out numero) && numero >= 7 && numero <= 22)
            {ImprimirFibonacci(numero);}
            else
            {Console.WriteLine("No válido, introduce un número entre 7 y 22.");}} 
         while (true);}

    static void ImprimirFibonacci(int numero)
    {int a = 0, b = 1;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Secuencia de Fibonacci:");

        for (int i = 0; i < numero; i++)
        {Console.Write(a + " ");
            int temporal = a;
            a = b;
            b = temporal + b;}

        Console.WriteLine();
        Console.WriteLine("Fibonacci en reverso:");

        a = 0; 
        b = 1;

        for (int i = numero - 1; i >= 0; i--)
        {int valorFib = (i == 0 ? 0 : (i == 1 ? 1 : (b - a)));
            Console.Write(valorFib + " ");
            int temporal = a;
            a = b;
            b = temporal + b;}

        Console.ResetColor();
        Console.WriteLine();}}
