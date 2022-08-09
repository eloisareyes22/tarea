// See https://aka.ms/new-console-template for more information
Console.WriteLine("*TAREA*");

double precio, cantidad;
double importe, total, descuento;

Console.WriteLine("Ingrese la cantidad");
cantidad = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio");
precio = double.Parse(Console.ReadLine());

importe = precio * cantidad;
descuento = (0.11 / 100) * importe;
total = importe - descuento;

System.Console.WriteLine("El importe es:" + importe.ToString("0.00"));
System.Console.WriteLine("El descuento es:" + descuento.ToString("0.00"));
System.Console.WriteLine("El total es:" + total.ToString("0.00"));
