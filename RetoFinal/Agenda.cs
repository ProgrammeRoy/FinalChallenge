using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinal
{
  //La clase agenda va a almacenar los contactos e implementar las funciones como agregarContacto, borrarContacto... etc
  class Agenda
  {
    //variable que indique el tamaño del arreglo, convenciòn siempre en mayus
    private const int TAM = 10;
    //arreglo, lista de contactos
    private Contactos[] _contactos;
    //indica en que índice del arreglo me encuentro
    private int _index;

    //Indica el número de contactos que tengo almacenado, solo lectura
    public int NumContactos
    {
      get
      {
        return _index;
      }
    }
    //Constructor
    public Agenda()
    {
      _index = 0;
      _contactos = new Contactos[TAM];
    }

    //Método agregar contacto
    public void AgregarContactoa(Contactos contacto)
    {
      if (_index < TAM)
      {
        _contactos[_index] = contacto;
        _index++;
      }
      else
      {
        Console.WriteLine("Agenda llena");
      }
    }

    //Borrar contactos
    public void BorrarContactos()
    {
      if (_index > 0)
      {
        _contactos[_index] = null;
        _index--;
      }
      else
      {
        Console.WriteLine("La agenda ya esta vacía");
      }
    }

    //Método para verificar si hay contactos
    private bool NoHayContactos()
    {
      if (_index == 0)
      {
        Console.WriteLine("No hay contactos");
        return true;
      }
      return false;
    }
    
    //Método muestra los contactos Ordenados
    public void MostrarOrdenados()
    {
      if (NoHayContactos())
      {
        return;
      }
      Contactos[] ordenados = new Contactos[_index];
      Array.Copy(_contactos, ordenados, _index);
      Array.Sort(ordenados);

      Console.WriteLine(ordenados); //Corregir problema
    }

    //Método muestra los contactos Ordenados de forma descendente
    public void MostrarOrdenadosDesc()
    {
      if (NoHayContactos()) { return; }
      Contactos[] ordenados = new Contactos[_index];
      Array.Copy(_contactos, ordenados, _index);
      Array.Sort(ordenados);
      Array.Reverse(ordenados);

      Console.WriteLine(ordenados); //Corregir problema
    }

    //Método para buscar por nombre
    public Contactos BuscarPorNombre(string nombre)
    {
      foreach (Contactos contacto in _contactos)
      {
        if (contacto != null && contacto.Nombre == nombre)
        {
          return contacto;
        }
      }
      return null;
    }


  }
}
