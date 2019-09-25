namespace Exercice_7_2
{
    public class Escargot
    {
        public int Pas { get; set; }

        public Tortue Tortue { get; set; }

        public Escargot(Tortue tortue)
        {
            Pas = 0;
            Tortue = tortue;
        }

        public void Avancer(int nbPas)
        {
            Pas = Pas + nbPas + Tortue.BonusPas;
        }

        public bool EstArrive()
        {
            return Pas > 25;
        }
    }
}
