using System.Text;

namespace AgendaContactos
{
    class Agenda 
    {
        private const int TAM = 20;
        private Contacto[] _contactos;
        private int _index;
        
        public int NumContactos
        {
            get
            {
                return _index;
            }
        }
        
        public Agenda()
        {
            _index = 0;

            _contactos = new Contacto[TAM];
        }

        public void CrearContacto(Contacto  contacto)
        {
            if(_index < TAM)
            {
                _contactos[_index] = contacto;
                _index++;
            }
            else
            {
                System.Console.WriteLine("La agenda ya esta llena");
            }
        }

        public void BorrarUltimoContacto()
        {
            if(_index > 0)
            {
                _contactos[_index] = null;
                _index--;
            }
            else
            {
                System.Console.WriteLine("La agenda esta vacia");
            }
        }

        public void BorrarContacto()
        {
            
        }

        private bool NoHayContactos()
        {
            if(_index == 0)
            {
                System.Console.WriteLine("No hay contactos");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MostrarOrdenados()
        {
            if(NoHayContactos()) {return;}

            Contacto[] ordenados = new Contacto[_index];
            Array.Copy(_contactos,ordenados,_index);
            Array.Sort(ordenados);

            System.Console.WriteLine(CadenaContactos(ordenados));
            
        }

        public void MostrarOrdenadosDes()
        {
            if(NoHayContactos()) {return;}

            Contacto[] ordenados = new Contacto[_index];
            Array.Copy(_contactos,ordenados,_index);
            Array.Sort(ordenados);
            Array.Reverse(ordenados);

            System.Console.WriteLine(CadenaContactos(ordenados));
            
        }

        public Contacto BuscarContacto(string nombre)
        {
            foreach (Contacto contacto in _contactos)
            {
                if(contacto != null && contacto.Nombre == nombre)
                {
                    return contacto;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return CadenaContactos(_contactos);
        }
        
        private string CadenaContactos(Contacto[] contactos)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < _index; i++)
            {
                if(_contactos[i] == null) { continue; }

                string dato = string.Format("{0}. {1}",i+1,contactos[i]);
                builder.AppendLine(dato);
            }

            return builder.ToString();
        }

    }
}