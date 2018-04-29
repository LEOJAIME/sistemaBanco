using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Conta
    {
        private Cliente cliente;
        private double saldo;
        private double numero;
        private String senha;


        //Cliente
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
        public Cliente getCliente()
        {
            return cliente;
        }
        //saldo
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double getSaldo()
        {
            return saldo;
        }
        //numero
        public void setNumero(double numero)
        {
            this.numero = numero;
        }
        public double getNumero()
        {
            return numero;
        }
        public void setSenha(String senha)
        {
            this.senha = senha;
        }
        public String getSenha()
        {
            return senha;
        }
    }
}
