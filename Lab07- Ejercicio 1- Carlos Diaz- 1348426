using System;

class Program
{
    static void Main()
    {
        // Entrada
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Proceso + Salida
        Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio 7!");
        int contador = 0; double suma = 0;
        // ---------------- ENTRADAS ----------------
        int N;

        Console.Write("¿Cuántos números desea sumar? ");
        // Lee N y lo convierte a entero 
        N = int.Parse(Console.ReadLine());

        // --------- Verificacion de N (Debe ser  mayor a 0) ---------
        // Mientras N sea menor o igual que 0  se vuelve a pedir el numero 
        while (N <= 0)
        {
            Console.WriteLine("Error: N debe ser mayor que 0.");
            Console.Write("Ingrese nuevamente el valor de N: ");
            N = int.Parse(Console.ReadLine());
        }

        // ---------------- PROCESO ----------------
        // Ciclo WHILE controlado por el contador
        while (contador < N)
        {
            Console.Write("Ingrese el número");

            // Lee el número (puede ser decimal, por eso use double)
            double numero = double.Parse(Console.ReadLine());

            // Acumulamos el número en la suma
            suma += numero;

            // Incrementamos el contador para acercarnos a la salida del ciclo
            contador++;
        }

        // Cálculo del promedio
        double promedio = suma / N;

        // ---------------- SALIDAS ----------------
        Console.WriteLine();
        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("El promedio es: " + promedio);
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
