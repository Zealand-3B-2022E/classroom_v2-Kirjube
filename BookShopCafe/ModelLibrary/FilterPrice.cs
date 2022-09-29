using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class FilterPrice
    {
        public int? StartPrice { get; set; }
        public int? EndPrice { get; set; }

        public record BookPriceFilter (int StartPrice, int EndPrice );
    }
}
