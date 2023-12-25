using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class duvarsaati : Saat, ISaat
    {
        private bool asilabilir;

        public duvarsaati(bool pil, bool otomatik, bool cam, bool asilabilir) : base(pil, otomatik, cam)
        {
            this.asilabilir = asilabilir;
        }

        public string SaatModelleriniYaz()
        {
            return base.name;
        }

        public void SaatBilgileriniYaz()
        {
            base.Write();
        }




    }
}
