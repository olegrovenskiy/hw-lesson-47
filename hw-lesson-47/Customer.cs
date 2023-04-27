using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    [Table("customers")]
    internal class Customer
    {
        [PrimaryKey, Identity, Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }


        [Column("age"), NotNull]
        public int Age { get; set; }

     }





