using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Mostrar el menú y obtener la opción del usuario.
            Console.Clear(); // limpiamos la pantalla.
            MostrarMenu(); // llamaos lafuncion del menu.
            string opcion = Console.ReadLine(); // leemos la elecion del usuario.

            switch (opcion)
            {
                case "1":
                    // Validar contraseña
                    Console.Clear(); // borra la pantalla.
                    Console.ForegroundColor = ConsoleColor.Blue; // Aplicamos color al texto.
                    Console.Write("Ingrese la contraseña a validar: ");
                    string contrasena = Console.ReadLine();
                    ValidarContrasena(contrasena);
                    Console.Write("Presiona enter");
                    Console.ResetColor(); // Aplicamos el color preestablecido.
                    Console.ReadKey(); // detiene la pantalla asta presionar una tecla.
                    break;
                case "2":
                    // Calcular y mostrar el Mínimo Común Múltiplo.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red; // Aplicamos color al texto.
                    Console.Write("Ingrese el primer número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"El Mínimo Común Múltiplo es: {MinimoComunMultiplo(num1, num2)}");
                    Console.Write("Presiona enter");
                    Console.ReadKey(); // detiene la pantalla asta presionar una tecla.
                    Console.ResetColor (); // color Preestablecido.
                    break;
                case "3":
                    // Generar y mostrar la Secuencia de Fibonacci.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta; // Aplicamos color al texto.
                    Console.Write("Ingrese la longitud de la secuencia de Fibonacci: ");
                    int longitudFibonacci = Convert.ToInt32(Console.ReadLine());
                    ImprimirSecuenciaFibonacci(longitudFibonacci);
                    Console.Write("Presiona enter");
                    Console.ReadKey(); // detiene la pantalla asta presionar una tecla.
                    Console.ResetColor(); // color preestablecido.
                    break;
                case "4":
                    // Generar y mostrar un número aleatorio en un rango dado.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan; // Aplicamos color al texto.
                    Console.Write("Ingrese el valor mínimo del rango para el número aleatorio: ");
                    int minimo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el valor máximo del rango para el número aleatorio: ");
                    int maximo = Convert.ToInt32(Console.ReadLine());
                    GenerarNumeroAleatorio(minimo, maximo);
                    Console.Write("Presiona enter");
                    Console.ReadKey(); // detiene la pantalla asta presionar una tecla.
                    Console.ResetColor(); // color preestablecido.
                    break;
                case "5":
                    // Calcular y mostrar el factorial de un número.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow; // Aplicamos color al texto.
                    Console.Write("Ingrese un número para calcular su factorial: ");
                    int numeroFactorial = Convert.ToInt32(Console.ReadLine());
                    CalcularFactorial(numeroFactorial);
                    Console.ReadKey(); // detiene la pantalla asta presionar una tecla.
                    Console.Write("Presiona enter");

                    Console.ResetColor();
                    break;
                case "0":
                    // Salir del programa.
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed; // Aplicamos color al texto.
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    Console.ResetColor();
                    return;
                default:
                    // Opción no válida.
                    Console.Clear();
                    Console.WriteLine("Opción no válida. Por favor, elija una opción del menú.");
                    break;
            }

        }
    }
    
    // Función para mostrar el menú.
    static void MostrarMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("|--------------Seleccione una opción:--------------|");
        Console.WriteLine("|              1- Validar Contraseña.              |");
        Console.WriteLine("|              2- Mínimo Común Múltiplo.           |");
        Console.WriteLine("|              3- Secuencia de Fibonacci.          |");
        Console.WriteLine("|              4- Generar Número Aleatorio.        |");
        Console.WriteLine("|              5- Factorial de un Número.          |");
        Console.WriteLine("|              0- Salir.                           |");
        Console.WriteLine("|__________________________________________________|");
        Console.Write("-------------------> ");
        Console.ResetColor();
    }

    // Función para validar la contraseña.
    static void ValidarContrasena(string contrasena)
    {
        // Verificar longitud mínima
        if (contrasena.Length < 8)
        {
            Console.WriteLine("La contraseña no cumple con los requisitos de longitud.");
            return;
        }

        // Verificar letras mayúsculas y minúsculas
        bool tieneMayuscula = false;
        bool tieneMinuscula = false;

        foreach (char c in contrasena)
        {
            if (char.IsUpper(c))
            {
                tieneMayuscula = true;
            }
            else if (char.IsLower(c))
            {
                tieneMinuscula = true;
            }
        }

        // Verificar al menos un carácter especial
        bool tieneCaracterEspecial = false;
        foreach (char c in contrasena)
        {
            if ("!@#$%^&*()_+{}:;<>,.?~".Contains(c))
            {
                tieneCaracterEspecial = true;
                break;
            }
        }

        // Validar y mostrar el resultado
        if (!tieneMayuscula || !tieneMinuscula || !tieneCaracterEspecial)
        {
            Console.WriteLine("La contraseña no cumple con los requisitos de seguridad.");
        }
        else
        {
            Console.WriteLine("La contraseña es válida.");
            Console.WriteLine("Lógica de validación de contraseña aquí...");
        }
    }

    // Función para calcular el Mínimo Común Múltiplo de dos números.
    static int MinimoComunMultiplo(int num1, int num2)
    {
        int maximo = Math.Max(num1, num2);

        while (true)
        {
            if (maximo % num1 == 0 && maximo % num2 == 0)
            {
                return maximo;
            }

            maximo++;
        }
    }

    // Función para imprimir la Secuencia de Fibonacci.
    static void ImprimirSecuenciaFibonacci(int longitud)
    {
        if (longitud <= 0)
        {
            Console.WriteLine("La longitud de la secuencia debe ser un número positivo.");
            return;
        }

        int primerTermino = 0;
        int segundoTermino = 1;

        Console.Write($"Secuencia de Fibonacci de longitud {longitud}: {primerTermino} {segundoTermino}");

        for (int i = 2; i < longitud; i++)
        {
            int siguienteTermino = primerTermino + segundoTermino;
            Console.Write($" {siguienteTermino}");

            primerTermino = segundoTermino;
            segundoTermino = siguienteTermino;
        }

        Console.WriteLine();
    }

    // Función para generar y mostrar un número aleatorio en un rango dado.
    static void GenerarNumeroAleatorio(int minimo, int maximo)
    {
        if (minimo > maximo)
        {
            Console.WriteLine("El valor mínimo no puede ser mayor que el valor máximo.");
            return;
        }

        Random random = new Random();
        Console.WriteLine(random.Next(minimo, maximo + 1));
    }

    // Función para calcular el factorial de un número. 
    static void CalcularFactorial(int numero)
    {
        int factorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}
