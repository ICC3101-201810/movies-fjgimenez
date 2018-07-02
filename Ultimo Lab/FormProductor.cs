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
        BaseDatos db = new BaseDatos();

        public FormProductor(Productor pr)
        {
            InitializeComponent();
            labelNombre.Text = pr.Nombre;
            labelApellido.Text = pr.Apellido;
            labelFechaNacimiento.Text = pr.FechaNacimiento;
            labelBiografia.Text = pr.Biografia;

            db.productor.Add(new Productor("Claudio", "Troncoso", "2/5/1977", "malo"));
            db.peliculaproductor.Add(new PeliculaProductor("Avengers", "Claudio", "Troncoso"));

            for (int i = 0; i < this.db.peliculaproductor.Count; i++)
            {
                if (this.db.peliculaproductor[i].NombreProductor == pr.Nombre & this.db.peliculaproductor[i].ApellidoProductor == pr.Apellido)
                {
                    for (int j = 0; j < this.db.productor.Count; j++)
                    {
                        if (this.db.peliculaproductor[i].NombreProductor== this.db.productor[j].Nombre & this.db.peliculaproductor[i].ApellidoProductor == this.db.productor[j].Apellido)
                        {
                            //Create label
                            Label label = new Label();
                            label.Text = String.Format("{0}-{1}", i + 1, this.db.peliculaproductor[i].NombrePelicula);
                            //Position label on screen
                            label.Left = 320;
                            label.Top = (i + 1) * 30 + 30;
                            this.Controls.Add(label);
                        }
                    }
                }
            }
        }
    
        private void FormProductor_Load(object sender, EventArgs e)
        {

        }
    }
}
