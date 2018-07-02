﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinal
{
  class Program
  {
    static ControlAgenda control = new ControlAgenda(new Agenda());

    static void Main(string[] args)
    {
      string opcion = "";

      do
      {
        Console.Clear();
        Console.WriteLine("Agenda de contactos");
        ImprimeMenu();
        opcion = Console.ReadLine();

        switch (opcion)
        {
          case "1":
            control.VerContactos();
            break;
          case "2":
            control.AgregarContato();
            break;
          case "3":
            control.BorrarUltimoContacto();
            break;
          case "4":
            control.BuscarPorNombre();
            break;
          case "5":
            ControlAgenda.AcercaDe();
            break;
          case "6":
            break;
          default:
            Console.WriteLine("Opción no válida");
            break;
        }
      } while (opcion != "6");

    }

    static void ImprimeMenu()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("1. Ver contactos");
      sb.AppendLine("2. Agregar Contacto");
      sb.AppendLine("3. Borrar último contacto");
      sb.AppendLine("4. Buscar contacto por Nombre");
      sb.AppendLine("5. Acerca de ");
      sb.AppendLine("6. Salir");
      sb.Append("Seleccione una opción: ");

      Console.WriteLine(sb.ToString());
    }
  }
}
