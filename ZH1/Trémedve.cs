using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Trémedve : Verseny
    {
        private int sebesseg;

        public Trémedve(string _sorszam,int _sebesseg,int _tavolsag)
        {
            this.sorszam = _sorszam;
            this.sebesseg = _sebesseg;
            this.tavolsag = _tavolsag;
        }

        public void ordit()
        {
            Console.WriteLine("sorszam:{0}", sorszam);
            Console.WriteLine("sebessseg:{0}", sebesseg);
            Console.WriteLine("tavolsag:{0}", tavolsag);
        }
    }
}