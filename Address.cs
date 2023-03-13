using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rodrigo_Sem_Fatos
{
    internal class Address
    {
        private int ID;
        private string Cep;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cidade;
        public Address(int id, string cep, string rua, string numero, string bairro, string cidade)
        {
            ID = id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }
        public int getID()
        {
            return ID;
        }
        public void setID(int id)
        {
            ID = id;
        }
        public string getCep()
        {
            return Cep;
        }
        public void setCep(string cep)
        {
            Cep = cep;
        }
        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public string getNumero()
        {
            return Numero;
        }
        public void setNumero(string numero)
        {
            Numero = numero;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
    }
}