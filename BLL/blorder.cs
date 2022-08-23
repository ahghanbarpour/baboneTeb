using System;
using System.Collections.Generic;
using System.Text;
using be;
using DAL;

namespace BLL
{
    public class blorder
    {
        public void create(Order o)
        {
            daorder dao = new daorder();
            
            dao.create(o);
        }
        public List<Order> read()
        {
            daorder dao = new daorder();

            return dao.read();
        }
        public Order searchById(int id)
        {
            daorder dao = new daorder();

            return dao.searchById(id);
        }
        public Order searchById(List<int> ids)
        {
            daorder dao = new daorder();

            return dao.searchById(ids);
        }
        public int gettotal()
        {
            daorder dao = new daorder();
            return dao.gettotal();
        }
        public List<Order> getskip(int c)
        {
            daorder dao = new daorder();
            return dao.getskip(c);
        }
    }
}
