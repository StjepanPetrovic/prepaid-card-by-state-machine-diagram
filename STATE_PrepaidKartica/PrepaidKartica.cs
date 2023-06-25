using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    public class PrepaidKartica
    {
        public string SerijskiBroj { get; set; }
        public double Iznos { get; set; }

        public PrepaidKartica(string serijskiBroj)
        {
            SerijskiBroj = serijskiBroj;
        }

        public void Aktiviraj()
        {
            Iznos = 100;
        }

        public void Uplati(double iznosUplate)
        {
            Iznos += iznosUplate;
        }

        internal void Isplati(double iznosIsplate)
        {
            Iznos -= iznosIsplate;
        }
    }
}
