namespace MonsterGameRefactoring
{
    //classe MonstreDifficile qui hérite de MonstreFacile
    public class MonstreDifficile : MonstreFacile
    {
        //constante de dégats pour la fonction sorts
        private const int degatsSort = 5;

        //fonction d'attaque de Joueur pour le mode de jeu 1 et la classe MonstreDifficile
        public override void Attaque(Joueur joueur)
        {
            base.Attaque(joueur);
            //attaque supplémentaire
            joueur.SubitDegats(SortMagique());
        }

        //fonction sort pour l'attaque supplémentaire
        private int SortMagique()
        {
            int valeur = LanceLeDe();
            //en cas de 6 au tirage du dé, le sort échoue
            if (valeur == 6)
                return 0;
            //sinon, les dégats magiques sont multipliés par le dé
            return degatsSort * valeur;
        }
    }
}
