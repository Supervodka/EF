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
        [Required]  //Атрибут Required указывает, что данное свойство обязательно для установки, то есть будет иметь определение NOT NULL в БД::
        public string Name { get; set; }
        //Если мы не установим свойство Name у объекта User и попытаемся добавить этот объект в бд, то получим ошибку. 
    }




}