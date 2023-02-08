using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Proyecto
{
    internal class Producto
    {
        public long Id { get; set; }
        public string Descripciones { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public long IdUsuario { get; set; }



        //public Producto(long id, string descripciones, double costo, double precioVenta, int stock, long idUsuario)
        //{
        //    this.id = id;
        //    this.descripciones = descripciones;
        //    this.costo = costo;
        //    this.precioVenta = precioVenta;
        //    this.stock = stock;
        //    this.idUsuario = idUsuario;
        //}
    }
}
