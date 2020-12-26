using System.Collections.Generic;

namespace TreeviewExample.Models
{
    public class Grupo
    {
       
        public int Id { get; set; }

       
        public int BancoId { get; set; }

        public string Nome { get; set; }
                
        public List<Transações> Transações { get; set; }

      
        public decimal ValorTotal { get; set; }

       
        public bool isExpanded { get; set; } = false;//caso a treeview tenha expandido este item
                
        public bool isZeroEnabled { get; set; }//caso seja permitido exibir mesmo sem que este tenha valores
    }

    public record Transações(int pk, int fk, bool isEnabled, OfxTransação Transação)
    {
        public bool isEnabled { get; set; } = isEnabled;
    }
}