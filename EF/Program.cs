using System;
using System.Linq;
using EF;
using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = db.Users.OrderByDescending().FirstOrDefault();
                db.Users.Remove(user1);
                db.SaveChanges();
                Console.WriteLine("Success");
}
    Console.Read();