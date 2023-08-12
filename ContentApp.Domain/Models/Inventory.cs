using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentApp.Domain.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
