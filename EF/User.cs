using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//По умолчанию в качестве ключа используется свойство, которое называется Id /UserId

 namespace EF
{
    public class User
    {
        //Для установки свойства в качестве первичного ключа с помощью аннотаций применяется атрибут [Key]
        [Key]
        public int Ident { get; set; }
    }

}