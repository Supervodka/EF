using System;
using EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

using(ApplicationContext db = new ApplicationContext())
{
    //Составной ключ можно создать только с помощью Fluent API. Применение подобного ключа:
    db.Users.Add(new User { PassportSeria = "МР", PassportNumber = "6698574", Name = "Tom" });
    db.Users.Add(new User { PassportSeria = "МР", PassportNumber = "7785412", Name = "Bob" });
    db.SaveChanges();

    var users = db.Users.ToList();
    foreach (var u in users)
        Console.WriteLine($"{u.Name} : {u.PassportSeria} {u.PassportNumber}");
}

Console.Read();