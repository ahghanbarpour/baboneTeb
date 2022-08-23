using System;
using System.Collections.Generic;
using be;
using DAL;

namespace BLL
{
    public class blquestion
    {
        public void create(question q)
        {
            daquestion daq = new daquestion();
            daq.create(q);
        }

        public List<question> read()
        {
            daquestion daq = new daquestion();

            return daq.read();
        }
        public void delete(question q)
        {
            daquestion daq = new daquestion();

            daq.delete(q);
        }
    }
}
