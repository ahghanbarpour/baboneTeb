using System;
using System.Collections.Generic;
using System.Linq;
using be;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class daquestion
    {
        public void create(question q)
        {
            db db = new db();
            db.questions.Add(q);
            db.SaveChanges();
        }

        public List<question> read()
        {
            db db = new db();

            return db.questions.Include(s => s.answers).ThenInclude(s => s.question).ThenInclude(s => s.package).ToList();
        }
        public List<question> search(List<string> tags)
        {
            List<question> qu = new List<question>();
            foreach (var item in tags)
            {
                db db = new db();
                var q = from i in db.questions.Include(s => s.package)
                        where i.q.Contains(item.ToString()) || i.package.title.Contains(item.ToString())
                        select i;
                qu = qu.Concat(q.ToList()).ToList();
            }
            return qu;
        }
        public question searchById(int id)
        {
            db db = new db();

            var q = from i in db.questions.Include(s => s.package) where i.questionId == id select i;

            return q.SingleOrDefault();
        }
        public List<question> searchById(List<int> ids)
        {
            db db = new db();
            var q = from i in db.questions.Include(s => s.package) where ids.Contains(i.questionId) select i;

            return q.ToList();
        }
        public void delete(question q)
        {
            db db = new db();
            db.questions.Remove(q);
            db.SaveChanges();
        }
    }
}
