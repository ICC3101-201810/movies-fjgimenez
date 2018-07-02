namespace Ultimo_Lab
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.peliculasBtn = new System.Windows.Forms.Button();
            this.actoresBtn = new System.Windows.Forms.Button();
            this.directoresBtn = new System.Windows.Forms.Button();
            this.productoresBtn = new System.Windows.Forms.Button();
            this.estudiosBtn = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // peliculasBtn
            // 
            this.peliculasBtn.Location = new System.Drawing.Point(12, 137);
            this.peliculasBtn.Name = "peliculasBtn";
            this.peliculasBtn.Size = new System.Drawing.Size(87, 35);
            this.peliculasBtn.TabIndex = 1;
            this.peliculasBtn.Text = "Peliculas";
            this.peliculasBtn.UseVisualStyleBackColor = true;
            this.peliculasBtn.Click += new System.EventHandler(this.peliculasBtn_Click);
            // 
            // actoresBtn
            // 
            this.actoresBtn.Location = new System.Drawing.Point(105, 137);
            this.actoresBtn.Name = "actoresBtn";
            this.actoresBtn.Size = new System.Drawing.Size(76, 35);
            this.actoresBtn.TabIndex = 2;
            this.actoresBtn.Text = "Actores";
            this.actoresBtn.UseVisualStyleBackColor = true;
            this.actoresBtn.Click += new System.EventHandler(this.actoresBtn_Click);
            // 
            // directoresBtn
            // 
            this.directoresBtn.Location = new System.Drawing.Point(187, 137);
            this.directoresBtn.Name = "directoresBtn";
            this.directoresBtn.Size = new System.Drawing.Size(90, 35);
            this.directoresBtn.TabIndex = 3;
            this.directoresBtn.Text = "Directores";
            this.directoresBtn.UseVisualStyleBackColor = true;
            this.directoresBtn.Click += new System.EventHandler(this.directoresBtn_Click);
            // 
            // productoresBtn
            // 
            this.productoresBtn.Location = new System.Drawing.Point(283, 137);
            this.productoresBtn.Name = "productoresBtn";
            this.productoresBtn.Size = new System.Drawing.Size(111, 35);
            this.productoresBtn.TabIndex = 4;
            this.productoresBtn.Text = "Productores";
            this.productoresBtn.UseVisualStyleBackColor = true;
            this.productoresBtn.Click += new System.EventHandler(this.productoresBtn_Click);
            // 
            // estudiosBtn
            // 
            this.estudiosBtn.Location = new System.Drawing.Point(400, 137);
            this.estudiosBtn.Name = "estudiosBtn";
            this.estudiosBtn.Size = new System.Drawing.Size(85, 35);
            this.estudiosBtn.TabIndex = 5;
            this.estudiosBtn.Text = "Estudios";
            this.estudiosBtn.UseVisualStyleBackColor = true;
            this.estudiosBtn.Click += new System.EventHandler(this.estudiosBtn_Click);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(137, 78);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(338, 26);
            this.searchBar.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.estudiosBtn);
            this.Controls.Add(this.productoresBtn);
            this.Controls.Add(this.directoresBtn);
            this.Controls.Add(this.actoresBtn);
            this.Controls.Add(this.peliculasBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button peliculasBtn;
        private System.Windows.Forms.Button actoresBtn;
        private System.Windows.Forms.Button directoresBtn;
        private System.Windows.Forms.Button productoresBtn;
        private System.Windows.Forms.Button estudiosBtn;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

