using System;
using System.Windows.Forms;

namespace CatalogoDeUsuarios
{
    public partial class AltaUsuario : Form
    {
        private DataAccessLayer _dataAccessLayer;
        private BusinessLogicLayer _businessLogicLayer;
        private Usuario _usuario;
        string nombrecolumna;
        string editar;
        public AltaUsuario()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            _dataAccessLayer = new DataAccessLayer();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro que quieres cancelar el alta o la modificación del Usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_claveUsuario.Text))
            {
                nombrecolumna = "Clave usario";
            } 
            else if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                nombrecolumna = "Nombre";
            }
            else if (string.IsNullOrEmpty(txt_unidadPresupuestal.Text))
            {
                nombrecolumna = "Unidad Presupuestal";
            }
            else if (string.IsNullOrEmpty(txt_telEmpresa.Text))
            {
                nombrecolumna = "Telefono empresa";
            }
            else if (string.IsNullOrEmpty(txt_telPersonal.Text))
            {
                nombrecolumna = "Telefono personal";
            }
            else if (string.IsNullOrEmpty(txt_correoInstitucional.Text))
            {
                nombrecolumna = "Correo institucional";
            }
            else if (string.IsNullOrEmpty(txt_correoPersonal.Text))
            {
                nombrecolumna = "Correo personal";
            }
            else
            {
                if (_dataAccessLayer.Existe(txt_claveUsuario.Text, txt_nombre.Text) == "si" || editar == "editar")
                {
                    Guardar();
                    this.Close();
                    ((ConsultaUsuario)this.Owner).PopularUsuarios();
                    nombrecolumna = "";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Error, ya existe un usuario con esa clave o ese nombre. ¿Quiere ver el registro previo ?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        LimpiarFormulario();
                    }
                }
            }

            if (!string.IsNullOrEmpty(nombrecolumna))
            {
                MessageBox.Show("Error, es necesario capturar el campo requerido " + nombrecolumna, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void Guardar()
        {
                Usuario usuario = new Usuario();
                usuario.Clave = txt_claveSistema.Text;
                usuario.ClaveUsuario = txt_claveUsuario.Text;
                usuario.Nombre = txt_nombre.Text;
                usuario.UnidadPresupuestal = txt_unidadPresupuestal.Text;
                usuario.TelEmpresa = txt_telEmpresa.Text;
                usuario.TelPersonal = txt_telPersonal.Text;
                usuario.CorreoInstitucional = txt_correoInstitucional.Text;
                usuario.CorreoPersonal = txt_correoPersonal.Text;

                usuario.Id = _usuario != null ? _usuario.Id : 0;
                _businessLogicLayer.GuardarUsuario(usuario);
        }

        private void LimpiarFormulario()
        {
            txt_claveSistema.Text = string.Empty;
            txt_claveUsuario.Text = string.Empty;
            txt_nombre.Text = string.Empty;
            txt_unidadPresupuestal.Text = string.Empty;
            txt_telEmpresa.Text = string.Empty;
            txt_telPersonal.Text = string.Empty;
            txt_correoInstitucional.Text = string.Empty;
            txt_correoPersonal.Text = string.Empty;
        }

        public void LoadUsuario(Usuario usuario)
        {
            _usuario = usuario;
            if (usuario != null)
            {
                LimpiarFormulario();
                editar = "editar";
                txt_claveSistema.Text = usuario.Clave;
                txt_claveUsuario.Text = usuario.ClaveUsuario;
                txt_nombre.Text = usuario.Nombre;
                txt_unidadPresupuestal.Text = usuario.UnidadPresupuestal;
                txt_telEmpresa.Text = usuario.TelEmpresa;
                txt_telPersonal.Text = usuario.TelPersonal;
                txt_correoInstitucional.Text = usuario.CorreoInstitucional;
                txt_correoPersonal.Text = usuario.CorreoPersonal;
            }
        }

        private void txt_claveUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_claveUsuario.MaxLength = 10;
         
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_nombre.MaxLength = 50;
        }
        private void txt_unidadPresupuestal_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_unidadPresupuestal.MaxLength = 50;
        }

        private void txt_telEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_telEmpresa.MaxLength = 10;

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_telPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_telPersonal.MaxLength = 10;

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_correoInstitucional_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_correoInstitucional.MaxLength = 25;
        }
        private void txt_correoPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_correoPersonal.MaxLength = 25;
        }
    }
}
