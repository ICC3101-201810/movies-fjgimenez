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
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peliculasBtn_Click(object sender, EventArgs e)
        {

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

