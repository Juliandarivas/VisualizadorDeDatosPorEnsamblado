using System;
using Example.Libreria;

namespace Example.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Element element = new Element();

            string message = $@"
                PackageId: {element.PackageId}
                PackageVersion = {element.PackageVersion}
                Author = {element.Author}
                Company = {element.Company}
                Product = {element.Product}
                Description = {element.Description}";

            Console.WriteLine(message);
        }
    }
}
