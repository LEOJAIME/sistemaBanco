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
    public partial class buscacliente : Form
    {
        List<Cliente> clientes;
        FormConta novaConta;
        Cliente novoCliente;

        public buscacliente(Cliente novoCliente, List<Cliente> clientes, FormConta formpai)
        {
            InitializeComponent();
            this.clientes = clientes;
            novaConta = formpai;
            this.novoCliente = novoCliente;
            gridResultadoBusca.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gridResultadoBusca.Rows.Clear();
            List<Cliente> clientebusca = new List<Cliente>();

            gridResultadoBusca.Visible = true;

            foreach (Cliente c in clientes)
            {
                if (c.getNome().Contains(textBox1.Text))
                {
                    clientebusca.Add(c);
                }
            }  
                foreach (Cliente c in clientebusca)
                {
                    gridResultadoBusca.Rows.Add(c.getNome());
                }
            }

        

        private void gridResultadoBusca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            novaConta.textBox1.Text = gridResultadoBusca.CurrentRow.Cells[0].Value.ToString();
            novoCliente.setNome(novaConta.textBox1.Text);

            this.Close();
        }

        private void buscacliente_Load(object sender, EventArgs e)
        {

        }
    }
    }
