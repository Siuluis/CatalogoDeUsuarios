using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDeUsuarios
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string ClaveUsuario { get; set; }
        public string Nombre { get; set; }
        public string UnidadPresupuestal { get; set; }
        public string TelEmpresa { get; set; }
        public string TelPersonal{ get; set; }
        public string CorreoInstitucional{ get; set; }
        public string CorreoPersonal { get; set; }
        public virtual int MaxLength { get; set; }
        public virtual int Usu { get; set; }
    }
}
