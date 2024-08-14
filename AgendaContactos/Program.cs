using System.Text;

namespace AgendaContactos;

class Program
{
    static ControlAgenda control = new ControlAgenda(new Agenda());
    static void Main(string[] args)
    {
        string opcion = "";
        do
        {
            Console.Clear();
            System.Console.WriteLine("Agenda de contactos");
            ImprimeMenu();
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    control.VerContactos();
                    break;
                case "2":
                    control.AgregarContacto();
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
                    System.Console.WriteLine("Opcion No Valida");
                    break;
            }
        } while (opcion != "6");


    }

    static void ImprimeMenu()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("1. Ver Contactos");
        sb.AppendLine("2. Agregar Contactos");
        sb.AppendLine("3. Borrar Ultimo Contacto");
        sb.AppendLine("4. Buscar Contacto Por Nombre");
        sb.AppendLine("5. Acerca De");
        sb.AppendLine("1. Salir");
        sb.Append("Seleccione Una Opcion: ");

        System.Console.Write(sb.ToString());

    }
}
