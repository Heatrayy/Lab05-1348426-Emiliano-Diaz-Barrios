// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese su nota previa (0 a 100):");
int nota = int.Parse(Console.ReadLine());
if (nota >= 61)
{
    Console.WriteLine("Requisito académico aprobado.");
}
else
{
    Console.WriteLine("Requisito académico NO aprobado.");
}

Console.WriteLine("Minutos de llegada tarde:");
int llegadaTarde = int.Parse(Console.ReadLine());

if (llegadaTarde <= 10)
{
    Console.WriteLine("Hora válida.");
}
else
{
    Console.WriteLine("Llegada tarde: fuera de tiempo.");
}

Console.WriteLine("¿Tiene solvencia de pagos? (1 = Sí, 0 = No):");
int solvencia = int.Parse(Console.ReadLine());

if (solvencia == 1)
{
    Console.WriteLine("Solvencia validada.");
}
else
{
    Console.WriteLine("Sin solvencia.");
}

Console.WriteLine("¿Trae identificación física? (1 = Sí, 0 = No):");
int identificacion = int.Parse(Console.ReadLine());

if (identificacion == 1)
{
    Console.WriteLine("Identificación validada.");
}
else
{
    Console.WriteLine("Sin identificación.");
}

Console.WriteLine("¿Trae calculadora permitida? (1 = Sí, 0 = No):");
int calculadora = int.Parse(Console.ReadLine());

if (calculadora == 1)
{
    Console.WriteLine("Calculadora permitida: OK.");
}
else
{
    Console.WriteLine("Sin calculadora permitida.");
}

if (nota >= 61 && llegadaTarde <= 10 && solvencia == 1 && identificacion == 1)
{
    Console.WriteLine("Acceso a sala de examen concedido.");
}
else
{
    Console.WriteLine("Acceso denegado.");
}

if (llegadaTarde > 0 && llegadaTarde <= 10)
{
    Console.WriteLine("Advertencia: Llegó tarde, pero aún puede ingresar.");
}