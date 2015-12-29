using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGameRefactoring
{
    public class BossDeFin
    {
        public int PtsDeVies { get; private set; }
        public bool EstVivant
        {
            get { return PtsDeVies > 0; }
        }

        public BossDeFin(int points)
        {
            PtsDeVies = points;
        }

        public void Attaque(Joueur personnage)
        {
            int nbPoints = LanceLeDe(26);
            personnage.SubitDegats(nbPoints);
        }

        public void SubitDegats(int valeur)
        {
            PtsDeVies -= valeur;
        }

        private int LanceLeDe(int valeur)
        {
            return De.LanceLeDe(valeur);
        }
    }
}
