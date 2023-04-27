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

// 1. Определиться с ORM: Dapper (Linq2Db). ---  Linq2Db
// 2. Выбрать какую БД использовать -- из задания "Кластерный индекс"
// 3. написать строку подключения к БД и использовать ее для подключения

var options = new DataOptions().UsePostgreSQL(Constants.ConnectionString);
var db = new ShopDb(options);

// 3. Создать классы, которые описывают таблицы в БД

// Варианты запросов

var fff = db.Customers.Where(x => x.Firstname == "ivan");
var aaa = db.Products.Where(x => x.Id == 1);
var bbb = db.Orders.Where(x => x.Id == 1);

Console.WriteLine(fff.First().Lastname + "   " + aaa.First().Name + "   " + bbb.First().Quantity);


var ccc = db.Orders.Where(x => x.CustomerId == 2).OrderBy(x => x.Id);

foreach (var rrr in ccc)
    Console.WriteLine(rrr.ProductId + "  " + rrr.Quantity);


var ddd = db.Orders.Where(x => x.ProductId == 1);

var ggg = db.Customers.Where(x => x.Id == ddd.First().CustomerId).Where(x => x.Age > 30);
   
Console.WriteLine(ggg.First().Firstname + ggg.First().Lastname);



// 4. Выполнить все запросы, из выбранного ранее задания с передачей параметров.











Console.ReadKey();
