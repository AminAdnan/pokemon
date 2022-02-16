using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// use same move of same type as pokemon for stab damage(1.5x)
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string[] normalweak = { "fighting" };
            string[] normalress = { "" };
            string[] normalimmune = { "ghost" };

            string[] psychicweak = { "bug", "dark", "ghost" };
            string[] psychicress = { "fighting", "psychic" };
            string[] psychicimmune = { "" };

            string[] fightweak = { "psychic" };
            string[] fightress = { "bug","dark","rock" };
            string[] fightimmune = { " " };

            string[] elecweak = { "ground" };
            string[] elecress = { "electric","flying" };
            string[] elecimmune = { " " };

            string[] flyweak = { "electric", "ice", "rock" };
            string[] flyress = { "bug", "fighting", "grass" };
            string[] flyimmune = { "ground" };

            string[] flynormWeak = { "electric", "ice", "rock" };
            string[] flynormRess = { "bug", "grass" };
            string[] flynormImmune = { "ground","ghost" };

            string[] groundweak = { "water", "ice", "grass" };
            string[] groundress = { "rock", "poison" };
            string[] groundimmune = { "" };

            string[] fightnormweak = { "fighting", "flying", "psychic", "fairy" };


            string[] Null = { };





            

            PokemonTypes type1 = new PokemonTypes("normal", normalweak, normalress, normalimmune);
            PokemonTypes type2 = new PokemonTypes("psychic", psychicweak, psychicress, psychicimmune);
            PokemonTypes type3 = new PokemonTypes("fighting", fightweak, fightress, fightimmune);
            PokemonTypes type4 = new PokemonTypes("electric", elecweak, elecress, elecimmune);
            PokemonTypes type5 = new PokemonTypes("flying", flyweak, flyress, flyimmune);
            PokemonTypes type5_1 = new PokemonTypes("flying-normal", flynormWeak, flynormRess, flynormImmune);
            PokemonTypes type6 = new PokemonTypes("ground", groundweak, groundress, groundimmune);
            PokemonTypes type1_3 = new PokemonTypes("normal-fighting", fightnormweak, fightress, fightimmune);

            PokemonTypes typenull = new PokemonTypes("", Null, Null, Null);
            

            Moves move1 = new Moves("tackle", 40, 100, type1);
            Moves move2 = new Moves("splash", 0, 100, typenull);
            Moves move3 = new Moves("get rekt", 160, 30, type1);
            Moves move4 = new Moves("psychic", 90, 100, type2);
            Moves move5 = new Moves("mega kick", 110, 70, type1);
            Moves move6 = new Moves("sky uppercut", 85, 90, type3);
            Moves move7 = new Moves("thunder", 120, 75, type4);
            Moves move8 = new Moves("brave bird", 120, 90, type5);
            Moves move9 = new Moves("earthquake", 100, 100, type6);
            Moves[] movelist = { move1, move2, move3, move4, move5, move6, move7, move8, move9 };
   
            

            pokemon Pokemon1 = new pokemon("PAkACHU", 250, 450, 1000, 100, type4,typenull,type4);
            pokemon Pokemon2 = new pokemon("mew", 341, 236, 236, 236, type2, typenull,type2);
            pokemon Pokemon3 = new pokemon("mewtwo", 353, 256, 296, 216, type2, typenull,type2);
            pokemon Pokemon4 = new pokemon("poochoo", 500, 500, 500, 500, type1 , typenull,type1);
            pokemon Pokemon5 = new pokemon("staraptor", 311, 276, 236, 176, type5,type1,type5_1);
            pokemon Pokemon6 = new pokemon("ZainMon", 300, 550, 150, 400, type1, type3, type1_3);


            pokemon Pokemon1d = new pokemon("PAkACHU1", 250, 450, 1000, 100, type4, typenull, type4);
            pokemon Pokemon2d = new pokemon("mew1", 341, 236, 236, 236, type2, typenull, type2);
            pokemon Pokemon3d = new pokemon("mewtwo1", 353, 256, 296, 216, type2, typenull, type2);
            pokemon Pokemon4d = new pokemon("poochoo1", 500, 500, 500, 500, type1, typenull, type1);
            pokemon Pokemon5d = new pokemon("staraptor1", 311, 276, 236, 176, type5, type1, type5_1);
            pokemon Pokemon6d = new pokemon("ZainMon1", 300, 550, 150, 400, type1, type3, type1_3);





            Moves playerMove;
            Moves botMove;


            int count; //super effe
            string poke;
            string select;
            int b = 1; // move selection number
            pokemon[] battle_pokemon = { Pokemon1, Pokemon2, Pokemon3, Pokemon4, Pokemon5, Pokemon6 };
            pokemon[] battle_pokemond = { Pokemon1d, Pokemon2d, Pokemon3d, Pokemon4d, Pokemon5d, Pokemon6d};
            pokemon bot;
            pokemon player;
            Random random = new Random();
            int p = random.Next(0, battle_pokemon.Length);
            bot = battle_pokemon[p];
            bool temp = false;
            string battle;
            bool CriticalHit = false;
            bool Hit = false;
            float Damage;
            int pokeCounter = 1;
            int ppp = 0;
            
            


                        
            for(pokeCounter = 1; pokeCounter < battle_pokemon.Length+1;)
            {
                Console.Write(pokeCounter + ": ");
                battle_pokemon[ppp].Stats();
                ppp++;
                pokeCounter++;

            }
            
            do
            {
                Console.WriteLine("choose ur pokemon");
            
                poke = Console.ReadLine();

                //CHOSE POKEMON1 ::

                if (poke == "1")

                {
                    game(0);
                    break;
                }

                //CHOSE POKEMON2::  
                else if (poke == "2")
                {
                    game(1);
                    break;

                }
                else if (poke == "3")
                {
                    game(2);
                    break;
                }
                else if (poke == "4")
                {
                    game(3);
                    break;
                }
                else if (poke == "5")
                {
                    game(4);
                    break;
                }
                else if (poke == "6")
                {
                    game(5);
                    break;
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            } while (1 == 1);
            



            void attack1() // 
            {
                Console.WriteLine(player.name + " used " + playerMove.name);
                
                HitOrMiss();
                if (Hit == true)
                {
                    DamageCalculation1();

                    critical();
                    if (CriticalHit == true)
                    {
                        
                        Console.WriteLine("Critical Hit! ");
                        bot.hp -= Damage*1.5f;
                        
                        Console.WriteLine("opponent's " + bot.name + " hp: " + bot.hp);

                        if (bot.hp <= 0)
                        {
                            Console.WriteLine("opponent's " + bot.name + " fainted ");
                            Console.WriteLine("gg");
                            temp = true;

                        }
                        return;

                    }

                    
                    bot.hp -= Damage;
                    
                    
                    Console.WriteLine("opponent's " + bot.name + " hp: " + bot.hp);
                    if (bot.hp <= 0)
                    {
                        Console.WriteLine("opponent's " + bot.name + " fainted ");
                        Console.WriteLine("gg");
                        temp = true;

                    }
                    if (playerMove == move2)
                    {
                        Console.WriteLine( "It did nothing");
                    }

                }
                else
                {
                    Console.WriteLine("opponent's " + bot.name + " hp: " + bot.hp);
                    Console.WriteLine("attack missed");
                }
               
            }
            void Botattack()
            {


                Console.WriteLine("opponent's " + bot.name + " used "+ botMove.name);
                                 
                HitOrMiss2();

                if (Hit == true)
                {
                    DamageCalculation2();

                    critical();
                    if (CriticalHit == true)
                    {
                        Console.WriteLine("Critical Hit! ");
                        player.hp -= Damage*1.5f;
                        Console.WriteLine("your " + player.name + " hp: " + player.hp);
                        if (player.hp <= 0)
                        {
                            
                            Console.WriteLine("your " + player.name + " fainted ");
                            Console.WriteLine("Imagine losing to a bot. LMAO");
                            temp = true;

                        }
                        return;

                    }



                    player.hp -= Damage;
                    Console.WriteLine("your " + player.name + " hp: " + player.hp);
                    if (player.hp <= 0)
                    {
                        Console.WriteLine("your " + player.name + " fainted ");
                        Console.WriteLine("Imagine losing to a bot. LMAO");
                        temp = true;

                    }
                    if (botMove == movelist[1])
                    {
                        Console.WriteLine("opponent's "+ bot.name + " splashed around and NOTHING HAPPENED");
                    }
                }
                else
                {
                    Console.WriteLine("attack missed");
                    Console.WriteLine("your " + player.name + " hp: " + player.hp);
                }
                
            }
            void BotTurn()
            {
                int bMove = random.Next(0, movelist.Length);
                botMove = movelist[bMove];
                Botattack();

            }
            void critical()
            {
                CriticalHit = false;
                string[] ACrit = { "1", "CRITICAL","2","3","4","5","6","7","8","9","10","11","12","13","14","15" };
                int C = random.Next(0, ACrit.Length);
                string crit = ACrit[C];
                if (crit == "CRITICAL")
                {
                    CriticalHit = true;
                }
            }
            void HitOrMiss() // accuracy check returns true if move hits
            {
                float aaa = random.Next(0, 100);
                if (aaa <= playerMove.accuracy)
                {
                    Hit = true;
                }
                else
                {
                    Hit = false;
                }
            }
            void HitOrMiss2() // accuracy check returns true if move hits
            {
                float aaa = random.Next(0, 100);
                if (aaa <= botMove.accuracy)
                {
                    Hit = true;
                }
                else
                {
                    Hit = false;
                }

            }
            void DamageCalculation1()  
            {
                if (player.pokeTYPE.name == playerMove.moveTYPE.name || player.duelType.name == playerMove.moveTYPE.name )
                {
                    Console.WriteLine("STAB");
                    
                    Damage = (((2 * 100 / 5 + 2) * playerMove.damage * player.atk / bot.defense) / 50 + 2) * 1.5f;
                    
                }

                
                
                else

                {
                    Damage = (((2 * 100 / 5 + 2) * playerMove.damage * player.atk / bot.defense) / 50 + 2);
                    
                    //Console.WriteLine(Damage);
                }
                ImmuneBot();
                superEffective();
                notEffective();
                


            } // when player attacks
            void DamageCalculation2() // when bot attacks
            {
                if (bot.pokeTYPE.name == botMove.moveTYPE.name || bot.duelType.name == botMove.moveTYPE.name)
                {
                    Console.WriteLine("STAB");

                    Damage = (((2 * 100 / 5 + 2) * botMove.damage * bot.atk / player.defense) / 50 + 2) * 1.5f;

                }

                else
                {
                    Damage = (((2 * 100 / 5 + 2) * botMove.damage * bot.atk / player.defense) / 50 + 2);
                }
                Immune();
                notEffectivebot();
                superEffectivebot();
            } // when bot attacks
            void superEffective()
            {
                count = 0;
                for (count = 0; count < bot.fordamagecal.weakness.Length;)

                {
                    if (playerMove.moveTYPE.name == bot.fordamagecal.weakness[count])
                    {
                        Console.WriteLine("it was Super effective");
                        Damage = Damage * 2;
                    }
                    count = count + 1;
                }
                count = 0;
            }
            void notEffective()
            {
                count = 0;
                for (count = 0; count < bot.fordamagecal.ressistence.Length;)

                {
                    if (playerMove.moveTYPE.name == bot.fordamagecal.ressistence[count])
                    {
                        Console.WriteLine("it was not very effective");
                        Damage = Damage * 0.5f;
                        
                        
                    }
                    count = count + 1;
                }
                count = 0;
            }
            void notEffectivebot()
            {
                count = 0;
                for (count = 0; count < player.fordamagecal.ressistence.Length;)

                {
                    if (botMove.moveTYPE.name == player.fordamagecal.ressistence[count])
                    {
                        Console.WriteLine("it was not very effective");
                        Damage = Damage * 0.5f;


                    }
                    count = count + 1;
                }
                count = 0;
            }
            void superEffectivebot()
            {
                count = 0;
                for (count = 0; count < player.fordamagecal.weakness.Length;)

                {
                    if (botMove.moveTYPE.name == player.fordamagecal.weakness[count])
                    {
                        Console.WriteLine("it was Super effective");
                        Damage = Damage * 2;
                    }
                    count = count + 1;
                }
                count = 0;
            }
            void Immune()
            {
                count = 0;
               
                for (count = 0; count < player.fordamagecal.immune.Length;)

                {
                    if (botMove.moveTYPE.name == player.fordamagecal.immune[count])
                    {
                        Console.WriteLine("it doesnt affect "+ player.name);
                        Damage = 0;
                        
                    }
                    count = count + 1;
                }
                count = 0;
            }
            void ImmuneBot()
            {
                count = 0;
                for (count = 0; count < bot.fordamagecal.immune.Length;)

                {
                    if (playerMove.moveTYPE.name == bot.fordamagecal.immune[count])
                    {
                        Console.WriteLine("it doesnt affect " + bot.name);
                        Damage = 0;
                        
                    }
                    count = count + 1;
                }
                count = 0;
            }
            void BATTLE(int moveNo)
            {
                playerMove = movelist[moveNo - 1];
                
                if (player.speed > bot.speed)
                {
                    
                    attack1();
                    if(temp == true)
                    {
                        return;
                    }
                    BotTurn();
                    if(temp == true)
                    {
                        return;
                    }
                    
                }
                else if (player.speed == bot.speed)
                {
                    string[] speedtie = { "player", "bot" };
                    int sss = random.Next(0, speedtie.Length);
                    if (sss == 0)
                    {
                        BotTurn();
                        if (temp == true)
                        {
                            return;
                        }

                        attack1();
                        if (temp == true)
                        {
                            return;
                        }


                    }
                    else
                    {
                        attack1();
                        if (temp == true)
                        {
                            return;
                        }
                        BotTurn();
                        if (temp == true)
                        {
                            return;
                        }
                    }


                }

                else
                {
                    BotTurn();
                    if (temp == true)
                    {
                        return;
                    }

                    attack1();
                    if (temp == true)
                    {
                        return;
                    }


                }




            }


            void game(int o)
            {
                player = battle_pokemon[o];
                if (player.name == bot.name)
                {
                    player = battle_pokemond[o];
                }
                Console.Clear();
                Console.WriteLine("you chose: ");
                player.Stats();
                Console.WriteLine("bot chose: ");
                bot.Stats();



                Console.WriteLine("attack: Y/N: ");
                battle = Console.ReadLine();

                //Console.WriteLine(player.hp);
                while (temp == false)
                {
                    

                    if (battle == "y" || battle == "Y")
                    {
                        b = 1;

                        Console.WriteLine("select moves : ");
                        for (int i = 0; i < movelist.Length ; )
                        {
                            
                            Console.Write(b +": "+  movelist[i].name); // DISPLAYS MOVES
                            movelist[i].info();
                            Console.WriteLine("");
                            i = i + 1;
                            
                            b++;
                            
                        }
                        
                            select = Console.ReadLine();  // SELECTION OF MOVES

                        if (select == "1")

                        {
                            Console.Clear();

                            BATTLE(1);



                        }
                        else if (select == "2")
                        {
                            Console.Clear();

                            BATTLE(2);

                        }
                        else if (select == "3")
                        {
                            Console.Clear();

                            BATTLE(3);

                        }
                        else if (select == "4")
                        {
                            Console.Clear();

                            BATTLE(4);

                        }
                        else if (select == "5")
                        {
                            Console.Clear();

                            BATTLE(5);

                        }
                        else if (select == "6")
                        {
                            Console.Clear();

                            BATTLE(6);

                        }
                        else if (select == "7")
                        {
                            Console.Clear();

                            BATTLE(7);

                        }
                        else if (select == "8")
                        {
                            Console.Clear();

                            BATTLE(8);
                        }
                        else if (select == "9")
                        {
                            Console.Clear();

                            BATTLE(9);
                        }
                        else
                        {
                            Console.WriteLine("invalid move");
                        }
                            
                                 
                        

                        
                    }

                    else
                    {
                        Console.WriteLine("you ran away from the battle");
                        break;
                    }
                }

                



            }
            
            string x = Console.ReadLine();
        }




            
        
        
    }
}
