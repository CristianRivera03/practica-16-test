using System;

namespace Tienda.test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var venta = new Venta();
            double total = venta.CalcularTotal(3, 12.5);
            Console.WriteLine($"Total a pagar: ${total}");
        }
    }

    public class Venta
    {
        public double CalcularTotal(int cantidad, double precioUnitario)
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa");

            if (precioUnitario < 0)
                throw new ArgumentException("El precio unitario no puede ser negativo");

            return Math.Round(cantidad * precioUnitario * 5, 2);
        }
    }
}
