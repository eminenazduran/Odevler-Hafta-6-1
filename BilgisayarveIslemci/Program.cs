namespace BilgisayarveIslemci
{
    class Bilgisayar
    {
        public string Model { get; set; }   
        public Islemci Islemci {  get; set; }   
        public Bilgisayar(string model, Islemci islemci) 
        {
            Model = model;
            Islemci = new Islemci(8,4);
        }

        public void IslemciOlustur(int cekirdekler, int frekans)
        {
            Islemci = new Islemci(cekirdekler, frekans);
            Console.WriteLine("Yeni bir işlemci oluşturuldu.");
        }
    }
    class Islemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; }
        public Islemci(int cekirdekler, int frekans)
        {
            Cekirdekler = cekirdekler;
            Frekans = frekans;
        }   
        public void IslemciBilgisi()
        {
            Console.WriteLine($"Çekirdek: {Cekirdekler}, Frekans: {Frekans}");
        }
    }
}
