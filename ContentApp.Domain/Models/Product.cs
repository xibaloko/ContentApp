using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentApp.Domain.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string SkuCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PurchasePrice { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}
