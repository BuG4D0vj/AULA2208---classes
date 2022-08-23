using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA2208
{
    internal class Pedido
    {
        int numero;
        int quantidade;
        double total;
        public void setNumero(int numero)
            { 
            this.numero = numero; 
        }
        public int getNumero()
        {  
            return this.numero;
        }
        public void setQuanntidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public int getQuantidade()
        {
            return this.quantidade;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }
        public double getTotal()
        {
            return this.total;
        }
    }
}