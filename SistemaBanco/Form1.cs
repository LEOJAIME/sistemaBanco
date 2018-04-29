using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBanco
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes;
        List<Conta> contas;

        public Form1()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            contas = new List<Conta>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja finalizar a aplicação?", "Confirmação", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente(clientes);
            formCliente.Show();
        }

        private void novaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConta formConta = new FormConta(clientes, contas);
            formConta.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxFormPrincipal.Visible = true;
            dataGridView1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Cliente> clientebusca = new List<Cliente>();
            foreach (Cliente c in clientes)
            {
                if (c.getNome().Contains(textBoxformprincipal.Text))
                {
                    clientebusca.Add(c);
                } 
            }
            if (clientebusca.Count() == 0)
            {
                lbNenhumRegistro.Visible = true;
                dataGridView1.Visible = false;
            }
            else
            {

                dataGridView1.Visible = true;
                lbNenhumRegistro.Visible = false;
                foreach (Cliente c in clientebusca)
                {
                    dataGridView1.Rows.Add(c.getNome(), c.geTelefone(), c.getEndereco());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxformprincipal.Text = "";
            dataGridView1.Rows.Clear();
            lbNenhumRegistro.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacao form = new Operacao("saque", contas);
            form.Show();          
        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacao form = new Operacao("depositar", contas);
            form.Show();
        }

        private void groupBoxFormPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void verificarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Saldo ver_saldo = new Form_Saldo(contas);
            ver_saldo.Show();

        }
    }
}
