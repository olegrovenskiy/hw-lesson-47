using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



[Table("products")]
internal class Product
{
    [PrimaryKey, Identity, Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("description")]
    public string Description { get; set; }


    [Column("stockquantity")]
    public int StockQuantity { get; set; }

    [Column("price")]
    public int Price { get; set; }


}



