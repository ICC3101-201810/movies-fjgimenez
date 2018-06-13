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
            db.pelicula.Add(new Pelicula("Avengers", "Pepito", "1/6/2011", "muchas peleas", "1MM USD", "Marvel"));
            db.pelicula.Add(new Pelicula("Avengers 2", "Juanito", "7/7/2014", "aun mas peleas", "1,2MM USD", "Marvel"));

            db.actor.Add(new Actor("Samuel", "Jackson", "3/5/1972", "buen actor"));
            db.actor.Add(new Actor("Scarlett", "Johanson", "7/11/1985", "simpatica"));

            db.director.Add(new Director("Andres", "Riquelme", "9/9/1967", "bacan"));
            db.director.Add(new Director("Pedro", "Hurtado", "3/12/1981", "super bacan"));

            db.productor.Add(new Productor("Claudio", "Troncoso", "2/5/1977", "malo"));
            db.productor.Add(new Productor("Maria", "Beltran", "24/8/1965", "muy malo"));

            db.estudio.Add(new Estudio("Estudio1", "Direccion2", "Fecha1"));
            db.estudio.Add(new Estudio("Estudio2", "Direccion1", "Fecha2"));

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
                label.Click += Label_Click_Actor;
                this.Controls.Add(label);
            }
        }
        private void Label_Click_Actor(object sender, EventArgs e)
        {
            this.Refresh();
            int actores_id = Int32.Parse(((Label)sender).Text.Split('-')[0])-1;
            Form actores_perfil = new FormActor(this.db.actor[actores_id]);
            actores_perfil.Show();
        }

        private void directoresBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.director[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Director;
                this.Controls.Add(label);

            }
        }
        private void Label_Click_Director(object sender, EventArgs e)
        {
            this.Refresh();
            int directores_id = Int32.Parse(((Label)sender).Text.Split('-')[0]) - 1;
            Form directores_perfil = new FormDirector(this.db.director[directores_id]);
            directores_perfil.Show();
        }

        private void productoresBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.productor[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Productor;
                this.Controls.Add(label);

            }
        }
        private void Label_Click_Productor(object sender, EventArgs e)
        {
            this.Refresh();
            int productores_id = Int32.Parse(((Label)sender).Text.Split('-')[0]) - 1;
            Form productores_perfil = new FormProductor(this.db.productor[productores_id]);
            productores_perfil.Show();
        }

        private void estudiosBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.estudio[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20 + 130;
                label.Click += Label_Click_Estudio;
                this.Controls.Add(label);
            }
        }
        private void Label_Click_Estudio(object sender, EventArgs e)
        {
            this.Refresh();
            int estudios_id = Int32.Parse(((Label)sender).Text.Split('-')[0]) - 1;
            Form estudios_perfil = new FormEstudio(this.db.estudio[estudios_id]);
            estudios_perfil.Show();
        }
    }
    }

