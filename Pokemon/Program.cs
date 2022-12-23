using System.Reflection;
using System.Runtime.CompilerServices;
using TEST;
Player player = new Player
{
    Nom = "Pikachu",
    Degat = 12,
    PointVie = 20,
    PointVieMax = 20,
    CoupCritique = 0.20f,
    DegatCritique = 10,
    Niveau = 5,
    Experience = 0,
    ExperienceMax = 100,
    Route = 1,
    Objectif = 5,
};
Potion potion = new Potion
{
    Nom = "Potion",
    PointVie = 20,
    NbrPotion = 2,
};
int nbDeMonstresTues = 0;
int Road = 1;

player.Intro();
while (!player.IsDead)
{
    if (nbDeMonstresTues == player.Objectif)
    {
        if(nbDeMonstresTues == 25)
        {
            Console.WriteLine("Félicitaion vous avez fini Pokémon ! ▼");
            Console.ReadLine();
            Console.WriteLine("Merci d'avoir joué ! ▼");
            player.Objectif = 8192;
            nbDeMonstresTues = 0;
        }
        else
        {
        Console.Clear();
        Console.WriteLine("Objectif Accompli : Affronter " + player.Objectif + " Pokémon sur la Route " + Road + " pour passer sur la Route Suivante " + nbDeMonstresTues + "/" + player.Objectif);
        Road = Road + 1;
        player.Objectif = player.Objectif + 10;
        nbDeMonstresTues = 0;
        Console.WriteLine("Prochain Objectif : Affronter " + player.Objectif + " Pokémon sur la Route " + Road + " pour passer sur la Route Suivante " + nbDeMonstresTues + "/" + player.Objectif);
        if (player.Objectif == 15)
        {
            Console.WriteLine("Vous avez débloquer la Carte ▼");
        }
        }
        Console.ReadLine();
        Console.Clear();
    }
    Console.WriteLine("Vous êtes sur la Route " + player.Route);
    Console.WriteLine("Objectif : Affronter " + player.Objectif + " Pokémon sur la Route " + Road + " pour passer sur la Route Suivante " + nbDeMonstresTues + "/" + player.Objectif);

    Monstre monstre = new Monstre
    {

    };
    monstre.PokemonRng(monstre, player);
    Console.WriteLine("Appuyez sur [3] pour afficher vos Pokémon ");
    Console.WriteLine( "Appuyez sur [4] pour aller au Centre Pokémon");
    Console.WriteLine( "Appuyez sur [5] pour combattre ");
    Console.WriteLine( "Appuyez sur [6] pour ouvrir le sac ");
    if(player.Objectif >= 15)
    {
        Console.WriteLine("Appuyez sur [7] pour ouvrir la carte ");

    }
    string valeur = Console.ReadLine();

   if (valeur == "")
    {
        Console.Clear();
    }

    if (valeur =="3")                                                                                         // Stat Pokémon        
    {
        player.StatPokemon(player);                                                                           
    }
    if (valeur == "4")                                                                                        // Centre Pokémon 
    {
        player.CentrePokemon(player);
    }
    if (valeur == "6")                                                                                        // Sac 
    {
        player.Sac(potion, player);
    }
    if (valeur == "7" && player.Objectif >= 15)                                                              // Carte
    {
        player.Carte(player);
    }
        if (valeur == "5")                                                                                   // Combat 
    {
        while (!monstre.IsDead && !player.IsDead)
        {
            player.Combat(player, monstre, potion);

            if (monstre.PointVie <= 0)                                                                        // Gain Expérience 
            {
                player.GainExp(player, monstre,potion);
            }
        }
        Console.Clear();
        if (player.Route == Road) { 
        nbDeMonstresTues++;
        }
    }
}
Console.WriteLine("Vous êtes mort");