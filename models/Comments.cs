using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_stock_api.models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int? StockId { get; set; }
        public Stock? Stock { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}