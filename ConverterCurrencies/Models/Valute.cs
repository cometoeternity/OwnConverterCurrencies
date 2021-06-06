using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterCurrencies.Models
{
    public class Valute
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int NumCode { get; set; }
        public int Nominal { get; set; }
        public string RusName { get; set; }
        public double Value { get; set; }
        public double PreviousValue { get; set; }
    }
}
