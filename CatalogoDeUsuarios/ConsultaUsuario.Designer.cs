
namespace CatalogoDeUsuarios
{
    partial class ConsultaUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_claveUsuario = new System.Windows.Forms.TextBox();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_unidadPresupuestal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridUsuario = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadPresupuestal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoInstitucional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(512, 12);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(101, 23);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Alta de Usuario";
            this.btn_alta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(304, 144);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_claveUsuario
            // 
            this.txt_claveUsuario.Location = new System.Drawing.Point(69, 78);
            this.txt_claveUsuario.Name = "txt_claveUsuario";
            this.txt_claveUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_claveUsuario.TabIndex = 2;
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(295, 79);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreUsuario.TabIndex = 3;
            // 
            // txt_unidadPresupuestal
            // 
            this.txt_unidadPresupuestal.FormattingEnabled = true;
            this.txt_unidadPresupuestal.Location = new System.Drawing.Point(492, 78);
            this.txt_unidadPresupuestal.Name = "txt_unidadPresupuestal";
            this.txt_unidadPresupuestal.Size = new System.Drawing.Size(121, 21);
            this.txt_unidadPresupuestal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clave de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UP de Usuario";
            // 
            // gridUsuario
            // 
            this.gridUsuario.AutoGenerateColumns = false;
            this.gridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Clave,
            this.ClaveUsuario,
            this.Nombre,
            this.UnidadPresupuestal,
            this.TelEmpresa,
            this.TelPersonal,
            this.CorreoInstitucional,
            this.CorreoPersonal,
            this.Edit,
            this.Eliminar});
            this.gridUsuario.DataSource = this.usuarioBindingSource;
            this.gridUsuario.Location = new System.Drawing.Point(12, 197);
            this.gridUsuario.Name = "gridUsuario";
            this.gridUsuario.Size = new System.Drawing.Size(650, 150);
            this.gridUsuario.TabIndex = 8;
            this.gridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuario_CellContentClick);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(CatalogoDeUsuarios.Usuario);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            // 
            // ClaveUsuario
            // 
            this.ClaveUsuario.DataPropertyName = "ClaveUsuario";
            this.ClaveUsuario.HeaderText = "ClaveUsuario";
            this.ClaveUsuario.Name = "ClaveUsuario";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // UnidadPresupuestal
            // 
            this.UnidadPresupuestal.DataPropertyName = "UnidadPresupuestal";
            this.UnidadPresupuestal.HeaderText = "UnidadPresupuestal";
            this.UnidadPresupuestal.Name = "UnidadPresupuestal";
            // 
            // TelEmpresa
            // 
            this.TelEmpresa.DataPropertyName = "TelEmpresa";
            this.TelEmpresa.HeaderText = "TelEmpresa";
            this.TelEmpresa.Name = "TelEmpresa";
            // 
            // TelPersonal
            // 
            this.TelPersonal.DataPropertyName = "TelPersonal";
            this.TelPersonal.HeaderText = "TelPersonal";
            this.TelPersonal.Name = "TelPersonal";
            // 
            // CorreoInstitucional
            // 
            this.CorreoInstitucional.DataPropertyName = "CorreoInstitucional";
            this.CorreoInstitucional.HeaderText = "CorreoInstitucional";
            this.CorreoInstitucional.Name = "CorreoInstitucional";
            // 
            // CorreoPersonal
            // 
            this.CorreoPersonal.DataPropertyName = "CorreoPersonal";
            this.CorreoPersonal.HeaderText = "CorreoPersonal";
            this.CorreoPersonal.Name = "CorreoPersonal";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.gridUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_unidadPresupuestal);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.txt_claveUsuario);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_alta);
            this.Name = "ConsultaUsuario";
            this.Text = "Consulta de Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_claveUsuario;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.ComboBox txt_unidadPresupuestal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadPresupuestal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoInstitucional;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoPersonal;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}

