using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class pokemon
    {
        public string name;
        public float hp;
        public float atk;
        public float speed;
        public float defense;
        public PokemonTypes pokeTYPE;
        public PokemonTypes duelType;
        public PokemonTypes fordamagecal;
        
        public static int pokemonCounter = 0;
        
        
        public pokemon(string aName, float aHp, float aAtk, float aSpeed, float aDefense, PokemonTypes apokeTYPE, PokemonTypes a2ndtype, PokemonTypes afordamagecal)
        {
            name = aName;
            hp = aHp;
            atk = aAtk;
            speed = aSpeed;
            defense = aDefense;
            pokeTYPE = apokeTYPE;
            duelType = a2ndtype;
            fordamagecal = afordamagecal;
            

            pokemonCounter += 1;
            
            
            
            
        }

        public bool Alive()
        {
            if (hp > 0)
            {
                return true;
            }
            return false;

        }
        public void Stats()
        {
            
            Console.Write("name: " + name);
            Console.WriteLine(" (type: " + fordamagecal.name + ")");
            Console.WriteLine("atk: " + atk);
            Console.WriteLine("speed: " + speed);
            Console.WriteLine("hp: " + hp);
            Console.WriteLine("defense: " + defense);
            Console.WriteLine("");
        }
        

    }
}
