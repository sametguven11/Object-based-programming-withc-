using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal sealed class SaatYonetimi
    {
        List <kolsaati> kolsaatleri = new List<kolsaati>();
        List<duvarsaati> duvarsaatleri = new List<duvarsaati>();

        public SaatYonetimi() 
        {
        
        }

        public SaatYonetimi(kolsaati Kolsaati) 
        {
            Add (Kolsaati);

        }

        public SaatYonetimi(duvarsaati DuvarSaati) 
        {
            Add (DuvarSaati);        
        
        }

        public void Add(kolsaati Kolsaati) 
        {
        kolsaatleri.Add (Kolsaati);
        }

        public void Add(duvarsaati DuvarSaati) 
        {
         duvarsaatleri.Add (DuvarSaati);
        }


        public void KolSaatiBilgileri() {
            foreach(var item in kolsaatleri)
            {
                item.SaatBilgileriniYaz();
            }
        }

        public void DuvarSaatiBilgileri() {

            foreach(var item in duvarsaatleri)
            {
                item.SaatBilgileriniYaz();  
            }
        }





    }
}
