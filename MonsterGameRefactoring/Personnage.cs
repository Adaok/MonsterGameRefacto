using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGameRefactoring
{
    public class Personnage
    {

        public virtual void Attaque(Personnage cible)
        {
            
        }

        public virtual void SubitDegats(int degats)
        {
            
        }

        public virtual bool EstVivant { get; }

        public virtual int LanceLeDe()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

    }
}
