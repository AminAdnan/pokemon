using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PokemonTypes
    {
        public string name;
        public string[] weakness;
        public string[] ressistence;
        public string[] immune;


        public PokemonTypes(string Name, string[] Weakness, string[] Ress, String[] Immune)
        {
            name = Name;
            weakness = Weakness;
            ressistence = Ress;
            immune = Immune;
            
        }
    }
}
