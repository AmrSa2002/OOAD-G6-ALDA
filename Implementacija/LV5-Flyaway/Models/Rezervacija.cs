namespace LV5_Flyaway.Models
{
    public class Rezervacija
    {
        int Id, BrojLeta;
        public Rezervacija(int Id, int BrojLeta)
        {
            this.Id = Id;
            this.BrojLeta = BrojLeta;
        }

        public double obracunajCijenu(double cijena)
        {
            cijena = BrojLeta * 300; //pretpostavka cijena = 300KM po letu
            return cijena;

        }
    }
}
