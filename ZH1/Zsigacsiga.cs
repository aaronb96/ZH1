using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Zsigacsiga : Trémedve
    {
        public Zsigacsiga(string sorszam, int sebesseg,int tavolag) : base(sorszam, sebesseg,tavolag)
        {
        }

        public void ordit()
        {
            tavolsag = tavolsag - 2;
        }
    }
}