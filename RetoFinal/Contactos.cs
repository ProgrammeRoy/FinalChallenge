using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinal
{
  class Contactos: IComparable<Contactos>
  {
    public string Nombre { get; set; }
    public int Telefono { get; set; }
    public string Correo { get; set; }

    public Contactos(){ }

    public Contactos(string nombre, int telefono, string correo)
    {
      Nombre = nombre;
      Telefono = telefono;
      Correo = correo;
    }

    public override bool Equals(object obj)
    {
      if(obj == null)
      {
        return false;
      }

      Contactos c = obj as Contactos;
      if(c == null)
      {
        return false;
      }

      return string.Equals(Nombre, c.Nombre) && string.Equals(Telefono, c.Telefono);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        int hashNombre = (Nombre != null ? Nombre.GetHashCode() : 0);
        int hashTelefono = (Telefono != null ? Telefono.GetHashCode() : 0);
        return (hashNombre * 397) ^ (hashTelefono);
      }
    }

    public override string ToString()
    {
      return string.Format("Nombre: {0}, Telfono: {1}. Correo: {2}", Nombre, Telefono, Correo);
    }

    public int CompareTo(Contactos other)
    {
      return Nombre.CompareTo(other.Nombre);
    }
  }
}
