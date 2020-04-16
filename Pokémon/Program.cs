using System;

namespace Pokémon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokémon Bulbasaur = new Pokémon();
            Bulbasaur.Name = "Bulbasaur";
            Bulbasaur.Type = "Grass/Poison";
            Bulbasaur.Number = 1;

            Bulbasaur.HP_Base = 45;
            Bulbasaur.Attack_Base = 49;
            Bulbasaur.Defense_Base = 49;
            Bulbasaur.SpecialAttack_Base = 65;
            Bulbasaur.SpecialDefense_Base = 65;
            Bulbasaur.Speed_Base = 45;

            Pokémon Charmander = new Pokémon();
            Charmander.Name = "Charmander";
            Charmander.Type = "Fire";
            Charmander.Number = 4;

            Charmander.HP_Base = 39;
            Charmander.Attack_Base = 52;
            Charmander.Defense_Base = 43;
            Charmander.SpecialAttack_Base = 60;
            Charmander.SpecialDefense_Base = 50;
            Charmander.Speed_Base = 65;

            Pokémon Squirtle = new Pokémon();
            Squirtle.Name = "Squirtle";
            Squirtle.Type = "Water";
            Squirtle.Number = 7;
            Squirtle.HP_Base = 44;
            Squirtle.Attack_Base = 48;
            Squirtle.Defense_Base = 65;
            Squirtle.SpecialAttack_Base = 50;
            Squirtle.SpecialDefense_Base = 64;
            Squirtle.Speed_Base = 43;

            Bulbasaur.ShowInfo();
            Charmander.ShowInfo();
            Squirtle.ShowInfo();


        
        }

    }
}
