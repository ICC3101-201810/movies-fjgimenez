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
        List<Label> currentLabels = new List<Label>();

        public Form2()
        {
            db.pelicula.Add(new Pelicula("Avengers", "Andres Riquelme", "1/6/2011", "muchas peleas", "1MM USD", "Marvel"));
            db.pelicula.Add(new Pelicula("Avengers 2", "Pedro Hurtado", "7/7/2014", "aun mas peleas", "1,2MM USD", "Marvel"));

            db.actor.Add(new Actor("Samuel", "Jackson", "3/5/1972", "buen actor"));
            db.actor.Add(new Actor("Scarlett", "Johanson", "7/11/1985", "simpatica"));

            db.director.Add(new Director("Andres", "Riquelme", "9/9/1967", "bacan"));
            db.director.Add(new Director("Pedro", "Hurtado", "3/12/1981", "super bacan"));

            db.productor.Add(new Productor("Claudio", "Troncoso", "2/5/1977", "malo"));
            db.productor.Add(new Productor("Maria", "Beltran", "24/8/1965", "muy malo"));

            db.estudio.Add(new Estudio("Marvel", "Hollywood 2387", "28/6/95"));
            db.estudio.Add(new Estudio("Universal", "Hollywood 1784", "3/3/72"));

            

            InitializeComponent();
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void clearLabels()
        {
            List<Control> removeCtrls = new List<Control>();
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    removeCtrls.Add(c);
                }
            }
            foreach (Control c in removeCtrls)
            {
                this.Controls.Remove(c);
            }
        }

        private void peliculasBtn_Click(object sender, EventArgs e)
        {
            this.clearLabels();
            this.currentLabels.Clear();
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1,this.db.pelicula[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 30 + 100;
                label.Click += Label_Click_Pelicula;
                this.Controls.Add(label);
                this.currentLabels.Add(label);
            }
        }

        private void Label_Click_Pelicula(object sender, EventArgs e)
        {
            int pelicula_id =Int32.Parse(((Label)sender).Text.Split('-')[0])-1;
            Form pelicula_perfil = new FormPelicula(this.db.pelicula[pelicula_id]);
            pelicula_perfil.Show();

        }

        private void actoresBtn_Click(object sender, EventArgs e)
        {
            this.clearLabels();
            this.currentLabels.Clear();
            for (int i = 0; i < this.db.actor.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.actor[i].Nombre+ " "+ this.db.actor[i].Apellido);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 30 + 100;
                label.Click += Label_Click_Actor;
                this.Controls.Add(label);
                this.currentLabels.Add(label);
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
            this.clearLabels();
            this.currentLabels.Clear();
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.director[i].Nombre + " " + this.db.director[i].Apellido);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 30 + 100;
                label.Click += Label_Click_Director;
                this.Controls.Add(label);
                this.currentLabels.Add(label);

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
            this.clearLabels();
            this.currentLabels.Clear();
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.productor[i].Nombre + " " + this.db.productor[i].Apellido);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 30 + 100;
                label.Click += Label_Click_Productor;
                this.Controls.Add(label);
                this.currentLabels.Add(label);

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
            this.clearLabels();
            this.currentLabels.Clear();
            for (int i = 0; i < this.db.pelicula.Count; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("{0}-{1}", i+1, this.db.estudio[i].Nombre);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 30 + 100;
                label.Click += Label_Click_Estudio;
                this.Controls.Add(label);
                this.currentLabels.Add(label);
            }
        }
        private void Label_Click_Estudio(object sender, EventArgs e)
        {
            this.Refresh();
            int estudios_id = Int32.Parse(((Label)sender).Text.Split('-')[0]) - 1;
            Form estudios_perfil = new FormEstudio(this.db.estudio[estudios_id]);
            estudios_perfil.Show();
        }

        private void searchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*string text = "";
            if (sender is TextBox)
            {
                text = (sender as TextBox).Text;
            }*/
            List<Control> labelCtrls = new List<Control>();
            foreach (Label l in this.currentLabels)
            {
                if (l.Text.ToLower().Contains(this.searchBar.Text.ToLower()))
                {
                    labelCtrls.Add(l);
                }
            }
            /*var filtro =
            from l in this.currentLabels
            where l.Text.Contains(searchBar.Text)
            select l;*/
            this.clearLabels();
            foreach (Label l in labelCtrls)
            {
                this.Controls.Add(l);
            }
        }
    }
    }

