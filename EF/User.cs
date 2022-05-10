using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//По умолчанию в качестве ключа используется свойство, которое называется Id /UserId

 namespace EF
{
    public class User
    {
        public string? PassportNumber { get; set; }
        public string? PassportSeria { get; set; }
        public string? Name { get; set; }

    }

}