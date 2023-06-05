using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIMER_REPOSITORIO
{
    public partial class FRMprincipal : Form
    {
        public FRMprincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "hola mundito";
        }
    }
}
