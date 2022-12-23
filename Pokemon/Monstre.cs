using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Monstre
    {
        public string Nom { get; set; }
        public int PointVie { get; set; }
        public int PointVieMax { get; set; }
        public int Degat { get; set; }
        public int Exp { get; set; }    
        public bool IsDead { get; set; } = false;
        public int Niveau { get; set; }
        
        public void PokemonRng(Monstre monstre, Player player) // Pokemon Random 
        {
            Random rand0 = new Random();
            int PokemonRng = rand0.Next(0, 100);
            if ((PokemonRng < 50 && player.Route == 1) || (PokemonRng >= 0 && PokemonRng < 40 && player.Route == 2) || (PokemonRng >= 0 && PokemonRng < 15 && player.Route == 3))
            {
                PokemonRng = rand0.Next(0, 100);
                if (((PokemonRng >= 0 && PokemonRng <= 20) && player.Route == 1)) // Rattata Niv.2
                {
                    monstre.Niveau = 2;
                    monstre.PointVie = 13;
                    monstre.PointVieMax = monstre.PointVie;
                    monstre.Degat = 7;
                }
                else if (((PokemonRng > 20 && PokemonRng <= 60) && player.Route == 1) || (PokemonRng >= 0 && PokemonRng <= 15) && player.Route == 2) // Rattata Niv.3
                {
                    monstre.Niveau = 3;
                    int PointVieRNG = rand0.Next(0, 2);
                    monstre.PointVie = 14 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 2);
                    monstre.Degat = 8 + DegatRNG;
                }
                else if (((PokemonRng > 60 && PokemonRng <= 100) && player.Route == 1) || (PokemonRng > 15 && PokemonRng <= 75) && player.Route == 2) // Rattata Niv.4
                {
                    monstre.Niveau = 4;
                    int PointVieRNG = rand0.Next(0, 2);
                    monstre.PointVie = 16 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 2);
                    monstre.Degat = 9 + DegatRNG;
                }
                else if ((PokemonRng > 75 && PokemonRng <= 100) && player.Route == 2 || (PokemonRng >= 0 && PokemonRng <= 55) && player.Route == 3) // Rattata Niv.5
                {
                    monstre.Niveau = 5;
                    int PointVieRNG = rand0.Next(0, 2);
                    monstre.PointVie = 18 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 10 + DegatRNG;
                }
                else if ((PokemonRng > 55 && PokemonRng <= 100) && player.Route == 3) // Rattata Niv.6
                {
                    monstre.Niveau = 6;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 19 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 11 + DegatRNG;
                }
                monstre.Nom = "Rattata";

            }
            else if ((PokemonRng >= 50 && player.Route == 1) || (PokemonRng >= 40 && PokemonRng < 80 && player.Route == 2) || (PokemonRng > 15 && PokemonRng < 35 && player.Route == 3))
            {
                PokemonRng = rand0.Next(0, 100);
                if (((PokemonRng >= 0 && PokemonRng <= 20) && player.Route == 1)) // Roucool Niv.2
                {
                    monstre.Niveau = 2;
                    int PointVieRNG = rand0.Next(0, 2);
                    monstre.PointVie = 13 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 2);
                    monstre.Degat = 6 + DegatRNG;
                }
                else if (((PokemonRng > 20 && PokemonRng <= 60) && player.Route == 1)) // Roucool Niv.3
                {
                    monstre.Niveau = 3;
                    int PointVieRNG = rand0.Next(0, 2);
                    monstre.PointVie = 15 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 2);
                    monstre.Degat = 7 + DegatRNG;
                }
                else if (((PokemonRng > 60 && PokemonRng <= 95) && player.Route == 1) || (PokemonRng >= 0 && PokemonRng <= 10) && player.Route == 2) // Roucool Niv.4
                {
                    monstre.Niveau = 4;
                    int PointVieRNG = rand0.Next(0, 2);
                    monstre.PointVie = 17 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 2);
                    monstre.Degat = 8 + DegatRNG;
                }
                else if (((PokemonRng > 95 && PokemonRng <= 100) && player.Route == 1) || (PokemonRng > 10 && PokemonRng <= 40) && player.Route == 2) // Roucool Niv.5
                {
                    monstre.Niveau = 5;
                    int PointVieRNG = rand0.Next(0, 2);
                    monstre.PointVie = 19 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 9 + DegatRNG;
                }
                else if ((PokemonRng > 40 && PokemonRng <= 90) && player.Route == 2 || (PokemonRng >= 0 && PokemonRng <= 20) && player.Route == 3) // Roucool Niv.6
                {
                    monstre.Niveau = 6;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 20 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 10 + DegatRNG;
                }
                else if (((PokemonRng > 90 && PokemonRng <= 100) && player.Route == 2) || (PokemonRng > 20 && PokemonRng <= 70) && player.Route == 3) // Roucool Niv.7
                {
                    monstre.Niveau = 7;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 22 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 11 + DegatRNG;
                }
                else if (((PokemonRng > 70 && PokemonRng <= 100) && player.Route == 3)) // Roucool Niv.8
                {
                    monstre.Niveau = 8;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 24 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 12 + DegatRNG;
                }
                monstre.Nom = "Roucool";
            }
            else if (((PokemonRng > 80 && PokemonRng < 100) && player.Route == 2) || (PokemonRng > 35 && PokemonRng < 75 && player.Route == 3))
            {
                PokemonRng = rand0.Next(0, 100);
                if (((PokemonRng >= 0 && PokemonRng <= 20) && player.Route == 2)) // Abo Niv.4
                {
                    monstre.Niveau = 4;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 16 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 9 + DegatRNG;
                }
                if (((PokemonRng > 20 && PokemonRng <= 80) && player.Route == 2)) // Abo Niv.5
                {
                    monstre.Niveau = 5;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 18 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 2);
                    monstre.Degat = 11 + DegatRNG;
                }
                if (((PokemonRng > 20 && PokemonRng <= 100) && player.Route == 2) || (PokemonRng >= 0 && PokemonRng <= 40) && player.Route == 3) // Abo Niv.6
                {
                    monstre.Niveau = 6;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 20 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 12 + DegatRNG;
                }
                if (((PokemonRng > 40 && PokemonRng <= 100) && player.Route == 3)) // Abo Niv.7
                {
                    monstre.Niveau = 7;
                    int PointVieRNG = rand0.Next(0, 4);
                    monstre.PointVie = 21 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 2);
                    monstre.Degat = 13 + DegatRNG;
                }
                monstre.Nom = "Abo";
            }
            else if (((PokemonRng > 75 && PokemonRng < 100) && player.Route == 3))
            {
                PokemonRng = rand0.Next(0, 100);
                if (((PokemonRng >= 0 && PokemonRng <= 40) && player.Route == 3)) // Rondoudou Niv.5
                {
                    monstre.Niveau = 5;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 26 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 9 + DegatRNG;
                }
                if (((PokemonRng > 40 && PokemonRng <= 90) && player.Route == 3)) // Rondoudou Niv.6
                {
                    monstre.Niveau = 6;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 29 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 10 + DegatRNG;
                }
                if (((PokemonRng > 90 && PokemonRng <= 100) && player.Route == 3)) // Rondoudou Niv.7
                {
                    monstre.Niveau = 7;
                    int PointVieRNG = rand0.Next(0, 3);
                    monstre.PointVie = 33 + PointVieRNG;
                    monstre.PointVieMax = monstre.PointVie;
                    int DegatRNG = rand0.Next(0, 3);
                    monstre.Degat = 11 + DegatRNG;
                }
                monstre.Nom = "Rondoudou";
            }

                monstre.Exp = (8 * monstre.Niveau) + (monstre.PointVie / 3) + (monstre.Degat / 2);
        }


        public void Attaquer(Player player)
        {
            player.PrendreDegat(Degat);
            Console.WriteLine(Nom +" vous a infligé " + Degat + ". ▼");
        }
        public void PrendreDegat(int degat) 
        {
            PointVie = PointVie - degat;

            if (PointVie <= 0)
            {
                IsDead = true;
            }
        }   
    }
}
