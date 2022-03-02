using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab3
{
    public class Software: Product, ISellable
    {
        public String version;
        public Software(decimal cost, String latestRelease, String name)
        {
            price = cost;
            description = name;
            version = latestRelease;
        }
        public decimal sell(int count)
        {
            int quantity = count;
            return quantity * price;
        }

        public override String ToString()
        {
            return description + ", for $ " + price + "\t" + version;
        }
    }
}
