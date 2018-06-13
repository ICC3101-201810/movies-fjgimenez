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
        public FormActor(Actor a)
        {
            InitializeComponent();
            labelNombre.Text = a.Nombre;
            labelApellido.Text = a.Apellido;
            labelFechaNacimiento.Text = a.FechaNacimiento;
            labelBiografia.Text = a.Biografia;
        }

        private void FormActor_Load(object sender, EventArgs e)
        {

        }

    }
}
