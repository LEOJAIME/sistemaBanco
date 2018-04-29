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
    public partial class FormCliente : Form
    {
        List<Cliente> clientes;
        public FormCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.setNome(textBox1.Text);
            c.setTelefone(textBox2.Text);
            c.setEndereco(textBox3.Text);
            MessageBox.Show("Cliente salvo com sucesso", "Sucesso", MessageBoxButtons.OK);
            limparcampos();
            clientes.Add(c);

        }
        public void limparcampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}