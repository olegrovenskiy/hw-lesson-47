using LinqToDB;



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
// запрос, который возвращает список всех пользователей старше 30 лет, у которых есть заказ на продукт с ID=1



var abc =  from c in db.Customers
           join o in db.Orders on c.Id equals o.CustomerId
           join p in db.Products on o.ProductId equals p.Id
           where c.Age > 30 && o.ProductId == 1
           select new
           {
            first = c.Firstname,
            last = c.Lastname,
            product = p.Name,
            quant = o.Quantity,
            price = p.Price

           };



foreach (var a in abc)
    Console.WriteLine(a.first + "  " + a.last + "  " + a.product + "  " + a.quant + "  " + a.price);



Console.ReadKey();

