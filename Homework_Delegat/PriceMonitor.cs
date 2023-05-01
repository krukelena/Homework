using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegat
{
    public class PriceMonitor
    {
        public PriceMonitor(int lowerBound, int upperBound, FormatShow show)
        {
            Random random = new Random();
            Price = random.Next(lowerBound, upperBound);
            Show = show;
        }

        public delegate void FormatShow(int price);
        public FormatShow Show { get; set; }
        public int Price { get; set; }
    }
}
