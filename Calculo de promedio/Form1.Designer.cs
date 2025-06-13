namespace Calculo_de_promedio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNota_tres = new System.Windows.Forms.TextBox();
            this.txtNota_dos = new System.Windows.Forms.TextBox();
            this.txtNota_uno = new System.Windows.Forms.TextBox();
            this.lblNota_tres = new System.Windows.Forms.Label();
            this.lblNota_dos = new System.Windows.Forms.Label();
            this.lblNota_uno = new System.Windows.Forms.Label();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPromobtenido = new System.Windows.Forms.Label();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo_Regis = new System.Windows.Forms.Button();
            this.btnAgre_prome = new System.Windows.Forms.Button();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.gbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPromedio.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.pictureBox1);
            this.gbRegistro.Controls.Add(this.lblError);
            this.gbRegistro.Controls.Add(this.txtNota_tres);
            this.gbRegistro.Controls.Add(this.txtNota_dos);
            this.gbRegistro.Controls.Add(this.txtNota_uno);
            this.gbRegistro.Controls.Add(this.lblNota_tres);
            this.gbRegistro.Controls.Add(this.lblNota_dos);
            this.gbRegistro.Controls.Add(this.lblNota_uno);
            this.gbRegistro.Location = new System.Drawing.Point(50, 43);
            this.gbRegistro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbRegistro.Size = new System.Drawing.Size(500, 287);
            this.gbRegistro.TabIndex = 0;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro de Notas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculo_de_promedio.Properties.Resources.icons8_usuario_100;
            this.pictureBox1.Location = new System.Drawing.Point(327, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(39, 246);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 18);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error";
            // 
            // txtNota_tres
            // 
            this.txtNota_tres.Location = new System.Drawing.Point(132, 197);
            this.txtNota_tres.Name = "txtNota_tres";
            this.txtNota_tres.Size = new System.Drawing.Size(150, 24);
            this.txtNota_tres.TabIndex = 5;
            this.tlpAyuda.SetToolTip(this.txtNota_tres, "Ingrese valores entre 0 y 10");
            // 
            // txtNota_dos
            // 
            this.txtNota_dos.Location = new System.Drawing.Point(132, 118);
            this.txtNota_dos.Name = "txtNota_dos";
            this.txtNota_dos.Size = new System.Drawing.Size(151, 24);
            this.txtNota_dos.TabIndex = 4;
            this.tlpAyuda.SetToolTip(this.txtNota_dos, "Ingrese valores entre 0 y 10");
            // 
            // txtNota_uno
            // 
            this.txtNota_uno.Location = new System.Drawing.Point(130, 53);
            this.txtNota_uno.Name = "txtNota_uno";
            this.txtNota_uno.Size = new System.Drawing.Size(154, 24);
            this.txtNota_uno.TabIndex = 3;
            this.tlpAyuda.SetToolTip(this.txtNota_uno, "Ingrese valores entre 0 y 10");
            // 
            // lblNota_tres
            // 
            this.lblNota_tres.AutoSize = true;
            this.lblNota_tres.Location = new System.Drawing.Point(30, 198);
            this.lblNota_tres.Name = "lblNota_tres";
            this.lblNota_tres.Size = new System.Drawing.Size(63, 18);
            this.lblNota_tres.TabIndex = 2;
            this.lblNota_tres.Text = "Nota 3:";
            // 
            // lblNota_dos
            // 
            this.lblNota_dos.AutoSize = true;
            this.lblNota_dos.Location = new System.Drawing.Point(27, 114);
            this.lblNota_dos.Name = "lblNota_dos";
            this.lblNota_dos.Size = new System.Drawing.Size(63, 18);
            this.lblNota_dos.TabIndex = 1;
            this.lblNota_dos.Text = "Nota 2:";
            // 
            // lblNota_uno
            // 
            this.lblNota_uno.AutoSize = true;
            this.lblNota_uno.Location = new System.Drawing.Point(26, 48);
            this.lblNota_uno.Name = "lblNota_uno";
            this.lblNota_uno.Size = new System.Drawing.Size(63, 18);
            this.lblNota_uno.TabIndex = 0;
            this.lblNota_uno.Text = "Nota 1:";
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.txtPromedio);
            this.gbPromedio.Controls.Add(this.lblPromobtenido);
            this.gbPromedio.Location = new System.Drawing.Point(50, 359);
            this.gbPromedio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbPromedio.Size = new System.Drawing.Size(823, 222);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(226, 101);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(218, 24);
            this.txtPromedio.TabIndex = 1;
            // 
            // lblPromobtenido
            // 
            this.lblPromobtenido.AutoSize = true;
            this.lblPromobtenido.Location = new System.Drawing.Point(41, 101);
            this.lblPromobtenido.Name = "lblPromobtenido";
            this.lblPromobtenido.Size = new System.Drawing.Size(154, 18);
            this.lblPromobtenido.TabIndex = 0;
            this.lblPromobtenido.Text = "Promedio Obtenido";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnSalir);
            this.gbAcciones.Controls.Add(this.btnNuevo_Regis);
            this.gbAcciones.Controls.Add(this.btnAgre_prome);
            this.gbAcciones.Location = new System.Drawing.Point(592, 55);
            this.gbAcciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbAcciones.Size = new System.Drawing.Size(280, 288);
            this.gbAcciones.TabIndex = 2;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Image = global::Calculo_de_promedio.Properties.Resources.icons8_cerrar_ventana_48;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(5, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(270, 53);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo_Regis
            // 
            this.btnNuevo_Regis.Image = global::Calculo_de_promedio.Properties.Resources.icons8_escoba_50;
            this.btnNuevo_Regis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo_Regis.Location = new System.Drawing.Point(5, 126);
            this.btnNuevo_Regis.Name = "btnNuevo_Regis";
            this.btnNuevo_Regis.Size = new System.Drawing.Size(270, 58);
            this.btnNuevo_Regis.TabIndex = 1;
            this.btnNuevo_Regis.Text = "Nuevo Registro";
            this.btnNuevo_Regis.UseVisualStyleBackColor = true;
            this.btnNuevo_Regis.Click += new System.EventHandler(this.btnNuevo_Regis_Click);
            // 
            // btnAgre_prome
            // 
            this.btnAgre_prome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgre_prome.Image = global::Calculo_de_promedio.Properties.Resources.icons8_agregar_propiedad_50;
            this.btnAgre_prome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgre_prome.Location = new System.Drawing.Point(5, 21);
            this.btnAgre_prome.Name = "btnAgre_prome";
            this.btnAgre_prome.Size = new System.Drawing.Size(270, 66);
            this.btnAgre_prome.TabIndex = 0;
            this.btnAgre_prome.Text = "Agregar Pormedio";
            this.btnAgre_prome.UseVisualStyleBackColor = true;
            this.btnAgre_prome.Click += new System.EventHandler(this.btnAgre_prome_Click);
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.IsBalloon = true;
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbRegistro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Sistema de Notas ITR";
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.TextBox txtNota_tres;
        private System.Windows.Forms.TextBox txtNota_dos;
        private System.Windows.Forms.TextBox txtNota_uno;
        private System.Windows.Forms.Label lblNota_tres;
        private System.Windows.Forms.Label lblNota_dos;
        private System.Windows.Forms.Label lblNota_uno;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo_Regis;
        private System.Windows.Forms.Button btnAgre_prome;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromobtenido;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}

