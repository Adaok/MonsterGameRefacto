namespace MonsterGameRefactoring
{
    //classe Joueur qui hérite de PersonnageAPointsDeVie
    public class Joueur : PersonnageAPointsDeVie
    {
        //Constructeur
        public Joueur(int points)
        {
            PtsDeVies = points;
        }

        //fonction d'attaque de Monstre pour le mode de jeu 1
        public void Attaque(MonstreFacile monstre)
        {
            int lanceJoueur = LanceLeDe();
            int lanceMonstre = monstre.LanceLeDe();
            if (lanceJoueur >= lanceMonstre)
                monstre.SubitDegats();
        }

        //fonction d'attaque de BossDeFin pour le mode de jeu 2
        public void Attaque(BossDeFin boss)
        {
            int nbPoints = LanceLeDe(26);
            boss.SubitDegats(nbPoints);
        }

        //fonction override de prise de dégats
        public override void SubitDegats(int degats)
        {
            if (!BouclierFonctionne())
                PtsDeVies -= degats;
        }

        //fonction de Sauvegarde bouclier
        private bool BouclierFonctionne()
        {
            return LanceLeDe() <= 2;
        }
    }
}
