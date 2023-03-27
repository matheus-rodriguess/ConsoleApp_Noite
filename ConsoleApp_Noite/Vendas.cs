using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Vendas
    {
        private int IdVenda;
        private string DataVenda;




        public Vendas(int idvenda, string datavenda) 
        {
            IdVenda = idvenda;
            DataVenda = datavenda;
        }

        public int getIdVenda()
        {
            return IdVenda;
        }
        public string getDataVenda()
        {
            return DataVenda;
        }
    }
}
