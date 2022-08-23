using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using be;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class datest
    {
        public void create(test t)
        {
            db db = new db();
            db.tests.Add(t);
            db.SaveChanges();
        }
        public List<test> read()
        {
            db db = new db();

            return db.tests.Include(s => s.answers).ThenInclude(s => s.test).ThenInclude(s => s.package).ThenInclude(s => s.questions).ToList();
        }
        public int gettotal()
        {
            db db = new db();
            return db.tests.Count();
        }
        public List<test> getskip(int c)
        {
            int t = c * 10;
            db db = new db();
            var q = db.tests.Skip(t).Take(10);
            return q.ToList();
        }
        public string download(test t)
        {
            string dl;
            if (t.answers.Sum(s => s.point) >= t.package.pointLine)
            {
                dl = "\\assets\\PDFs\\@t.package.warmPdf";
            }
            else
            {
                dl = "\\assets\\PDFs\\@t.package.coldPdf";
            }
            return dl;
        }
    }
}
