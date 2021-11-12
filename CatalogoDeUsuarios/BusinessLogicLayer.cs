using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoDeUsuarios
{
    class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public Usuario GuardarUsuario(Usuario usuario_insert)
        {
            if (usuario_insert.Id == 0)
                _dataAccessLayer.InsertUsuario(usuario_insert);
            else
                _dataAccessLayer.UpdateUsuario(usuario_insert);
            return usuario_insert;
        }

        public List<Usuario> GetUsuario(string buscarclave = null, string buscarnombre = null, string buscarup = null)
        {
            return _dataAccessLayer.GetUsuario(buscarclave, buscarnombre, buscarup);
        }

        public void EliminarUsuario(int Id)
        {
            _dataAccessLayer.EliminarUsuario(Id);
        }
        /*
        public string Existe(string claveusuario = null, string nombre = null, string salida = "")
        {
            _dataAccessLayer.Existe(claveusuario, nombre);
            return salida;
        }*/
    }
}
