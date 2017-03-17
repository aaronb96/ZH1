using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{

    public enum lepes
    {
        lep1,
        lep2,
        all

    }



    public class Szöcske : Verseny
    {
        



        private int sebesseg;

        public Szöcske(string _sorszam,int _sebesseg)
        {
            this.sorszam = _sorszam;
            this.sebesseg = _sebesseg;
        }

        Random rnd = new Random();

        public int elöszombat(lepes lépés)
        {
            switch (lépés)
            {
                case lepes.lep1:return rnd.Next(0, 2);
                case lepes.lep2: return rnd.Next(0, 2);
                case lepes.all: return rnd.Next(0, 2);

            }
            return 3;
        }
    }
}