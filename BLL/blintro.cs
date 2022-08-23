using System;
using System.Collections.Generic;
using System.Text;
using be;
using DAL;

namespace BLL
{
    public class blintro
    {
        public void addIntro(Introduction i)
        {
            daintro dai = new daintro();
            dai.addIntro(i);
        }
        public List<Introduction> read()
        {
            daintro dai = new daintro();

            return dai.read();
        }
        public Introduction searchById(int id)
        {
            daintro dai = new daintro();

            return dai.searchById(id);
        }
    }
}
