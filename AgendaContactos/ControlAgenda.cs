using System.ComponentModel;
using System.Text;

namespace AgendaContactos
{
    class ControlAgenda
    {
        private Agenda _agenda;

        public ControlAgenda(Agenda agenda)
        {
            _agenda = agenda;
        }

        public void VerContactos()
        {
            Limpiar();
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    System.Console.WriteLine("Contactos Orden Ascendente");
                    _agenda.MostrarOrdenados();
                    break;
                case "2":
                    System.Console.WriteLine("Contasros Orden Descendente");
                    _agenda.MostrarOrdenadosDes();
                    break;
                case "3":
                    return;
                default:
                    System.Console.WriteLine("Opcion no valida");
                    break;
            }
            PresionaParaContinuar();
        }

        public void AgregarContacto()
        {
            Limpiar();
            System.Console.WriteLine("Nuevo Contacto");
            Contacto contacto = new Contacto();

            System.Console.Write("Nombre: ");
            contacto.Nombre = Console.ReadLine();
            System.Console.Write("Telefono: ");
            contacto.Telefono = Console.ReadLine();
            System.Console.Write("Correo: ");
            contacto.Correo = Console.ReadLine();

            _agenda.CrearContacto(contacto);
            System.Console.WriteLine("Contacto Creado...");
            PresionaParaContinuar();
        }

        public void BorrarUltimoContacto()
        {
            Limpiar();
            _agenda.BorrarUltimoContacto();
            System.Console.WriteLine("Contacto Borrado con exito!");
            PresionaParaContinuar();
        }

        public void BuscarPorNombre()
        {
            Limpiar();
            System.Console.WriteLine("Buscar Contacto");
            System.Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Contacto contacto = _agenda.BuscarContacto(nombre);
            if(contacto != null)
            {
                System.Console.WriteLine("Datos: {0}\n",contacto.ToString());
            }
            else
            {
                System.Console.WriteLine("Contacto No Encontrado");
            }

            PresionaParaContinuar();
        }

        public static void AcercaDe()
        {
            Limpiar();   
            System.Console.WriteLine("BuritiCrack");
            PresionaParaContinuar();
        }
        public void MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Mostrar Orden Ascendente");
            sb.AppendLine("2. Mostrar Orden Descendente");
            sb.AppendLine("3. Volver Al Menu Pricipal");
            sb.Append("Seleccione Una Opcion: ");

            System.Console.Write(sb.ToString());
        }

        private static void PresionaParaContinuar()
        {
            System.Console.WriteLine("Presiona Cualquier Tecla Para Continuar");
            Console.ReadKey();
        }

        public static void Limpiar()
        {
            Console.Clear();
        }

    }


}