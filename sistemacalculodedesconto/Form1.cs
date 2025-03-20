using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemacalculodedesconto
{
    public partial class frmSistemaCalculoDesconto : Form
    {
        decimal valor;
        decimal desconto;
        decimal valorfinal;
        decimal porcentagem = 100;


        public frmSistemaCalculoDesconto()
        {
            InitializeComponent();
        }



        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValorCompra.Text, out valor))
            {
                lblMensagem.Text = "Insira um número válido para o valor de compra";
                return;
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDesconto.Text, out desconto))
            {
                lblMensagem.Text = "Insira um número válido para desconto";
                return;
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {

            valorfinal = valor - (valor * desconto / porcentagem);
            lblResultado.Text = Convert.ToString(valorfinal);


        }

        
    }
}
