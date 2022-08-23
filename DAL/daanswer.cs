using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using be;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class daanswer
    {
        public void create(answer a)
        {
            db db = new db();
            db.answers.Add(a);
            db.SaveChanges();
        }

        public List<answer> read()
        {
            db db = new db();

            return db.answers.Include(s => s.test).ThenInclude(s => s.answers).ThenInclude(s => s.question).ThenInclude(s => s.package).ToList();
        }
        public void update(answer a)
        {
            db db = new db();
            var q = from i in db.answers where i.answerId == a.answerId select i;
            answer aa = new answer();
            aa = q.Single();

            aa.question = a.question;
            aa.a = a.a;
            aa.questionId = a.questionId;
        }
        public List<answer> search(List<string> tags)
        {
            List<answer> an = new List<answer>();
            foreach (var item in tags)
            {
                db db = new db();
                var q = from i in db.answers
                        where i.question.q.Contains(item.ToString()) || i.a.Contains(item.ToString()) || i.point == Convert.ToByte(item)
                        select i;
                an = an.Concat(q.ToList()).ToList();
            }
            return an;
        }
        public List<answer> searchById(List<int> ids)
        {
            db db = new db();
            var q = from i in db.answers.Include(s => s.test).ThenInclude(s => s.package).ThenInclude(s => s.questions).ThenInclude(s => s.answers) where ids.Contains(i.answerId) select i;

            return q.ToList();
        }
        public void delete(answer a)
        {
            db db = new db();
            daquestion daq = new daquestion();
            db.answers.Remove(a);
            db.SaveChanges();
        }
        public int gettotal()
        {
            db db = new db();
            return db.answers.Count();
        }
        public List<answer> getskip(int c)
        {
            int t = c * 10;
            db db = new db();
            var q = db.answers.Include(t => t.question).Skip(t).Take(10);
            return q.ToList();
        }
    }
}
