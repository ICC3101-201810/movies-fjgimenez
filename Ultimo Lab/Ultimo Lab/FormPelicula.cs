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

        public FormPelicula(Pelicula p)
        {
            InitializeComponent();
            labelNombre.Text = p.Nombre;
            labelDirector.Text = p.Director;
            labelFechaEstreno.Text = p.FechaEstreno;
            labelDescripcion.Text = p.Descripcion;
            labelPresupuesto.Text = p.Presupuesto;
            labelEstudio.Text = p.Estudio;

        }
    }
}
