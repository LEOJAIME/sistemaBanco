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
    public partial class Operacao : Form
    {
        public String operacao;
        public List<Conta> contas;

        public Operacao(String operacao, List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
            this.operacao = operacao;
            if (operacao.Equals("saque"))
            {
                button1.Text = "Sacar";
            }
            else
            {
                button1.Text = "Depositar";
            }
        }

        private void Operação_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int achouconta = 0;
            foreach(Conta c in contas)
            {
                double conta = c.getNumero();

                if (c.getNumero() == Convert.ToInt16(textBox1.Text))
                {
                    achouconta = 1;
                    if(c.getSenha() == textBox2.Text)
                    {
                        if (operacao.Equals("saque"))
                        {
                            if (c.getSaldo() < Convert.ToInt16(textBox3.Text))
                            {
                                MessageBox.Show("Saldo insuficiente!", "Erro", MessageBoxButtons.OK);
                            }
                            else
                            {
                                c.setSaldo(c.getSaldo() - Convert.ToInt16(textBox3.Text));
                                MessageBox.Show("Saque efetuado com sucesso", "Sucesso", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            c.setSaldo(c.getSaldo() + Convert.ToInt16(textBox3.Text));
                            MessageBox.Show("Deposito efetuado com sucesso", "Sucesso", MessageBoxButtons.OK);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK);
                        textBox2.Text = " ";
                        break;
                    }
                }
            }
            if(achouconta == 0)
            {
                MessageBox.Show("Conta não encontrada,", "Erro", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
