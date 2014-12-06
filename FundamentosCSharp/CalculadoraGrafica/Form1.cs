using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtPrimeiroNumero.Text != "" && txtSegundoNumero.Text != "")
                {
                    var primeiroNumero = Convert.ToDecimal(txtPrimeiroNumero.Text);
                    var segundoNumero = Convert.ToDecimal(txtSegundoNumero.Text);

                    var calculadora = new Calculadora.Calculadora(primeiroNumero, segundoNumero);

                    lblResultado.Text = Convert.ToString(calculadora.Calcular());
                }
                else
                {
                    MessageBox.Show("Informe o primeiro numero.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
