namespace SQL_Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - - - Obtener Usuario - - - ");
            // Traer Usuario 
            Usuario usuario = UsuarioHandler.ObtenerUsuario(1);
            Console.WriteLine($"Usuario Id: {usuario.Id}, Usuario: {usuario.Nombre}");

            Console.WriteLine("--------");

            //Traer Productos
            List<Producto> productos = ProductoHandler.ObtenerProductos(1);
            foreach (var item in productos)
            {
                Console.WriteLine($"Productos cargados por el usuario {item.IdUsuario}: {item.Descripciones}");
            }

            Console.WriteLine("--------");

            Console.WriteLine(" - - - Productos Vendidos - - - ");

            // Traer Produtos vendidos
            List<Producto> productosVendidos = ProductoHandler.ObtenerProductoVendido(1);
            foreach (var item in productosVendidos)
            {
                Console.WriteLine($"Productos Vendidos por Usuario Id {item.IdUsuario}: {item.Descripciones}");
            }


            Console.WriteLine(" - - - Ventas - - - ");

            // Traer Ventas 
            List<Venta> ventas = VentaHandler.ObtenerVentas(1);
            foreach (var item in ventas)
            {
                Console.WriteLine($"Ventas Usuario: {item.IdUsuario}, Id de la Venta: {item.Id}");
            }


            Console.WriteLine("- - - Login - - - ");

            // Inicio de sesión 
            Usuario usuarioLogin = UsuarioHandler.ObtenerUsuarioLogin("tcasazza", "SoyTobiasCasazza");
            Console.WriteLine($"Usuario: {usuarioLogin.Nombre} \tApellido: {usuarioLogin.Apellido} \tMail: {usuarioLogin.Mail}");

        }
    }
} 