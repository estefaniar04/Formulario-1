namespace Formulario_1
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
            this.btnvehiculo = new System.Windows.Forms.Button();
            this.btnMotocicleta = new System.Windows.Forms.Button();
            this.btnCuatrimoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvehiculo
            // 
            this.btnvehiculo.Location = new System.Drawing.Point(339, 68);
            this.btnvehiculo.Name = "btnvehiculo";
            this.btnvehiculo.Size = new System.Drawing.Size(134, 69);
            this.btnvehiculo.TabIndex = 0;
            this.btnvehiculo.Text = "vehiculo";
            this.btnvehiculo.UseVisualStyleBackColor = true;
            this.btnvehiculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMotocicleta
            // 
            this.btnMotocicleta.Location = new System.Drawing.Point(128, 68);
            this.btnMotocicleta.Name = "btnMotocicleta";
            this.btnMotocicleta.Size = new System.Drawing.Size(136, 69);
            this.btnMotocicleta.TabIndex = 1;
            this.btnMotocicleta.Text = "Motocicleta";
            this.btnMotocicleta.UseVisualStyleBackColor = true;
            this.btnMotocicleta.Click += new System.EventHandler(this.btnMotocicleta_Click);
            // 
            // btnCuatrimoto
            // 
            this.btnCuatrimoto.Location = new System.Drawing.Point(237, 161);
            this.btnCuatrimoto.Name = "btnCuatrimoto";
            this.btnCuatrimoto.Size = new System.Drawing.Size(137, 59);
            this.btnCuatrimoto.TabIndex = 2;
            this.btnCuatrimoto.Text = "Cuatrimoto";
            this.btnCuatrimoto.UseVisualStyleBackColor = true;
            this.btnCuatrimoto.Click += new System.EventHandler(this.btnCuatrimoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCuatrimoto);
            this.Controls.Add(this.btnMotocicleta);
            this.Controls.Add(this.btnvehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvehiculo;
        private System.Windows.Forms.Button btnMotocicleta;
        private System.Windows.Forms.Button btnCuatrimoto;
    }
}

