using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            
            string tipoConta = Convert.ToString(comboTipoConta.SelectedItem);

            if(tipoConta.Equals("Conta-Corrente")){
                Conta novaConta = new ContaCorrente();
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                MessageBox.Show("Cadastro conta corrente realizado com sucesso");
                this.formPrincipal.AdicionaConta(novaConta);
            }

            if (tipoConta.Equals("Conta-Poupança"))
            {
                Conta novaConta = new ContaPoupanca();
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                MessageBox.Show("Cadastro conta poupanca realizado com sucesso");
                this.formPrincipal.AdicionaConta(novaConta);
            }

        }
    }
}
