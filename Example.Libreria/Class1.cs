using System;
using System.Reflection;

namespace Example.Libreria
{
    public class Elemento
    {
        public string PackageId { get; set; }
        public string PackageVersion { get; set; }
        public string Author { get; set; }
        public string Company { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }

        public Elemento()
        {
            Assembly ensamblado = Assembly.GetEntryAssembly();

            PackageId = ensamblado?.GetCustomAttribute<AssemblyTitleAttribute>().Title;
            PackageVersion = ensamblado?.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            Company = ensamblado?.GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            Product = ensamblado?.GetCustomAttribute<AssemblyProductAttribute>().Product;
            Description = ensamblado?.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
        }
    }
}
