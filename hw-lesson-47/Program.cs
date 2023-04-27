using LinqToDB;
using LinqToDB.DataProvider.Access;
using LinqToDB.DataProvider.PostgreSQL;
using LinqToDB.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqToDB.Reflection.Methods.LinqToDB.Insert;


Console.WriteLine("Hello, World!");


var options = new DataOptions().UsePostgreSQL(Constants.ConnectionString);
var db = new ShopDb(options);

var fff = db.Customers.Where(x => x.Firstname == "ivan");


Console.WriteLine(fff.First().Lastname);











Console.ReadKey();
