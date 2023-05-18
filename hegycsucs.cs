using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHegyei
{
    class hegycsucs
    {
        private string hegycsúcs;

        public string Hegycsúcs
        {
            get { return hegycsúcs; }
        }

        private string hegyseg;

        public string Hegyseg { get { return hegyseg; } }

        private int magassag;

        public int Magassag { get { return magassag; } }

        public hegycsucs(string hegycsúcs, string hegyseg, int magassag)
        {
            this.hegycsúcs = hegycsúcs;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
        }

    }
}