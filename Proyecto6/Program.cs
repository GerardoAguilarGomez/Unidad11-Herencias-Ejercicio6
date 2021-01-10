using System;

namespace Proyecto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro L1 = new Libro("2353A", "La reina del sur", "Arturo Pérez Reverte", 348);
            Libro L2 = new Libro("3534l", "Homicidio", "David Simon", 787);
            L1.toString();
            L2.toString();

            if (L1.NumPag1 > L2.NumPag1)
            {
                Console.WriteLine("{0} tiene más páginas: {1}", L1.Titulo1, L1.NumPag1);
            }else if (L2.NumPag1 > L1.NumPag1)
            {
                Console.WriteLine("{0} tiene más páginas: {1}", L2.Titulo1, L2.NumPag1);

            }
            else
            {
                Console.WriteLine("Tienen el mismo número de páginas");

            }
        }
    }
}
