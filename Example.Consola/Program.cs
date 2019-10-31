using System;
using Example.Libreria;

namespace Example.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Elemento elemento = new Elemento();

            string mensaje = $@"
                PackageId: {elemento.PackageId}
                PackageVersion = {elemento.PackageVersion}
                Author = {elemento.Author}
                Company = {elemento.Company}
                Product = {elemento.Product}
                Description = {elemento.Description}";

            Console.WriteLine(mensaje);
        }
    }
}
