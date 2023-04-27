using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



[Table("orders")]
internal class Order
{
    [PrimaryKey, Identity, Column("id")]
    public int Id { get; set; }

    [Column("customerid")]
    public int CustomerId { get; set; }

    [Column("productid")]
    public int ProductId { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }



}

