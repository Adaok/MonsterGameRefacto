namespace MonsterGameRefactoring
{
    //classe BossDeFin qui hérite de PersonnageAPointsDeVie
    public class BossDeFin : PersonnageAPointsDeVie
    {
        //Constructeur
        public BossDeFin(int points)
        {
            PtsDeVies = points;
        }

        //fonction d'attaque de Joueur pour le mode de jeu 2
        public void Attaque(Joueur personnage)
        {
            int nbPoints = LanceLeDe(26);
            personnage.SubitDegats(nbPoints);
        }

        //fonction override de prise de dégats
        public override void SubitDegats(int valeur)
        {
            PtsDeVies -= valeur;
        }
    }
}
