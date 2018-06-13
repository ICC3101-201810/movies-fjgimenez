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
    public partial class FormProductor : Form
    {
        public FormProductor(Productor pr)
        {
            InitializeComponent();
            labelNombre.Text = pr.Nombre;
        }

        private void FormProductor_Load(object sender, EventArgs e)
        {

        }
    }
}
