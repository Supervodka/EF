using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//По умолчанию в качестве ключа используется свойство, которое называется Id /UserId

namespace EF
{

    public class User
    {
        public int Id { get; set; }
        [MaxLength(50)]  //В аннотациях данных ограничение по длине устанавливается с помощью атрибута MaxLength:
        public string Name { get; set; }
        //В этом случае для столбец Name в базе данных будет иметь тип nvarchar(50).
    }




}