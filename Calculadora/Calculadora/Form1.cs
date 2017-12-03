using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                tbCalculo.Text = new Calculadora.Formula(tbCalculo.Text).Resultado;
            }
            catch(Exception ex)
            {
                errorProvider.SetError(tbCalculo, ex.Message);
            }
        }

        private void tbCalculo_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.MessageBox.Show(Linguagem.HelpCalculo, "Help");
        }
    }
}
