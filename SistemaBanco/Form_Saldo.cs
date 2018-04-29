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
    public partial class Form_Saldo : Form
    {
        private List<Conta> contas;

        public Form_Saldo(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void Form_Saldo_Load(object sender, EventArgs e)
        {

        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            int achouconta = 0;
            foreach (Conta c in contas)
            {
                double conta = c.getNumero();

                if (c.getNumero() == Convert.ToInt16(txtNumeroconta.Text))
                {
                    achouconta = 1;
                    if (c.getSenha() == txtSenha.Text)
                    {
                        txtConta.Text = Convert.ToString(txtNumeroconta.Text);
                        txtSaldo.Text = Convert.ToString(c.getSaldo());
                        groupBox1.Visible = true;


                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK);
                        txtSenha.Text = " ";
                        break;
                    }
                }
            }
            if (achouconta == 0)
            {
                MessageBox.Show("Conta não encontrada,", "Erro", MessageBoxButtons.OK);
            }
        }
    }
    }

