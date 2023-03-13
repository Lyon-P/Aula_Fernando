using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rodrigo_Sem_Fatos
{
    internal class Customers
    {
        private int Id;
        private string Nome;
        private string Tel;
        public Customers(int id, string Nome, string Tel)
        {
            Id = id;
            Nome = "João";
            Tel = "16-9912 2832";
        }
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getTel()
        {
            return Tel;
        }
        public void setTel(string tel)
        {
            Tel = tel;
        }
    }
}