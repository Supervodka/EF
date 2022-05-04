using EF;
using System;
using System.Linq;

using (ApplicationContext db = new ApplicationContext())
{
    User user1 = db.Users.FirstOrDefault();
    User user2 = db.Users.LastOrDefault();
    db.Users.RemoveRange(user1,user2);
}
Console.ReadKey();