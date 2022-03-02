using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab3
{
    public class Book: Product, ISellable
    {
        public String auth;
        public Book(decimal cost, String isbn, String name, String author)
        {
            price = cost;
            code = isbn;
            description = name;
            auth = author;
        }

        public decimal sell(int count)
        {
            int quantity = count;
            return quantity * price; ;
        }

        public override String ToString()
        {
            return description + ", by " + auth + ", for $" + price + "\t" + code;
        }
    }
}
