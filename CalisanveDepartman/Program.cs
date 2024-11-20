namespace CalisanveDepartman
{

    internal class Departman
    {
        public string Ad { get; set; }
        string Lokasyon { get; set; }

        public Departman(string ad, string lokasyon)
        {
            Ad = ad;
            Lokasyon = lokasyon;
        }
    }

    internal class Calisan
    {
        public string Ad { get; set; }
        string Pozisyon { get; set; }
        public Departman Departman { get; set; }

        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
            Departman = new Departman("Yazılım", "Elazığ");
        }

        public void DepartmanAtama(Departman departman)
        {
            Departman = departman;
        }
    }
}
