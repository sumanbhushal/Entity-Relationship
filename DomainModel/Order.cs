using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Table("orderdescription")]
    public class Order
    {
        [Column("OrderId")]
        public int Id { get; set; }

        [Column("OrderDate")]
        public DateTime Date { get; set; }
    }
}
