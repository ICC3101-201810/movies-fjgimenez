using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimo_Lab
{
    public partial class FormActor : Form
    {
        BaseDatos db = new BaseDatos();

        public FormActor(Actor a)
        {
            InitializeComponent();
            labelNombre.Text = a.Nombre;
            labelApellido.Text = a.Apellido;
            labelFechaNacimiento.Text = a.FechaNacimiento;
            labelBiografia.Text = a.Biografia;

            db.peliculaactor.Add(new PeliculaActor("Avengers", "Samuel", "Jackson"));
            db.peliculaactor.Add(new PeliculaActor("Avengers2", "Scarlett", "Johanson"));
            db.peliculaactor.Add(new PeliculaActor("Django", "Samuel", "Jackson"));

            db.actor.Add(new Actor("Samuel", "Jackson", "3/5/1972", "buen actor"));
            db.actor.Add(new Actor("Scarlett", "Johanson", "7/11/1985", "simpatica"));

            for (int i = 0; i < this.db.peliculaactor.Count; i++)
            {
                if (this.db.peliculaactor[i].NombreActor == a.Nombre & this.db.peliculaactor[i].ApellidoActor == a.Apellido)
                {
                    for (int j = 0; j < this.db.actor.Count; j++)
                    {
                        if (this.db.peliculaactor[i].NombreActor == this.db.actor[j].Nombre & this.db.peliculaactor[i].ApellidoActor == this.db.actor[j].Apellido)
                        {
                            //Create label
                            Label label = new Label();
                            label.Text = String.Format("{0}-{1}", i + 1, this.db.peliculaactor[i].NombrePelicula);
                            //Position label on screen
                            label.Left = 280;
                            label.Top = (i + 1) * 30 + 30;
                            this.Controls.Add(label);
                        }
                    }
                }
            }
        }

            private void FormActor_Load(object sender, EventArgs e)
        {

        }
    }
}
