namespace Exercice_7_1
{
    public class Escargot
    {
        public int Pas { get; set; }

        public Escargot()
        {
            Pas = 0;
        }

        public void Avancer(int nbPas)
        {
            Pas = Pas + nbPas;
        }

        public bool EstArrive()
        {
            return Pas > 25;
        }
    }
}
