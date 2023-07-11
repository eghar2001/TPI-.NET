using Negocio;
using Entidades;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Negocio.Socio negocio_socio = new Negocio.Socio();
            void menu()
            {
                Console.WriteLine("MENU SOCIOS");
                Console.WriteLine("1- Alta Socio");
                Console.WriteLine("2- Baja Socio");
                Console.WriteLine("3- Modificar Socio");
                Console.WriteLine("4- Lista socios");
                Console.WriteLine("0- Salir del menu");
            }

            menu();
            ConsoleKeyInfo opcion_menu = Console.ReadKey();
            int id, dni;
            string nombre, apellido, nombre_usuario, contrasenia;
            while (opcion_menu.Key != ConsoleKey.D0)
            {
                if (opcion_menu.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Usted ha elegido Alta Socio");

                    Console.WriteLine("Ingrese el dni: ");
                    dni = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el nombre: ");
                    nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido: ");
                    apellido = Console.ReadLine();

                    Console.WriteLine("Ingrese el nombre de usuario: ");
                    nombre_usuario = Console.ReadLine();

                    Console.WriteLine("Ingrese contraseña: ");
                    contrasenia = Console.ReadLine();

                    Entidades.Socio socio_nuevo = new Entidades.Socio(dni, nombre, apellido, nombre_usuario, contrasenia);
                    negocio_socio.agregar_socio(socio_nuevo);
                    
                }
                else if (opcion_menu.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("MENU BORRAR SOCIO");
                    Console.WriteLine("Ingrese el dni: ");
                    dni = Int32.Parse(Console.ReadLine());
                    Entidades.Socio socio_a_eliminar = negocio_socio.get_by_dni(dni);
                    if (socio_a_eliminar == null)
                    {
                        Console.WriteLine("No se encontro el socio!");
                    }
                    else
                    {
                        negocio_socio.borrar_socio(socio_a_eliminar);
                        Console.WriteLine("El socio se ha eliminado correctamente");
                    }

                }
                else if (opcion_menu.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("MENU MODIFICACION SOCIO");

                    Console.WriteLine("Ingrese el id del socio a modificar: ");
                    id = Int32.Parse(Console.ReadLine());

                    Entidades.Socio socio_a_modificar = negocio_socio.get(id);
                    if (socio_a_modificar == null)
                    {
                        Console.WriteLine("No se ha encontrado al socio");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese el dni: ");
                        dni = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(dni);
                        Console.WriteLine("Ingrese el nombre: ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el apellido: ");
                        apellido = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre de usuario: ");
                        nombre_usuario = Console.ReadLine();

                        Console.WriteLine("Ingrese contraseña: ");
                        contrasenia = Console.ReadLine();

                        socio_a_modificar.Dni = dni;
                        socio_a_modificar.Nombre = nombre;
                        socio_a_modificar.Apellido = apellido;
                        socio_a_modificar.NombreUsuario = nombre_usuario;
                        socio_a_modificar.Contrasenia = contrasenia;

                        negocio_socio.modificar_socio(socio_a_modificar);
                        Console.WriteLine("El socio fue modificado con exito!!");
                       
                    }

                }
                else if (opcion_menu.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("ID --- DNI --- NOMBRE --- APELLIDO --- NOMBRE USUARIO");
                    foreach (Entidades.Socio socio in negocio_socio.find_all())
                    {
                        Console.WriteLine($"{socio.Id}   {socio.Dni}   {socio.Nombre}   {socio.Apellido}   {socio.NombreUsuario}");
                    }
                }
                else
                {
                    Console.WriteLine("No se presionó una tecla válida");
                }
                menu();
                opcion_menu = Console.ReadKey();
            }
        }


    }
}
