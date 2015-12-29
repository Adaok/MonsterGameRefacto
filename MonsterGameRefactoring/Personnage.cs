using System;

namespace MonsterGameRefactoring
{
    //classe mère
    public class Personnage
    {
        //fonction d'attaque
        public virtual void Attaque(Personnage cible)
        {
            
        }

        //fonction de prise de dégats
        public virtual void SubitDegats(int degats)
        {
            
        }

        //propriété d'état mort ou vivant (via un bool)
        public virtual bool EstVivant { get; }

        //Fonction de lancer de dé à 6 faces
        public virtual int LanceLeDe()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

    }
}
