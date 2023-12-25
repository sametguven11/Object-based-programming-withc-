using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{ 
    internal abstract class Saat
    {

        private bool pil; // true dersem saat pilli false dersem değil  
        private bool otomatik; // true dersem saat mekanizması otomatik false dersem değil
        private bool cam; // true dersem saatin önü camdan false dersem değil
        protected string name; // Saat modellerini yaz

        public Saat(bool pil, bool otomatik, bool cam )
        {

            this.pil = pil;
            this.otomatik = otomatik;  
            this.cam = cam; 
        }

        protected void Write()
        {
            Console.WriteLine("pil" + pil);
            Console.WriteLine("otomatik" + otomatik);
            Console.WriteLine("cam" + cam);
            Console.WriteLine("****************");
        }
    }
}
