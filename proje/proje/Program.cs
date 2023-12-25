
namespace Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SaatYonetimi manager= new SaatYonetimi();    

            kolsaati k1 = new kolsaati(true,false,true,false);
            kolsaati k2 = new kolsaati(true,true,true,false);
            kolsaati k3 = new kolsaati(false,false,true,true);
            kolsaati k4 = new kolsaati(false,true,false,true);

            duvarsaati d1 = new duvarsaati(false, false, true, true);
            duvarsaati d2 = new duvarsaati(true, false, true, false);
            duvarsaati d3 = new duvarsaati(false, true, false, true);
            duvarsaati d4 = new duvarsaati(true,true,false,false);

            manager.Add(k1);
            manager.Add(k2);
            manager.Add(k3);
            manager.Add(k4);
            manager.Add(d1);
            manager.Add(d2);
            manager.Add(d3);   
            manager.Add(d4);

            manager.KolSaatiBilgileri();
            manager.DuvarSaatiBilgileri();
            Console.ReadKey();
        }
    }
}