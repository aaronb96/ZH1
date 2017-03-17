using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Hóvirág : Verseny
    {
        public Hóvirág(string _sorszam,int _tavolsag=0)
        {
            this.sorszam = _sorszam;
            this.tavolsag = _tavolsag;
        }

        public void földbe_gyökerezes()
        {
            Console.WriteLine("sorszam:{0}", sorszam);
            Console.WriteLine("tavolsag:{0}",tavolsag );
        }
    }
}