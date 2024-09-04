namespace Formulario_C_
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbTelfefono = new System.Windows.Forms.Label();
            this.lbEstatura = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.TextBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(21, 81);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(111, 27);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombres:";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(21, 141);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(112, 27);
            this.lbApellidos.TabIndex = 1;
            this.lbApellidos.Text = "Apellidos:";
            this.lbApellidos.Click += new System.EventHandler(this.lbApellidos_Click);
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(21, 221);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(67, 27);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Edad:";
            this.lbEdad.Click += new System.EventHandler(this.lbTelefono_Click);
            // 
            // lbTelfefono
            // 
            this.lbTelfefono.AutoSize = true;
            this.lbTelfefono.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelfefono.Location = new System.Drawing.Point(21, 301);
            this.lbTelfefono.Name = "lbTelfefono";
            this.lbTelfefono.Size = new System.Drawing.Size(108, 27);
            this.lbTelfefono.TabIndex = 3;
            this.lbTelfefono.Text = "Telefono:";
            this.lbTelfefono.Click += new System.EventHandler(this.lbTelfefono_Click);
            // 
            // lbEstatura
            // 
            this.lbEstatura.AutoSize = true;
            this.lbEstatura.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstatura.Location = new System.Drawing.Point(21, 383);
            this.lbEstatura.Name = "lbEstatura";
            this.lbEstatura.Size = new System.Drawing.Size(100, 27);
            this.lbEstatura.TabIndex = 4;
            this.lbEstatura.Text = "Estatura:";
            this.lbEstatura.Click += new System.EventHandler(this.lbEstatura_Click);
            // 
            // gbGenero
            // 
            this.gbGenero.BackColor = System.Drawing.Color.Cornsilk;
            this.gbGenero.Controls.Add(this.rbMujer);
            this.gbGenero.Controls.Add(this.rbHombre);
            this.gbGenero.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenero.Location = new System.Drawing.Point(370, 81);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(384, 160);
            this.gbGenero.TabIndex = 5;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero:";
            this.gbGenero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(600, 256);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(154, 37);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(370, 256);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(143, 37);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(138, 81);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(218, 26);
            this.tbNombres.TabIndex = 0;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(138, 141);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(218, 26);
            this.tbApellidos.TabIndex = 0;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(94, 221);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(262, 26);
            this.tbEdad.TabIndex = 0;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(135, 303);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(221, 26);
            this.tbTelefono.TabIndex = 6;
            // 
            // tbEstatura
            // 
            this.tbEstatura.Location = new System.Drawing.Point(127, 385);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(229, 26);
            this.tbEstatura.TabIndex = 7;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(6, 52);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(129, 34);
            this.rbHombre.TabIndex = 0;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(6, 92);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(104, 34);
            this.rbMujer.TabIndex = 1;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.rbMujer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.lbEstatura);
            this.Controls.Add(this.lbTelfefono);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbTelfefono;
        private System.Windows.Forms.Label lbEstatura;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbEstatura;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
    }
}

