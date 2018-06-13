namespace Ultimo_Lab
{
    partial class FormEstudio
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFechaApertura = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(316, 93);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFechaApertura
            // 
            this.labelFechaApertura.AutoSize = true;
            this.labelFechaApertura.Location = new System.Drawing.Point(316, 211);
            this.labelFechaApertura.Name = "labelFechaApertura";
            this.labelFechaApertura.Size = new System.Drawing.Size(116, 20);
            this.labelFechaApertura.TabIndex = 1;
            this.labelFechaApertura.Text = "FechaApertura";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(316, 151);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(75, 20);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Direccion";
            // 
            // FormEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelFechaApertura);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormEstudio";
            this.Text = "FormEstudio";
            this.Load += new System.EventHandler(this.FormEstudio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFechaApertura;
        private System.Windows.Forms.Label labelDireccion;
    }
}