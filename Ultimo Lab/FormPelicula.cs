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
    public partial class FormPelicula : Form
    {
        BaseDatos db = new BaseDatos();

        public FormPelicula(Pelicula p)
        {
            InitializeComponent();
            labelNombre.Text = p.Nombre;
            labelDirector.Text = p.Director;
            labelFechaEstreno.Text = p.FechaEstreno;
            labelDescripcion.Text = p.Descripcion;
            labelPresupuesto.Text = p.Presupuesto;
            labelEstudio.Text = p.Estudio;

            db.pelicula.Add(new Pelicula("Avengers", "Andres Riquelme", "1/6/2011", "muchas peleas", "1MM USD", "Marvel"));
            db.pelicula.Add(new Pelicula("Avengers 2", "Pedro Hurtado", "7/7/2014", "aun mas peleas", "1,2MM USD", "Marvel"));

            db.peliculaactor.Add(new PeliculaActor("Avengers", "Samuel","Jackson"));
            db.peliculaactor.Add(new PeliculaActor("Avengers", "Scarlett","Johanson"));
            db.peliculaactor.Add(new PeliculaActor("Django", "Samuel", "Jackson"));

            db.peliculaproductor.Add(new PeliculaProductor("Avengers", "Claudio", "Troncoso"));


            for (int i = 0; i < this.db.peliculaactor.Count; i++)
            {
                if (this.db.peliculaactor[i].NombrePelicula == p.Nombre)
                {
                    for (int j = 0; j < this.db.pelicula.Count; j++)
                    {
                        if ((this.db.peliculaactor[i].NombrePelicula == this.db.pelicula[j].Nombre))
                        {
                            //Create label
                            Label label = new Label();
                            label.Text = String.Format("{0}-{1}", i + 1, this.db.peliculaactor[i].NombreActor + " " + this.db.peliculaactor[i].ApellidoActor);
                            //Position label on screen
                            label.Left = 230;
                            label.Top = (i + 1) * 30 + 30;
                            this.Controls.Add(label);
                        }
                    }
                }
            }

            for (int i = 0; i < this.db.peliculaproductor.Count; i++)
            {
                if (this.db.peliculaproductor[i].NombrePelicula == p.Nombre)
                {
                    for (int j = 0; j < this.db.pelicula.Count; j++)
                    {
                        if ((this.db.peliculaproductor[i].NombrePelicula == this.db.pelicula[j].Nombre))
                        {
                            //Create label
                            Label label = new Label();
                            label.Text = String.Format("{0}-{1}", i + 1, this.db.peliculaproductor[i].NombreProductor + " " + this.db.peliculaproductor[i].ApellidoProductor);
                            //Position label on screen
                            label.Left = 360;
                            label.Top = (i + 1) * 30 + 30;
                            this.Controls.Add(label);
                        }
                    }
                }
            }
        }

        private void FormPelicula_Load(object sender, EventArgs e)
        {

        }
    }
}
