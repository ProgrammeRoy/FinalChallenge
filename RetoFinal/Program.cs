using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinal
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Agenda de Contactos");
      Console.WriteLine("1. Ver Contactos");
      Console.WriteLine("2. Agregar contactos");
      Console.WriteLine("3. Borrar último contacto");
      Console.WriteLine("4. Buscar contacto por nombre");
      Console.WriteLine("5. Acerca de...");
      Console.WriteLine("6. Salir");
      Console.WriteLine("Seleccionar una opción");

      Contactos C1 = new Contactos("Juan", 985875487, "juan@tumail.com");
      Contactos C2 = new Contactos("Elio", 965465252, "elio@tumail.com");
      Console.WriteLine(C1.ToString());
    }
  }
}
