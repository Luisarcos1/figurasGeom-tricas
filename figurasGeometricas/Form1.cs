using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figurasGeometricas
{
    public partial class Form1 : Form
    {
        private object pictureboxpro;

        public Form1()

            
        {
            InitializeComponent();
        }

        private void TRIANGULO_Click(object sender, EventArgs e)
        {
            pictureboxpro.imagenes figuras  = figurasGeometricas.Program.resourse.triangulo;

        }
    }
}
