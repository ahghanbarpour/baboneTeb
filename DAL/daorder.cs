using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using be;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class daorder
    {
        public void create(Order o)
        {
            db db = new db();
            db.orders.Add(o);
            db.SaveChanges();

        }
        public List<Order> read()
        {
            db db = new db();

            return db.orders.Include(t => t.Order_Packages).ThenInclude(t => t.package).ToList();
        }
        public Order searchById(int id)
        {
            db db = new db();

            var q = from i in db.orders where i.orderId == id select i;

            return q.SingleOrDefault();
        }
        public Order searchById(List<int> ids)
        {
            db db = new db();

            var q = from i in db.orders.Include(s => s.Order_Packages).ThenInclude(s => s.package) where ids.Contains(i.orderId) select i;

            return q.SingleOrDefault();
        }
        public int gettotal()
        {
            db db = new db();
            return db.orders.Count();
        }
        public List<Order> getskip(int c)
        {
            int t = c * 10;
            db db = new db();
            var q = db.orders.Include(t => t.user).Skip(t).Take(10);
            return q.ToList();
        }
    }
}
