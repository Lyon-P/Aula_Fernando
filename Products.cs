using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rodrigo_Sem_Fatos
{
    internal class Products
    {
        private int ID;
        private string Descricao;
        private decimal Valor;
        public Products(int id, string descricao, decimal valor)
        {
            ID = id;
            Descricao = descricao;
            Valor = valor;
        }
        public int getID()
        {
            return ID;
        }
        public void setID(int id)
        {
            ID = id;
        }
        public string getDescricao()
        {
            return Descricao;
        }
        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public decimal getValor()
        {
            return Valor;
        }
        public void setValor(decimal valor)
        {
            if (valor < 0)
            {
                Valor = valor;
            }
        }
    }
}