namespace Ultimo_Lab
{
    partial class FormPelicula
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
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelFechaEstreno = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPresupuesto = new System.Windows.Forms.Label();
            this.labelEstudio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(313, 67);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(313, 117);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(65, 20);
            this.labelDirector.TabIndex = 1;
            this.labelDirector.Text = "Director";
            // 
            // labelFechaEstreno
            // 
            this.labelFechaEstreno.AutoSize = true;
            this.labelFechaEstreno.Location = new System.Drawing.Point(289, 168);
            this.labelFechaEstreno.Name = "labelFechaEstreno";
            this.labelFechaEstreno.Size = new System.Drawing.Size(110, 20);
            this.labelFechaEstreno.TabIndex = 2;
            this.labelFechaEstreno.Text = "FechaEstreno";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(298, 221);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(92, 20);
            this.labelDescripcion.TabIndex = 3;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelPresupuesto
            // 
            this.labelPresupuesto.AutoSize = true;
            this.labelPresupuesto.Location = new System.Drawing.Point(298, 269);
            this.labelPresupuesto.Name = "labelPresupuesto";
            this.labelPresupuesto.Size = new System.Drawing.Size(99, 20);
            this.labelPresupuesto.TabIndex = 4;
            this.labelPresupuesto.Text = "Presupuesto";
            // 
            // labelEstudio
            // 
            this.labelEstudio.AutoSize = true;
            this.labelEstudio.Location = new System.Drawing.Point(298, 327);
            this.labelEstudio.Name = "labelEstudio";
            this.labelEstudio.Size = new System.Drawing.Size(63, 20);
            this.labelEstudio.TabIndex = 5;
            this.labelEstudio.Text = "Estudio";
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 428);
            this.Controls.Add(this.labelEstudio);
            this.Controls.Add(this.labelPresupuesto);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelFechaEstreno);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormPelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelFechaEstreno;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPresupuesto;
        private System.Windows.Forms.Label labelEstudio;
    }
}