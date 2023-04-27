using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class ShopDb : LinqToDB.Data.DataConnection
    {
        public ShopDb(DataOptions options) : base(options)
        {

        }
        public ITable<Customer> Customers => this.GetTable<Customer>();
    }

