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
    public partial class Form3 : Form
    {

        public Form3(Pelicula p)
        {
            
            InitializeComponent();
            label1.Text = p.Nombre;
        }
    }
}
