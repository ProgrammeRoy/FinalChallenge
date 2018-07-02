using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinal
{
  //Esta clase nos permite realizar las operaciones sobre la agenda ingresando datos de los contactos, lee los datos ingresados
  class ControlAgenda
  {
    private Agenda _agenda;

    //Constructor
    public ControlAgenda(Agenda agenda)
    {
      _agenda = agenda;
    }

    public void AgregarContato()
    {
      Limpiar();
      Console.WriteLine("Nuevo contacto: ");
      Contactos contacto = new Contactos;
      Console.WriteLine("Nombre: ");
      contacto.Nombre = Console.ReadLine();
      Console.WriteLine("Telefono");
      contacto.Telefono = Console.ReadLine();
      Console.WriteLine("Email: ");
      contacto.Correo = Console.ReadLine();

      _agenda.AgregarContacto(contacto);
      Console.WriteLine("El contacto se agregó correctamente");
      PresionaParaContinuar();
    }

    public void VerContactos()
    {
      //Limpiar la consola
      Limpiar();
      //Mostrar opciones
      MenuMostrar();

      string opcion = Console.ReadLine();

      switch (opcion)
      {
        case "1":
          Console.WriteLine("Contactos orden ascendente");
          _agenda.MostrarOrdenados();
          break;
        case "2":
          Console.WriteLine("Contactos orden descendente");
          _agenda.MostrarOrdenadosDesc();
          break;
        case "3":
          return;
        default:
          Console.WriteLine("Opción no valida");
          break;
      }
      PresionaParaContinuar();
    }
    
    //Método para limpiar consola
    public static void Limpiar()
    {
      Console.Clear();
    }

    //Método para borrar último contacto
    public void BorrarUltimoContacto()
    {
      Limpiar();
      _agenda.BorrarContactos();
      Console.WriteLine("Último contacto borrado exitosamente");
      PresionaParaContinuar();
    }

    //Buscar contacto por nombre
    public void BuscarPorNombre()
    {
      Limpiar();
      Console.WriteLine("Buscar contacto");
      Console.WriteLine("Nombre: ");
      string nombre = Console.ReadLine();

      Contactos contacto = _agenda.BuscarPorNombre(nombre);
      if (contacto != null)
      {
        Console.WriteLine("Datos: \n" + contacto);
      }
      else
      {
        Console.WriteLine("Contacto no encontrado");
      }
      PresionaParaContinuar();
    }

    //Acerda del autor
    public void AcercaDe()
    {
      Limpiar();
      Console.WriteLine("Propietario: Roy Martínez Ramírez");

      PresionaParaContinuar();
    }

    //Método para mostrar Menu
    public void MenuMostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("1. Mostrar orden ascendente");
      sb.AppendLine("2. Mostrar orden descendente");
      sb.AppendLine("3. Volver al menú principal");
      sb.Append("Seleccione una opción: ");

      Console.Write(sb.ToString());
    }

    //Método para hacer la experiencia de usuario más común
    public static void PresionaParaContinuar()
    {
      Console.WriteLine("Presiona cualquier tecla para continuar...");
      Console.ReadKey();
    }
  }
}
