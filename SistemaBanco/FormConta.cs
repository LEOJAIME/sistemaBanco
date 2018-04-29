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
    public partial class FormConta : Form
    {
        List<Conta> contas;
        List<Cliente> clientes;
        Cliente novoCliente = new Cliente();

        public FormConta(List<Cliente> clientes, List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
            this.clientes = clientes;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormConta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.setCliente(novoCliente);
            c.setNumero(Convert.ToInt16(textBox2.Text));
            if (textBox3.Text.Equals(textBox4.Text))
            {
                
                c.setSenha(textBox3.Text);
                MessageBox.Show("Conta criada com sucesso", "Sucesso", MessageBoxButtons.OK);
                limparcampos();
                contas.Add(c);
            }
            else
            {
                MessageBox.Show("Senha Incorreta", "Erro", MessageBoxButtons.OK);
                limparcampos();
            }
           

        }
        public void limparcampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscacliente busca = new buscacliente(novoCliente, clientes, this);
            busca.Show();
        }

        
    }
}
