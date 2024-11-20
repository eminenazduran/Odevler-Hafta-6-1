namespace EbeveynveCocuk
{
    class Ebeveyn
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Cocuk> Cocuklar { get; set; }

        public Ebeveyn(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
            Cocuklar = new List<Cocuk>();
        }

        public void CocukEkle(Cocuk cocuk)
        {
            if (!Cocuklar.Contains(cocuk))
                Cocuklar.Add(cocuk);
        }
    }

    class Cocuk
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; set; }
        
        public Cocuk (string ad, int yas, Ebeveyn ebeveyn)
        {
            Ad = ad;    
            Yas = yas;
            Ebeveyn = ebeveyn;
        }
        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;
            ebeveyn.CocukEkle(this);
        }
    }
}
