using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ultimo_Lab
{
    public partial class Form2 : Form
    {
        BaseDatos db = new BaseDatos();

        public Form2()
        {
            db.pelicula.Add(new Pelicula("asd", "asd", "asd", "asd", "asd", "asd"));
            db.pelicula.Add(new Pelicula("asd", "asd", "asd", "asd", "asd", "asd"));
            db.pelicula.Add(new Pelicula("asd", "asd", "asd", "asd", "asd", "asd"));
            db.pelicula.Add(new Pelicula("asd","asd","asd","asd","asd","asd"));


            InitializeComponent();
            
 
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void peliculasBtn_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}", this.db.pelicula[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click;
                //Create textbox
                //TextBox textBox = new TextBox();
                //Position textbox on screen
                //textBox.Left = 120;
                //textBox.Top = (i + 1) * 20 + 130;
                //Add controls to form
                this.Controls.Add(label);
                //this.Controls.Add(textBox);
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Form pelicula_perfil = new Form3();
            pelicula_perfil.Show();
        }

        private void actoresBtn_Click(object sender, EventArgs e)
        {

        }

        private void directoresBtn_Click(object sender, EventArgs e)
        {

        }

        private void productoresBtn_Click(object sender, EventArgs e)
        {

        }

        private void estudiosBtn_Click(object sender, EventArgs e)
        {

        }
    }
    }

