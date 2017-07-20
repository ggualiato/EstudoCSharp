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
    public partial class Form1 : Form
    {
        
        private Conta[] contas;

        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new Conta[10];

            Conta c1 = new Conta();
            c1.Titular = new Cliente("Victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new Conta();
            c2.Titular = new Cliente("Mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new Conta();
            c3.Titular = new Cliente("Osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);
   
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;

            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);

            if (valor <= selecionada.Saldo)
            {
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("Valor insuficiente");
            }

            
            
            
        }

       

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            Conta selecionada = contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);

        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indiceOrigem = comboContas.SelectedIndex;

            Conta selecionadaOrigem = this.contas[indiceOrigem];

            double valor = Convert.ToDouble(textoValor.Text);

            if (valor <= selecionadaOrigem.Saldo)
            {
                selecionadaOrigem.Saca(valor);

                int indiceDestino = comboDestinoTransferencia.SelectedIndex;

                Conta selecionadaDestino = this.contas[indiceDestino];

                selecionadaDestino.Deposita(valor);

                MessageBox.Show("Transferência realizada com sucesso");

            }
            else
            {
                MessageBox.Show("Saldo insuficiente para realizar a tranferência");
            }

        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add(conta.Titular.Nome);
            comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();

        }
    }
}
