using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGameRefactoring
{
    public class MonstreFacile : Personnage
    {
        private const int degats = 10;
        new public bool EstVivant { get; protected set; }

        public MonstreFacile()
        {
            EstVivant = true;
        }

        public virtual void Attaque(Joueur joueur)
        {
            int lanceMonstre = LanceLeDe();
            int lanceJoueur = joueur.LanceLeDe();
            if (lanceMonstre > lanceJoueur)
                joueur.SubitDegats(degats);
        }

        public void SubitDegats()
        {
            EstVivant = false;
        }

    }
}
