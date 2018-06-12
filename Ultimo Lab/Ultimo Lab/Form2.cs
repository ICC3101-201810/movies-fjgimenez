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

            db.actor.Add(new Actor("asd", "asd", "asd", "asd"));
            db.actor.Add(new Actor("asd", "asd", "asd", "asd"));

            db.director.Add(new Director("asd", "asd", "asd", "asd"));
            db.director.Add(new Director("asd", "asd", "asd", "asd"));

            db.productor.Add(new Productor("asd", "asd", "asd", "asd"));
            db.productor.Add(new Productor("asd", "asd", "asd", "asd"));

            db.estudio.Add(new Estudio("asd", "asd", "asd"));
            db.estudio.Add(new Estudio("asd", "asd", "asd"));

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
                label.Text = String.Format("{0}-{1}", i+1,this.db.pelicula[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Pelicula;
                this.Controls.Add(label);
              
            }
        }

        private void Label_Click_Pelicula(object sender, EventArgs e)
        {
            this.Refresh();
            int pelicula_id =Int32.Parse(((Label)sender).Text.Split('-')[0])-1;
            Form pelicula_perfil = new FormPelicula(this.db.pelicula[pelicula_id]);
            pelicula_perfil.Show();

        }

        private void actoresBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.db.actor.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.actor[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Actores;
                this.Controls.Add(label);
            }
        }
        private void Label_Click_Actores(object sender, EventArgs e)
        {
            this.Refresh();
            int actores_id = Int32.Parse(((Label)sender).Text.Split('-')[0])-1;
            Form actores_perfil = new FormPelicula(this.db.pelicula[actores_id]);
            actores_perfil.Show();

        }

        private void directoresBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i, this.db.director[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Pelicula;
                this.Controls.Add(label);

            }
        }

        private void productoresBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i, this.db.productor[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Pelicula;
                this.Controls.Add(label);

            }
        }

        private void estudiosBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i, this.db.estudio[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Pelicula;
                this.Controls.Add(label);

            }
        }
    }
    }

