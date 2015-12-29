using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGameRefactoring
{
    public class MonstreDifficile : MonstreFacile
    {
        private const int degatsSort = 5;

        public override void Attaque(Joueur joueur)
        {
            base.Attaque(joueur);
            joueur.SubitDegats(SortMagique());
        }

        private int SortMagique()
        {
            int valeur = LanceLeDe();
            if (valeur == 6)
                return 0;
            return degatsSort * valeur;
        }
    }
}
