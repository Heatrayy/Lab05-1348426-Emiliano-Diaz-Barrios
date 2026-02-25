// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el PIN:");
int PIN = int.Parse(Console.ReadLine());

if (PIN >= 1000 && PIN <= 9999)
{
    Console.WriteLine("PIN de 4 dígitos: OK.");
}
else
{
    Console.WriteLine("PIN inválido: debe tener 4 dígitos.");
}

if (PIN % 2 == 0)
{
    Console.WriteLine("PIN par.");
}
else
{
    Console.WriteLine("PIN impar.");
}

if (PIN % 5 == 0)
{
    Console.WriteLine("Múltiplo de 5.");
}
else
{
    Console.WriteLine("No es múltiplo de 5.");
}

if (PIN >= 1000 && PIN <= 9999 && PIN % 2 == 0 && PIN % 5 != 0)
{
    Console.WriteLine("PIN aceptado por política.");
}
else
{
    Console.WriteLine("PIN rechazado por política.");
}

