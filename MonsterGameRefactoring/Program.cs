using System;

namespace MonsterGameRefactoring
{
    class Program
    {
        //Variable pour les tirages au sort
        private static Random random = new Random();

        //Main
        static void Main(string[] args)
        {
            AfficheMenu();
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            //boucle de saisie pour le menu
            while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 && consoleKeyInfo.Key != ConsoleKey.NumPad1 && consoleKeyInfo.Key != ConsoleKey.NumPad2)
            {
                AfficheMenu();
                consoleKeyInfo = Console.ReadKey(true);
            }
            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                Jeu1();
            else
                Jeu2();
        }

        //fonction affichage
        private static void AfficheMenu()
        {
            Console.Clear();
            Console.WriteLine("Veuillez choisir votre mode de jeu :");
            Console.WriteLine("\t1 : Contre les monstres");
            Console.WriteLine("\t2 : Contre le boss de fin");
        }

        //Lancement et déroulement du jeu n1 avec ses arguments
        private static void Jeu1()
        {
            Joueur nicolas = new Joueur(150);
            int cptFacile = 0;
            int cptDifficile = 0;
            while (nicolas.EstVivant)
            {
                MonstreFacile monstre = FabriqueDeMonstre();
                while (monstre.EstVivant && nicolas.EstVivant)
                {
                    nicolas.Attaque(monstre);
                    if (monstre.EstVivant)
                        monstre.Attaque(nicolas);
                }

                if (nicolas.EstVivant)
                {
                    if (monstre is MonstreDifficile)
                        cptDifficile++;
                    else
                        cptFacile++;
                }
                else
                {
                    Console.WriteLine("Snif, vous êtes mort...");
                    break;
                }
            }
            Console.WriteLine("Bravo !!! Vous avez tué {0} monstres faciles et {1} monstres difficiles. Vous avez {2} points.", cptFacile, cptDifficile, cptFacile + cptDifficile * 2);
        }

        //fonction de création de monstre pour le mode jeu 1
        private static MonstreFacile FabriqueDeMonstre()
        {
            if (random.Next(2) == 0)
                return new MonstreFacile();
            else
                return new MonstreDifficile();
        }

        //Lancement et déroulement du jeu n2 avec ses arguments
        private static void Jeu2()
        {
            Joueur nicolas = new Joueur(150);
            BossDeFin boss = new BossDeFin(250);
            while (nicolas.EstVivant && boss.EstVivant)
            {
                nicolas.Attaque(boss);
                if (boss.EstVivant)
                    boss.Attaque(nicolas);
            }
            if (nicolas.EstVivant)
                Console.WriteLine("Bravo, vous avez sauvé la princesse (ou le prince !)");
            else
                Console.WriteLine("Game over...");
        }
    }
}

