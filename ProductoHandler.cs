using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Proyecto
{
    internal static class ProductoHandler
    {   
        public static string cadenaConexion = "Data Source=DESKTOP-41B85ST;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Producto> ObtenerProductos(long id)
        {
            List<Producto>productos= new List<Producto>();
            Producto productoTemporal = new Producto();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando2 = new SqlCommand($"SELECT * FROM Producto WHERE id = @id", conn);
                comando2.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader reader = comando2.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Descripciones = reader.GetString(1);
                        productoTemporal.Costo = reader.GetDecimal(2);
                        productoTemporal.PrecioVenta = reader.GetDecimal(3);
                        productoTemporal.Stock = reader.GetInt32(4);
                        productoTemporal.IdUsuario = reader.GetInt64(5);

                        productos.Add(productoTemporal);

                    }
                }
                return productos;
                

            }
        }

        public static Producto ObtenerProducto(long id)
        {
            Producto producto = new Producto();
            
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Producto WHERE @Id=id", conn);
                comando2.Parameters.AddWithValue("@Id", id);

                conn.Open();

                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    Producto productoTemporal = new Producto();
                    producto.Id = reader.GetInt64(0);
                    producto.Descripciones = reader.GetString(1);
                    producto.Costo = reader.GetDecimal(2);
                    producto.PrecioVenta = reader.GetDecimal(3);
                    producto.Stock = reader.GetInt32(4);
                    producto.IdUsuario = reader.GetInt64(5);

                }
                return producto;
            }
        }

        public static List<Producto> ObtenerProductoVendido(long idUsuario)
        {
            List<long> ListaIdProductos = new List<long>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando3 = new SqlCommand("SELECT IdProducto FROM Venta INNER JOIN ProductoVendido  ON venta.id = ProductoVendido.IdVenta WHERE IdUsuario = @idUsuario", conn);

                comando3.Parameters.AddWithValue("@idUsuario", idUsuario);

                conn.Open();

                SqlDataReader reader = comando3.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListaIdProductos.Add(reader.GetInt64(0));
                    }
                }
            }
            List<Producto> productos = new List<Producto>();
            foreach (var Id in ListaIdProductos)
            {
                Producto prodTemp = ObtenerProducto(Id);
                productos.Add(prodTemp);
            }

            return productos;

        }
    }


    
}
