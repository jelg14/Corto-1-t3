using System;

namespace Corto_1___trimestre_3___José_López
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("                                                 BIENVENIDO");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("Ofertas:");
            Console.WriteLine("--------5% de descuento si su compra es mayor a 5 productos");
            Console.WriteLine("--------10% de descuento si su compra es mayor a 10 productos");
            Console.WriteLine("--------15% de descuento si su compra es mayor a 20 productos");
            Console.WriteLine("--------5% de descuento si su compra es menor o igual a 5 productos pero el total es mayor a Q150.00");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("CATALOGO DE PRODUCTOS");
            Console.WriteLine("N1------ Q100.00");
            Console.WriteLine("N2------ Q300.00");
            Console.WriteLine("N3------ Q50.00");
            Console.WriteLine("N4------ Q500.00");
            Console.WriteLine("N5------ Q30.00");
            Console.WriteLine("N6------ Q75.00");
            Console.WriteLine("Favor ingrese el producto a comprar:");
            string producto = Console.ReadLine();
            Console.WriteLine("Favor ingrese cantidad deseada:");
            int cantidad = int.Parse(Console.ReadLine());

            VentaConDescuento(out double precio,producto,cantidad);
            Console.WriteLine("----------------listado de compra-----------------");
            Console.WriteLine("producto: " + producto + " precio Total: " + precio);
            Console.WriteLine("--------------------------------------------------");
            DescuentoRecibido(cantidad, precio);
        }

       static void VentaConDescuento(out double precio, string producto, int cantidad)
        {
            precio = 0;
            switch (producto)
            {
                case "N1":
                    precio = 100.00F * cantidad;
                    break;

                case "N2":
                    precio = 300.00F * cantidad;
                    break;

                case "N3":
                    precio = 50.00F * cantidad;
                    break;

                case "N4":
                    precio = 500.00F * cantidad;
                    break;

                case "N5":
                    precio = 30.00F * cantidad;
                    break;

                case "N6":
                    precio = 75.00F * cantidad;
                    break;
                default:
                    producto = "el producto ingresado no esta disponible";
                    break;
            }
        }

        static void DescuentoRecibido(int cantidad, double precio)
        {       
            double descuento;
            if (cantidad > 5 && cantidad <=10 ) {
                descuento = precio * 0.05;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**************DETALLE DE COMPRA****************");
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else if (cantidad > 10 && cantidad <= 20) { 
                descuento = precio * 0.1;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("**************DETALLE DE COMPRA****************");
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            else if (cantidad > 20) { 
                descuento = precio * 0.15;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("**************DETALLE DE COMPRA****************");
                Console.ForegroundColor = ConsoleColor.Cyan;

            }
            else if (cantidad <= 5 && precio > 150) { 
                descuento = precio * 0.05;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**************DETALLE DE COMPRA****************");
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else descuento = 0;

            double totalConDescuento = precio-descuento;
            Console.WriteLine(string.Format( "****************TOTAL: {0:C2}",totalConDescuento));
        }
    }
}
