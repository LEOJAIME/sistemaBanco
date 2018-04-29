using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Cliente
    {
        private String nome;
        private String telefone;
        private String endereco;


        //nome
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return nome;
        }
        //telefone
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        public String geTelefone()
        {
            return telefone;
        }
        //endereco
        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }
        public String getEndereco()
        {
            return endereco;
        }
    }
}
