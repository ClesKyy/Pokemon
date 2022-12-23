using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    public class Potion
    {
        public string Nom { get; set; }
        public int PointVie { get; set; }
        public int NbrPotion { get; set; }
        public void PotionDrop(Potion potion)
        {
            Random randPotion = new Random();
            int PotionDrop = randPotion.Next(0, 100);
            if (PotionDrop < 10)
            {
                potion.NbrPotion = NbrPotion + 1;
                Console.WriteLine("Vous avez obtenu une Potion");
            }
        }
    }
}