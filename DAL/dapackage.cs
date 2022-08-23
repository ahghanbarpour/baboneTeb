using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using be;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class dapackage
    {
        public void create(package p)
        {
            db db = new db();
            db.packages.Add(p);
            db.SaveChanges();
        }
        public List<package> read()
        {
            db db = new db();

            return db.packages.Include(s => s.questions).ThenInclude(s => s.package).ThenInclude(s => s.tests).ToList();
        }
        public List<package> search(List<string> tags)
        {
            List<package> pa = new List<package>();
            foreach (var item in tags)
            {
                db db = new db();
                var q = from i in db.packages
                        where i.title.Contains(item.ToString()) || i.descript.Contains(item.ToString()) || i.price == Convert.ToInt64(item)
                        select i;
                pa = pa.Concat(q.ToList()).ToList();
            }
            return pa;
        }
        public void update(package p)
        {
            db db = new db();
            var q = from i in db.packages where i.packageId == p.packageId select i;
            var pp = q.Single();

            pp.title = p.title;
            pp.price = p.price;
            pp.descript = p.descript;
            pp.pic = p.pic;
            pp.warmPdf = p.warmPdf;
            pp.coldPdf = p.coldPdf;

            db.SaveChanges();
        }
        public package searchById(int id)
        {
            db db = new db();

            var q = from i in db.packages.Include(s => s.questions).ThenInclude(s => s.package)
                    where i.packageId == id
                    select i;

            return q.SingleOrDefault();
        }
        public List<package> searchById(List<int> ids)
        {
            db db = new db();
            var q = from i in db.packages.Include(s => s.questions).ThenInclude(s => s.answers) where ids.Contains(i.packageId) select i;

            return q.ToList();
        }
        public void delete(package p)
        {
            db db = new db();

            db.packages.Remove(p);
            db.SaveChanges();
        }
    }
}
