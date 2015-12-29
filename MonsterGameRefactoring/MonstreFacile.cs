namespace MonsterGameRefactoring
{
    //classe Monstre Facile qui hérite de Personnage
    public class MonstreFacile : Personnage
    {
        //constante de dégats pour la fonction Attaque
        private const int degats = 10;

        //nouvelle propriété d'état
        new public bool EstVivant { get; protected set; }

        //Constructeur
        public MonstreFacile()
        {
            EstVivant = true;
        }

        //fonction d'attaque de Joueur pour le mode de jeu 1
        public virtual void Attaque(Joueur joueur)
        {
            int lanceMonstre = LanceLeDe();
            int lanceJoueur = joueur.LanceLeDe();
            if (lanceMonstre > lanceJoueur)
                joueur.SubitDegats(degats);
        }

        //fonction override de prise de dégats
        public void SubitDegats()
        {
            EstVivant = false;
        }

    }
}
