namespace Primerospasosotp
{
    internal class Usuario
    {
        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private int _Contraseña;
        private string _Mail;


        public Usuario()
        {
            _Id = 0;
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _NombreUsuario = string.Empty;
            _Contraseña = 0;
            _Mail = string.Empty;
        }


        public Usuario(int id, string nombre, string apellido, string nombreUsuario, int contraseña, string mail)
        {
            _Id = id;
            _Nombre = nombre;
            _Apellido = apellido;
            _NombreUsuario = nombreUsuario;
            _Contraseña = contraseña;
            _Mail = mail;
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        public int Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; }
        }

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }
    }

    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Ingrese la información del usuario:");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Nombre de Usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            int contraseña = int.Parse(Console.ReadLine());

            Console.Write("Mail: ");
            string mail = Console.ReadLine();


            Usuario usuario = new Usuario(id, nombre, apellido, nombreUsuario, contraseña, mail);

        }
    }
}
