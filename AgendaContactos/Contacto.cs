namespace AgendaContactos
{
    public class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Contacto(string nombre)
        {
            Nombre = nombre;
        }
        public Contacto(string nombre, string telefono) : this(nombre)
        { 
            Telefono = telefono;
        }
        public Contacto(string nombre, string telefono, string correo) : this(nombre, telefono)
        {
            Correo = correo;
        }

        public Contacto() { }


        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }

            Contacto con = obj as Contacto;
            if(con == null)
            {
                return false;
            }

            return (Nombre == con.Nombre) && (Telefono == con.Telefono);
        }

        public override int GetHashCode()
        {
            int hash = 3;
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Telefono.GetHashCode();

            return hash;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}\nTelefono: {1}\nCorreo: {2}\n",Nombre,Telefono,Correo);
        }
        public int CompareTo(Contacto? otro)
        {
            return Nombre.CompareTo(otro.Nombre);
        }
    }
}