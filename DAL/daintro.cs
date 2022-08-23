using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using be;

namespace DAL
{
    public class daintro
    {
        public void addIntro(Introduction i)
        {
            db db = new db();
            db.introduction.Add(i);
            db.SaveChanges();
        }
        public List<Introduction> read()
        {
            db db = new db();

            return db.introduction.ToList();
        }
        public Introduction searchById(int id)
        {
            db db = new db();
            var q = from i in db.introduction where i.id == id select i;

            return q.SingleOrDefault();
        }
    }
}
