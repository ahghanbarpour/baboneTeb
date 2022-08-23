using System;
using System.Collections.Generic;
using System.Text;
using be;
using DAL;

namespace BLL
{
    public class bltest
    {
        public void create(test t)
        {
            datest dat = new datest();

            dat.create(t);

        }
        public List<test> read()
        {
            datest dat = new datest();

            return dat.read();
        }
        public int gettotal()
        {
            datest t = new datest();
            return t.gettotal();
        }
        public List<test> getskip(int c)
        {
            datest t = new datest();
            return t.getskip(c);
        }
        public string download(test t)
        {
            datest dat = new datest();
            daanswer daa = new daanswer();
            dapackage dap = new dapackage();

            var ids = new List<int>();
            ids.Add(t.answerId);

            t.answers = daa.searchById(ids);
            t.package = dap.searchById(t.packageId);

            return dat.download(t);
        }
    }
}
