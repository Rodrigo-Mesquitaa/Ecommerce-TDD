using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ModelData.Model
{
    public class Venda : BaseEntity
    {
        [Required]
        [ForeignKey("Cliente")]
        public long Cliente_Id { get; set; }

        public virtual Cliente Cliente { get; set; }

        public decimal CashBackTotal { get; set; }

        public virtual List<VendaItem> Itens { get; set; }
    }
}
