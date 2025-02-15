using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Amics.Modelos
{
    public class Usuario
    {
        public string dni {  get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string correoElectronico { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }

    }
}
