using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Player
    {
        public string Nom { get; set; }
        public int PointVie { get; set; }
        public int PointVieMax { get; set; }
        public int Degat { get; set; }
        public bool IsDead { get; set; } = false;
        public float CoupCritique { get; set; }
        public int DegatCritique { get; set; }
        public int Niveau { get; set; }
        public int Experience { get; set; }
        public int ExperienceMax { get; set; }  
        public int Route { get; set; }
        public int Objectif { get; set; }

        public void Intro()
        {
            Console.WriteLine("Bien le bonjour ! Bienvenue dans le monde magique des POKéMON ▼");
            Console.WriteLine("[Appuyer sur 1 pour passer l'introduction] ");
            string valeur = Console.ReadLine();
            if (valeur != "1")
            {
                Console.Clear();
                Console.WriteLine("Mon nom est CHEN ! Les gens souvent ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("m'appellent le PROF POKéMON ! ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ce monde est peuplé de créatures du nom de POKéMON ! ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Pour certains, les POKéMOM sont  des animaux ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("domestiques, pour d'autres, ils sont un moyen de combattre ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Pour ma part ... ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("L'étude des POKéMON est ma profession. ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Tout d'abord, quel est ton nom ? ▼");
                Console.WriteLine("[Entrer votre nom]");
                string Nom = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("OK ! Ton nom est donc " + Nom + " ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ta quête des POKéMON est sur le point de commencer ! ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Un tout nouveau monde de rêves, ▼");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("d'aventures et de POKéMON t'attends ! ▼");
                Console.ReadLine();
            }
            Console.Clear();
        }

        public void Attaquer(Monstre monstre)
        {
            Random rand = new Random();

            int number = rand.Next(0, 100);
            if (number <= CoupCritique * 100)
            {
                monstre.PrendreDegat(Degat + DegatCritique );
                Console.WriteLine("Vous avez infligés " + Degat + " de dégats à " + monstre.Nom + "  et " + DegatCritique + " de coupcritique. ▼");
            }
            else
            {
                monstre.PrendreDegat(Degat);
                Console.WriteLine("Vous avez infligés " + Degat + " de dégats à " + monstre.Nom + ". ▼");
            }
        }

        public void PrendreDegat(int degat)
        {
            PointVie = PointVie - degat;

            if (PointVie <= 0)
            {
                PointVie = 0;
                IsDead = true;
            }

        }

        public void StatPokemon(Player player)
        {
            Console.Clear();
            Console.WriteLine("Pokémon : ");
            Console.WriteLine(player.Nom + " Niv." + player.Niveau);
            Console.WriteLine("PV : " + player.PointVie + "/" + player.PointVieMax);
            Console.WriteLine("Atk : " + player.Degat);
            Console.WriteLine("Exp : " + player.Experience + "/" + player.ExperienceMax);
            Console.WriteLine("");
            Console.WriteLine("Retour ▼");
            Console.ReadLine();
            Console.Clear();

        }

        public void CentrePokemon (Player player)
        {
            Console.Clear();
            Console.WriteLine("Bienvenue au Centre Pokémon");
            Console.WriteLine("Voulez-vous soigner votre Pokémon");
            Console.WriteLine("Oui [1]");
            Console.WriteLine("Non [2]");
            string valeur = Console.ReadLine();
            if (valeur == "1")
            {
                Console.WriteLine(player.Nom + " a été soigné ▼");
                player.PointVie = player.PointVieMax;
                valeur = Console.ReadLine();
                Console.Clear();
            }
            if (valeur == "2")
            {
                Console.WriteLine("A bientôt ▼");
                valeur = Console.ReadLine();
                Console.Clear();
            }
        }

        public void Sac(Potion potion,  Player player)
        {
            Console.Clear();                                                                    
            Console.WriteLine("Sac");
            Console.WriteLine("Potion x" + potion.NbrPotion);
            Console.WriteLine("");
            Console.WriteLine("Appuyez sur [1] pour utiliser");
            Console.WriteLine("Appuyez sur [2] pour fermer le sac");
            string valeur = Console.ReadLine();
            if (valeur == "1")
            {
                Console.Clear();
                Console.WriteLine("Sur quel Pokémon voulez-vous utiliser cet objet ? ");
                Console.WriteLine(player.Nom);
                valeur = Console.ReadLine();
                Console.Clear();
                if (player.PointVie == player.PointVieMax)
                {
                    Console.WriteLine("Cela n'aura aucun effet. ▼");
                }
                else if ((player.PointVieMax - player.PointVie) <= 20) //Si Pv sont < a 20 Pv et calcul différence 
                {
                    int PvRest = player.PointVieMax - player.PointVie;
                    player.PointVie = player.PointVieMax;
                    Console.WriteLine(player.Nom + " récupère " + PvRest + " PV. ▼");
                }
                else
                {
                    Console.WriteLine(player.Nom + " récupère " + potion.PointVie + "PV. ▼");
                    player.PointVie = player.PointVie + potion.PointVie;
                }
                potion.NbrPotion = potion.NbrPotion - 1;
                Console.ReadLine();
            }
            Console.Clear();
        }

        public void Carte(Player player)
        {
            Console.Clear();
            Console.WriteLine("Routes disponible : ");
            Console.WriteLine("Route 1 [1]");
            Console.WriteLine("Route 2 [2]");
            if (player.Objectif >= 25)
            {
                Console.WriteLine("Route 3 [3]");
            }
            string valeur = Console.ReadLine();
            if (valeur == "1" && player.Route != 1)
            {
                player.Route = 1;
            }
            else if (valeur == "2" && player.Route != 2)
            {
                player.Route = 2;
            }
            else if (valeur == "3" && player.Route != 3)
            {
                player.Route = 3;
            }
            else
            {
                Console.WriteLine("Vous êtes actuellement dans cette route. ▼");
            }
            Console.WriteLine("Vous êtes sur la Route " + player.Route + " ▼");
            Console.ReadLine();
            Console.Clear();
        }

        public void Combat(Player player, Monstre monstre, Potion potion)
        {
            Console.Clear();
            Console.WriteLine(monstre.Nom + " apparaît...");
            Console.WriteLine("Combat en cours : ");
            Console.WriteLine("{0,50} ", monstre.Nom);
            Console.WriteLine("{0,50} ", "Niv." + monstre.Niveau);
            Console.WriteLine("{0,50} ", monstre.PointVie + "/" + monstre.PointVieMax + " PV ");
            Console.ReadLine();
            Console.WriteLine(player.Nom);
            Console.WriteLine("Niv." + player.Niveau);
            Console.WriteLine(player.PointVie + "/" + player.PointVieMax + " PV ");
            Console.WriteLine(player.Experience + "/" + player.ExperienceMax + " Exp");
            string valeur = Console.ReadLine();

            if (valeur == "6")                                                                                // Sac
            {
                player.Sac(potion, player);
            }
            else
            {
                player.Attaquer(monstre);
            }

            Console.ReadLine();
            if (monstre.IsDead == false)
            {
                monstre.Attaquer(player);
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void GainExp(Player player, Monstre monstre, Potion potion)
        {
            monstre.PointVie = 0;
            Console.WriteLine(monstre.Nom + " est mort");
            player.Experience = player.Experience + monstre.Exp;
            Console.WriteLine("Vous avez gagné " + monstre.Exp + " Expérience ▼");
            potion.PotionDrop(potion);
            if (player.Experience >= player.ExperienceMax)
            {
                player.Niveau = player.Niveau + 1;
                player.Experience = player.Experience - player.ExperienceMax;
                player.ExperienceMax = (int)Math.Ceiling(player.ExperienceMax * 1.45); // calcul de prochain exp niv.
                Random rand0 = new Random();
                int RNG = rand0.Next(0, 2);
                player.Degat = player.Degat + 1 + RNG;
                RNG = rand0.Next(0, 3);
                if ((player.PointVie + 1 + RNG) == (player.PointVieMax + 1 + RNG))
                {
                    player.PointVieMax = player.PointVieMax + 1 + RNG;
                    player.PointVie = player.PointVieMax;
                }else
                {
                    player.PointVie = player.PointVie + 1;
                    player.PointVieMax = player.PointVieMax + 1 + RNG;
                }
                Console.WriteLine("Vous êtes Niveaux " + player.Niveau);
                Console.WriteLine(player.Nom + " Niv." + player.Niveau);
                Console.WriteLine("PV : " + player.PointVie + "/" + player.PointVieMax);
                Console.WriteLine("Atk : " + player.Degat);
            }
            Console.ReadLine();
        }
        
  
    }
}
