
namespace PresentacionPermisos
{
    partial class frmPermisosRegistro
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
            this.chbLectura = new System.Windows.Forms.CheckBox();
            this.chbActualizar = new System.Windows.Forms.CheckBox();
            this.chbEscritura = new System.Windows.Forms.CheckBox();
            this.chbEliminar = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbLectura
            // 
            this.chbLectura.AutoSize = true;
            this.chbLectura.Location = new System.Drawing.Point(144, 114);
            this.chbLectura.Name = "chbLectura";
            this.chbLectura.Size = new System.Drawing.Size(56, 17);
            this.chbLectura.TabIndex = 4;
            this.chbLectura.Text = "Letura";
            this.chbLectura.UseVisualStyleBackColor = true;
            // 
            // chbActualizar
            // 
            this.chbActualizar.AutoSize = true;
            this.chbActualizar.Location = new System.Drawing.Point(144, 157);
            this.chbActualizar.Name = "chbActualizar";
            this.chbActualizar.Size = new System.Drawing.Size(69, 17);
            this.chbActualizar.TabIndex = 5;
            this.chbActualizar.Text = "Modificar";
            this.chbActualizar.UseVisualStyleBackColor = true;
            // 
            // chbEscritura
            // 
            this.chbEscritura.AutoSize = true;
            this.chbEscritura.Location = new System.Drawing.Point(271, 114);
            this.chbEscritura.Name = "chbEscritura";
            this.chbEscritura.Size = new System.Drawing.Size(63, 17);
            this.chbEscritura.TabIndex = 6;
            this.chbEscritura.Text = "Agregar";
            this.chbEscritura.UseVisualStyleBackColor = true;
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Location = new System.Drawing.Point(271, 157);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(62, 17);
            this.chbEliminar.TabIndex = 7;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(103, 225);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(291, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(79, 57);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuario.TabIndex = 12;
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(271, 57);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(121, 21);
            this.cmbModulo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modulos:";
            // 
            // frmPermisosRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chbEliminar);
            this.Controls.Add(this.chbEscritura);
            this.Controls.Add(this.chbActualizar);
            this.Controls.Add(this.chbLectura);
            this.Name = "frmPermisosRegistro";
            this.Text = "frmPermisosRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbLectura;
        private System.Windows.Forms.CheckBox chbActualizar;
        private System.Windows.Forms.CheckBox chbEscritura;
        private System.Windows.Forms.CheckBox chbEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}