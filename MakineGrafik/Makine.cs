using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakineGrafik
{
    internal class Makine
    {
        public string MakineAdı { get; set; }
        public DateTime Tarih { get; set; }
        public int HedefMiktar { get; set; }
        public int UretilenMiktar { get; set; }

        public Dictionary<DateTime, int[]> veri = new Dictionary<DateTime, int[]>()
        {    
        };

        public void veriEkle(DateTime dateTime, int[] Miktar)
        {
            veri.Add(dateTime, Miktar);
        }
        
        public List<Makine> MakineGetir()
        {
            
            List<Makine> makineler = new List<Makine>();    
            foreach(var kontrol in veri)
            {
                Makine makine = new Makine();
                makine.MakineAdı = this.MakineAdı;
                makine.Tarih = kontrol.Key;

                int[] dizi = kontrol.Value;
                
                makine.HedefMiktar = dizi[0];
                makine.UretilenMiktar = dizi[1];
                makineler.Add(makine);

            }

            return makineler;
        }

        public List<Makine> BelirliAraliktaMakineCiz(DateTime baslangic,DateTime bitis)
        {

            List<Makine> makineler = new List<Makine>();

            
            foreach (var kontrol in veri)
            {
                if (baslangic <= kontrol.Key && kontrol.Key <= bitis)
                {

                    Makine makine = new Makine();
                    makine.MakineAdı = this.MakineAdı;
                    makine.Tarih = kontrol.Key;

                    int[] dizi = kontrol.Value;

                    makine.HedefMiktar = dizi[0];
                    makine.UretilenMiktar = dizi[1];
                    makineler.Add(makine);
                }

            }

            return makineler;
        }
    }
}
