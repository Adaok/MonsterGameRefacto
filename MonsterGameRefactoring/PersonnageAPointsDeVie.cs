using System;

namespace MonsterGameRefactoring
{
    //classe mère des classes Joueur et BossDeFin
    public class PersonnageAPointsDeVie : Personnage
    {
        //ovveride de la propriété d'état avec l'intégration des PV
        public override bool EstVivant
        {
            get { return PtsDeVies > 0; }
        }

        //variable des PointsDeVie
        public int PtsDeVies { get; protected set; }
        
        //fonction de lancer de dé à nombres de faces customizable
        public int LanceLeDe(int valeur)
        {
            Random random = new Random();
            return random.Next(1, valeur);
        }

    }
}
