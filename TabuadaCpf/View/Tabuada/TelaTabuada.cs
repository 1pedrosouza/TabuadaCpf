using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTabuadaCPF.View.Tabuada
{
    public partial class TelaTabuada : Form
    {
        public TelaTabuada()
        {
            InitializeComponent();
        }

        private void CalcularTabuada()
        {
            int numero = 0;


            numero = Convert.ToInt32(tbxNumero.Text);

            for (int i = 0; i < 10; i++)
            {

                lbxResultado.Items.Add(numero + " X " + i + " = " + i * numero);
            }


        }

        private void LimparTela()
        {
            lbxResultado.Items.Clear();
            tbxNumero.Clear();
            tbxNumero.Focus();
        }

        

        private void tbxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimparTela();
            if(e.KeyChar == 13)
            CalcularTabuada();

        }

        private void tbxNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
  
