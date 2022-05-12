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
       [Column(TypeName = "varchar(200")] //VARCHAR(n) – n символов, от 1 до 32767, строковый тип переменной длины. Пробелы в конце содержимого поля игнорируются.
        public string Name { get; set; }
       




}