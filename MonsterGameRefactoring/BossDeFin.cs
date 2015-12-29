using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGameRefactoring
{
    public class BossDeFin : PersonnageAPointsDeVie
    {
        
        public BossDeFin(int points)
        {
            PtsDeVies = points;
        }

        public void Attaque(Joueur personnage)
        {
            int nbPoints = LanceLeDe(26);
            personnage.SubitDegats(nbPoints);
        }

        public override void SubitDegats(int valeur)
        {
            PtsDeVies -= valeur;
        }
    }
}
