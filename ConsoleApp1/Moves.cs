using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Moves
    {
        public string name;
        public float damage;
        public float accuracy;
        public PokemonTypes moveTYPE;

        public Moves(string Name, float Damage, float Accuracy, PokemonTypes aMoveType)
        {
            name = Name;
            damage = Damage;
            accuracy = Accuracy;
            moveTYPE = aMoveType;

        }
        public void info()
        {
            Console.Write(" (accuracy: " + accuracy);
            Console.WriteLine(" , damage: " + damage+ " , type: "+ moveTYPE.name +")");
        }

        
    }
}
