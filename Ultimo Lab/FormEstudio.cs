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
    public partial class FormEstudio : Form
    {
        public FormEstudio(Estudio e)
        {
            InitializeComponent();
            labelNombre.Text = e.Nombre;
            labelDireccion.Text = e.Nombre;
            labelFechaApertura.Text = e.Nombre;
        }

        private void FormEstudio_Load(object sender, EventArgs e)
        {

        }
    }
}
