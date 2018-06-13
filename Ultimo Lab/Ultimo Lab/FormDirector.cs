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
    public partial class FormDirector : Form
    {
        public FormDirector(Director d)
        {
            InitializeComponent();
            labelNombre.Text = d.Nombre;
        }

        private void FormDirector_Load(object sender, EventArgs e)
        {

        }
    }
}
