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
        public Form2()
        {
            InitializeComponent();

        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void peliculasBtn_Click(object sender, EventArgs e)
        {
            int n = 2;
            TextBox[] textBoxes = new TextBox[n];
            Label[] labels = new Label[n];

            for (int i = 0; i < n; i++)
            {
                textBoxes[i] = new TextBox();
                // Here you can modify the value of the textbox which is at textBoxes[i]

                labels[i] = new Label();
                // Here you can modify the value of the label which is at labels[i]
            }

            // This adds the controls to the form (you will need to specify thier co-ordinates etc. first)
            for (int i = 0; i < n; i++)
            {
                this.Controls.Add(textBoxes[i]);
                this.Controls.Add(labels[i]);
            }
        }

        private void actoresBtn_Click(object sender, EventArgs e)
        {

        }

        private void directoresBtn_Click(object sender, EventArgs e)
        {

        }

        private void productoresBtn_Click(object sender, EventArgs e)
        {

        }

        private void estudiosBtn_Click(object sender, EventArgs e)
        {

        }
    }
    }

