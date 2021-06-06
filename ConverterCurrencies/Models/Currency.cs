using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterCurrencies.Models
{
    public class Currency
    {
        public DateTime Date { get; set; }
        public DateTime PreviousDate { get; set; }
        public string PreviousUrl { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<Valute> Valutes { get; set; }
    }
}
