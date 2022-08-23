using System;
using System.Collections.Generic;
using System.Text;
using be;
using DAL;

namespace BLL
{
    public class blpackage
    {
        public void create(package p)
        {
            dapackage dap = new dapackage();

            dap.create(p);
        }
        public List<package> read()
        {
            dapackage dap = new dapackage();

            return dap.read();
        }
        public List<package> search(List<string> tags)
        {
            dapackage dap = new dapackage();

            return dap.search(tags);
        }
        public void update(package p)
        {
            dapackage dap = new dapackage();

            dap.update(p);
        }
        public package searchById(int id)
        {
            dapackage dap = new dapackage();

            return dap.searchById(id);
        }
        public List<package> searchById(List<int> ids)
        {
            dapackage dap = new dapackage();

            return dap.searchById(ids);
        }
        public void delete(package p)
        {
            dapackage dap = new dapackage();

            dap.delete(p);
        }
    }
}
