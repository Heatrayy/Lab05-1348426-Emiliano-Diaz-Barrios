// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el código de activación:");
int codigo = int.Parse(Console.ReadLine());
if (codigo == 2026)
{
    Console.WriteLine("Código correcto.");
}
else
{
    Console.WriteLine("Código incorrecto.");
}

Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Edad válida.");
}
else
{
    Console.WriteLine("Edad no válida.");
}

Console.WriteLine("¿Aceptó términos y condiciones? (1 = Sí, 0 = No):");
int terminos = int.Parse(Console.ReadLine());

if (terminos == 1)
{
    Console.WriteLine("Términos aceptados.");
}
else
{
    Console.WriteLine("Debe aceptar términos.");
}

Console.WriteLine("¿Activó 2FA? (1 = Sí, 0 = No):");
int dosFA = int.Parse(Console.ReadLine());

if (dosFA == 1)
{
    Console.WriteLine("2FA activado.");
}
else
{
    Console.WriteLine("2FA no activado.");
}

Console.WriteLine("Ingrese su puntaje de verificación (0 a 100):");
int puntaje = int.Parse(Console.ReadLine());

if (puntaje >= 70)
{
    Console.WriteLine("Puntaje suficiente.");
}
else
{
    Console.WriteLine("Puntaje insuficiente.");
}

if (codigo == 2026 && edad >= 18 && terminos == 1 && dosFA == 1 && puntaje >= 70)
{
    Console.WriteLine("Cuenta activada exitosamente.");
}
else
{
    Console.WriteLine("Cuenta NO activada.");
}
