using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//По умолчанию в качестве ключа используется свойство, которое называется Id /UserId

namespace EF
{

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        public int Ident { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }



}