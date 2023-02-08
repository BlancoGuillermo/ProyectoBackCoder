using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Proyecto
{
    internal class Usuario
    {
        private long id;
        private string nombre;
        private string apellido;
        private string mail;
        private string nombreUsuario;
        private string contraseña;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        //public Usuario(long id, string nombre, string apellido, string mail, string nombreUsuario, string contraseña)
        //{
        //    this.id = id;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.mail = mail;
        //    this.nombreUsuario = nombreUsuario;
        //    this.contraseña = contraseña;
        //}

        
    }
}
