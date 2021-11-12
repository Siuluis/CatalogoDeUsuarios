
namespace CatalogoDeUsuarios
{
    partial class AltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_claveUsuario = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_unidadPresupuestal = new System.Windows.Forms.TextBox();
            this.txt_telEmpresa = new System.Windows.Forms.TextBox();
            this.txt_telPersonal = new System.Windows.Forms.TextBox();
            this.txt_correoInstitucional = new System.Windows.Forms.TextBox();
            this.txt_correoPersonal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_claveSistema = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad Presupuestal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono Personal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo Instituccional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo Personal";
            // 
            // txt_claveUsuario
            // 
            this.txt_claveUsuario.Location = new System.Drawing.Point(185, 76);
            this.txt_claveUsuario.Name = "txt_claveUsuario";
            this.txt_claveUsuario.Size = new System.Drawing.Size(181, 20);
            this.txt_claveUsuario.TabIndex = 7;
            this.txt_claveUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_claveUsuario_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(185, 115);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(181, 20);
            this.txt_nombre.TabIndex = 8;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_unidadPresupuestal
            // 
            this.txt_unidadPresupuestal.Location = new System.Drawing.Point(185, 155);
            this.txt_unidadPresupuestal.Name = "txt_unidadPresupuestal";
            this.txt_unidadPresupuestal.Size = new System.Drawing.Size(181, 20);
            this.txt_unidadPresupuestal.TabIndex = 9;
            this.txt_unidadPresupuestal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unidadPresupuestal_KeyPress);
            // 
            // txt_telEmpresa
            // 
            this.txt_telEmpresa.Location = new System.Drawing.Point(185, 197);
            this.txt_telEmpresa.Name = "txt_telEmpresa";
            this.txt_telEmpresa.Size = new System.Drawing.Size(181, 20);
            this.txt_telEmpresa.TabIndex = 10;
            this.txt_telEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telEmpresa_KeyPress);
            // 
            // txt_telPersonal
            // 
            this.txt_telPersonal.Location = new System.Drawing.Point(185, 238);
            this.txt_telPersonal.Name = "txt_telPersonal";
            this.txt_telPersonal.Size = new System.Drawing.Size(181, 20);
            this.txt_telPersonal.TabIndex = 11;
            this.txt_telPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telPersonal_KeyPress);
            // 
            // txt_correoInstitucional
            // 
            this.txt_correoInstitucional.Location = new System.Drawing.Point(185, 282);
            this.txt_correoInstitucional.Name = "txt_correoInstitucional";
            this.txt_correoInstitucional.Size = new System.Drawing.Size(181, 20);
            this.txt_correoInstitucional.TabIndex = 12;
            this.txt_correoInstitucional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correoInstitucional_KeyPress);
            // 
            // txt_correoPersonal
            // 
            this.txt_correoPersonal.Location = new System.Drawing.Point(185, 326);
            this.txt_correoPersonal.Name = "txt_correoPersonal";
            this.txt_correoPersonal.Size = new System.Drawing.Size(181, 20);
            this.txt_correoPersonal.TabIndex = 13;
            this.txt_correoPersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correoPersonal_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Clave del Sistema";
            // 
            // txt_claveSistema
            // 
            this.txt_claveSistema.Location = new System.Drawing.Point(74, 41);
            this.txt_claveSistema.Name = "txt_claveSistema";
            this.txt_claveSistema.Size = new System.Drawing.Size(100, 20);
            this.txt_claveSistema.TabIndex = 15;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(87, 383);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 16;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(197, 383);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bienvenido Administrador del sistema ";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 418);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_claveSistema);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_correoPersonal);
            this.Controls.Add(this.txt_correoInstitucional);
            this.Controls.Add(this.txt_telPersonal);
            this.Controls.Add(this.txt_telEmpresa);
            this.Controls.Add(this.txt_unidadPresupuestal);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_claveUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaUsuario";
            this.Text = "Alta de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_claveUsuario;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_unidadPresupuestal;
        private System.Windows.Forms.TextBox txt_telEmpresa;
        private System.Windows.Forms.TextBox txt_telPersonal;
        private System.Windows.Forms.TextBox txt_correoInstitucional;
        private System.Windows.Forms.TextBox txt_correoPersonal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_claveSistema;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label9;
    }
}