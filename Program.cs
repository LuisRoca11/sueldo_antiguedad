// De un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe:
//a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
//b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
//c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.

using System;

namespace sueldo_antiguedad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su antiguedad(años): ");
            double antiguedad = double.Parse(Console.ReadLine());

            if (sueldo < 500 && antiguedad > 10)
            {
                sueldo = (sueldo + (sueldo * 0.2));
                Console.WriteLine($"Usted recibio un aumento del 20% y su sueldo es: {sueldo}");
            }
            else if (sueldo<500 && antiguedad<10)
            {
                sueldo = (sueldo + (sueldo * 0.05));
                Console.WriteLine($"Usted recibio un aumento del 5% y su sueldo es: {sueldo}");
            }
            else if (sueldo>=500)
            {
                Console.WriteLine($"Usted no recibio aumento y su sueldo es: {sueldo}");
            }


            Console.ReadKey(); 
        }
    }
}
