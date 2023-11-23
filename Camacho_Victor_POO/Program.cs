// See https://aka.ms/new-console-template for more information
using Camacho_Victor_POO;

Empleado empleado1 = new Empleado("Juan", 50000);
Gerente gerente1 = new Gerente("Ana", 80000, "Ventas");

// Mostrar información utilizando polimorfismo
Console.WriteLine("Información del Empleado:");
empleado1.MostrarInfo();

Console.WriteLine("\nInformación del Gerente:");
gerente1.MostrarInfo();