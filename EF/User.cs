using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF
{
    public class Product
    {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }
    [NotMapped]
    public string? Description { get; set; }
    }

}
