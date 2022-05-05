using System;
using System.Linq;
using EF;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder(); //класс для создания конфигурации

//установка пути к текущему каталогу
builder.SetBasePath(Directory.GetCurrentDirectory());

//получаем конфигурацию из файла appsettings.json
builder.AddJsonFile("appsettings.json");   //метод AddJsonFile() добавляет все настройки из файла конфигурации

//создаём конфигурацию
var config = builder.Build();// Build() создаёт объект конфигрурации из которого мы можем получить строку подключения 

//получаем строку подключения 
string connectionString = config.GetConnectionString("DefaultConnection"); //Для получения строки подключения используется ее имя - "DefaultConnection", которое указано в appsettings.json.

var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder
    .UseSqlServer(connectionString)
    .Options;

using (ApplicationContext db = new ApplicationContext(options))
{
    var users = db.Users.ToList();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

Console.Read();
