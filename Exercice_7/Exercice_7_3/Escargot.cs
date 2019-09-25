namespace Exercice_7_3
{
    public class Escargot
    {
        public int Pas { get; set; }

        public string Nom { get; set; }

        public Tortue Tortue { get; set; }

        public Escargot(Tortue tortue, string nom)
        {
            Pas = 0;
            Tortue = tortue;
            Nom = nom;
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
