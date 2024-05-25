using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace company_stock_api.models
{
    public class Stock
    {
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Symbol { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Purchase { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal LastDiv { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public List<Comments> StockPrices { get; set; } = new List<Comments>();
    }
}