using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF
{
    public class Product
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    //навигациооные свойство
    public Company Manufacturer { get; set; }
    }

    [NotMapped]
    public class Company
    {
        public int Id { get; set; }
        public  string Name { get; set; }
    }

    public class Country
    {
        public string? Name { get; set; }
        public int Id { get; set; }
    }
}
