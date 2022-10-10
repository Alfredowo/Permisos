
namespace PresentacionPermisos
{
    partial class frmMenu
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
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.Enabled = false;
            this.btnHerramientas.Location = new System.Drawing.Point(350, 247);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(101, 23);
            this.btnHerramientas.TabIndex = 3;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Enabled = false;
            this.btnProductos.Location = new System.Drawing.Point(360, 180);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnProductos);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnProductos;
    }
}