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
    public void AgregarContacto(Contactos contacto)
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

      Console.WriteLine(CadenaContactos(ordenados));
    }

    //Método muestra los contactos Ordenados de forma descendente
    public void MostrarOrdenadosDesc()
    {
      if (NoHayContactos()) { return; }
      Contactos[] ordenados = new Contactos[_index];
      Array.Copy(_contactos, ordenados, _index);
      Array.Sort(ordenados);
      Array.Reverse(ordenados);

      Console.WriteLine(CadenaContactos(ordenados));
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

    //Sobreescritura de toString, servirá para mostrar los datos de los contactos ordenados
    private string CadenaContactos(Contactos[] contactos)
    {
      //Concatena los datos de manera ópotima
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < _index; i++)
      {
        if(_contactos[i] == null) { continue; }

        string dato = string.Format("{0}. {1}", i+1, contactos[i]);
        sb.AppendLine(dato);
      }

      //itera todos los elementos, los convierte en cadena y los muestra
      return sb.ToString();
    }

    //Sobreescribe la cadena
    public override string ToString()
    {
      return CadenaContactos(_contactos); 
    }

    //Una forma de poner nombre más coherente a toString, imprime el ToString
    public void MostrarContactos()
    {
      Console.WriteLine(this);
    }
  }
}
