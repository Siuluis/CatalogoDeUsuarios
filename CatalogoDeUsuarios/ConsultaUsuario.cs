using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoDeUsuarios
{
    public partial class ConsultaUsuario : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public ConsultaUsuario()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopularUsuarios();
        }

        public void PopularUsuarios(string buscarclave = null, string buscarnombre = null, string buscarup = null)
        {
            List<Usuario> usuario = _businessLogicLayer.GetUsuario(buscarclave, buscarnombre, buscarup);
            gridUsuario.DataSource = usuario;
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuarios = new AltaUsuario();
            altaUsuarios.ShowDialog(this);
        }

        private void gridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                AltaUsuario altaUsuario = new AltaUsuario();
                altaUsuario.LoadUsuario(new Usuario
                {
                    Id = Convert.ToInt32((gridUsuario.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    Clave = gridUsuario.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    ClaveUsuario = gridUsuario.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Nombre = gridUsuario.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    UnidadPresupuestal = gridUsuario.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    TelEmpresa = gridUsuario.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    TelPersonal = gridUsuario.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    CorreoInstitucional = gridUsuario.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    CorreoPersonal = gridUsuario.Rows[e.RowIndex].Cells[8].Value.ToString()
                });
                altaUsuario.ShowDialog(this);
            }else if (cell.Value.ToString() == "Eliminar")
            {
                EliminarUsuario(Convert.ToInt32((gridUsuario.Rows[e.RowIndex].Cells[0]).Value.ToString()));
            }

        }

        private void EliminarUsuario(int Id)
        {
            _businessLogicLayer.EliminarUsuario(Id);
            PopularUsuarios();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            PopularUsuarios(txt_claveUsuario.Text, txt_nombreUsuario.Text, txt_unidadPresupuestal.Text);
            txt_claveUsuario.Text = string.Empty;
            txt_nombreUsuario.Text = string.Empty;
            txt_unidadPresupuestal.Text = string.Empty;
        }

    }
}
