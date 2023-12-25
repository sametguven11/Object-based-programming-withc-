using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class kolsaati : Saat, ISaat
    {
        private bool kordon;

        public kolsaati(bool pil, bool otomatik, bool cam, bool kordon) : base(pil, otomatik, cam)
        {
            this.kordon = kordon;
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
