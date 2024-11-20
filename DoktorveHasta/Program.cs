namespace DoktorveHasta
{
    class Hasta
    {
        public string Ad { get; set; }
        public string TCNo { get; set; }    
        public Doktor Doktor { get; set; }  

        public Hasta(string ad, string tcNo) 
        {
            Ad = ad;
            TCNo = tcNo;
            Doktor = new Doktor("Ayşe", "Cildiye");
        }  

        public void DoktorAtama(Doktor doktor)
        {
            Doktor = doktor;
            doktor.HastaEkle(this);
        }
    }

    class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; set; }

        public Doktor (string ad, string brans)
        {
            Ad = ad;    
            Brans = brans;  
            Hastalar = new List<Hasta> ();  
        }

        public void HastaEkle(Hasta hasta)
        {
            if (!Hastalar.Contains(hasta))
            {
                Hastalar.Add(hasta);
            }
        }
    }
}
