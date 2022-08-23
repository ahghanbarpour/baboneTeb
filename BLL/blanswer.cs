using System;
using System.Collections.Generic;
using System.Text;
using be;
using DAL;

namespace BLL
{
    public class blanswer
    {
        public void create(answer a)
        {
            daanswer daa = new daanswer();
            daa.create(a);
        }

        public List<answer> read()
        {
            daanswer daa = new daanswer();

            return daa.read();
        }
        public void update(answer a)
        {
            daanswer daa = new daanswer();
            daa.update(a);
        }
        public void delete(answer a)
        {
            daanswer daa = new daanswer();

            daa.delete(a);
        }
        public List<answer> search(List<string> tags)
        {
            daanswer daa = new daanswer();

            return daa.search(tags);
        }
        public int gettotal()
        {
            daanswer a = new daanswer();
            return a.gettotal();
        }
        public List<answer> getskip(int c)
        {
            daanswer a = new daanswer();
            return a.getskip(c);
        }
    }
}
