using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vendors.API.Models
{
    public class VendorStock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int VendorId { get; set; }
        public int HandInStocks { get; set; }
        public DateTime ReplinshmentDate { get; set; }
        public Vendor Vendor { get; set; }
    }
}
