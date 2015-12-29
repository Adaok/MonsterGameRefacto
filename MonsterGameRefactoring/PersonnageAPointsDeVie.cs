using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGameRefactoring
{
    public class PersonnageAPointsDeVie : Personnage
    {
        public override bool EstVivant
        {
            get { return PtsDeVies > 0; }
        }

        public int PtsDeVies { get; protected set; }
        
        public int LanceLeDe(int valeur)
        {
            return De.LanceLeDe(valeur);
        }

    }
}
