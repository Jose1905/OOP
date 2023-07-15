using System;

class Program
{
    static void Main(string[] args)
    {
        Battle newBattle = new Battle();

        // Add a few sample Pokemon
        newBattle.AddPokemon("Charmander", "Fire");
        newBattle.AddPokemon("Squirtle", "Water");
        newBattle.AddPokemon("Bulbasaur", "Grass");

        // Add a few sample Attacks
        newBattle.GetPokemonList()[0].AddAttack("Ember", "Fire", 60);
        newBattle.GetPokemonList()[0].AddAttack("Scratch", "Normal", 40);
        newBattle.GetPokemonList()[1].AddAttack("Water Gun", "Water", 60);
        newBattle.GetPokemonList()[1].AddAttack("Tackle", "Normal", 35);
        newBattle.GetPokemonList()[2].AddAttack("Razor Leaf", "Grass", 50);
        newBattle.GetPokemonList()[2].AddAttack("Tackle", "Normal", 35);
        
        // Start choice loop
        string choice = "";
        Console.WriteLine("Welcome to the pokemon attack calculator! Please select one of the following options");
        while (choice != "7"){
            DisplayOptions();
            choice = Console.ReadLine();

            if (choice == "1"){
                Console.Clear();
                newBattle.DisplayPokemonList();
            }

            else if (choice == "2"){
                Console.Clear();
                Console.WriteLine("What is the Pokemon's name?");
                string name = Console.ReadLine();
                Console.WriteLine("Select the pokemon type (Fire/Water/Grass)");
                string type = Console.ReadLine();
                newBattle.AddPokemon(name, type);
            }

            else if (choice == "3"){
                Console.Clear();
                newBattle.DisplayPokemonList();
                Console.WriteLine("Select the number of the Pokemon you want to add an attack");
                int pokemonIndex = Int32.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("What is the attack name?");
                string attackName = Console.ReadLine();
                Console.WriteLine("What is the attack type?");
                string attackType = Console.ReadLine();
                Console.WriteLine("What is the attack power?");
                int attackPower = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                newBattle.GetPokemonList()[pokemonIndex].AddAttack(attackName, attackType, attackPower);

                newBattle.GetPokemonList()[pokemonIndex].DisplayAttackList();
            }

            else if (choice == "4"){
                Console.Clear();
                newBattle.DisplayPokemonList();
                Console.WriteLine("Select the number of the Pokemon you want to change the status");
                int pokemonIndex = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("What is the new status? (Ok/Paralyzed/Poisoned/Burned/Asleep/Frozen)");
                string status = Console.ReadLine();
                if (status == "Ok" || status == "Paralyzed" || status == "Poisoned" || status == "Burned" || status == "Asleep" || status == "Frozen"){
                    newBattle.GetPokemonList()[pokemonIndex].SetStatus(status);
                }
                else {
                    Console.WriteLine("Please select a valid status (Ok/Paralyzed/Poisoned/Burned/Asleep/Frozen)");
                }
            }

            else if (choice == "5"){
                Console.Clear();
                Console.WriteLine("What is the new weather? (Sunny/Raining/Hail/Sandstorm)");
                string weather = Console.ReadLine();
                if (weather == "Sunny" || weather == "Raining" || weather == "Hail" || weather == "Sandstorm"){
                    newBattle.SetWeather(weather);
                }
            }

            else if (choice == "6"){
                Console.Clear();
                newBattle.DisplayPokemonList();
                Console.WriteLine("What is the new attacking Pokemon?");
                int attackingIndex = Int32.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("What is the new defending Pokemon?");
                int defendingIndex = Int32.Parse(Console.ReadLine()) - 1;

                newBattle.GetPokemonList()[attackingIndex].DisplayAttackList();
                Console.WriteLine("What is the chosen attack?");
                int attackIndex = Int32.Parse(Console.ReadLine()) - 1;

                newBattle.CalculateAttackTotal(newBattle.GetPokemonList()[attackingIndex], newBattle.GetPokemonList()[defendingIndex], newBattle.GetPokemonList()[attackingIndex].GetAttackList()[attackIndex]);
            }

            else if (choice != "7"){
                Console.WriteLine("Please select a valid option");
            }
        }


        void DisplayOptions(){
            Console.WriteLine();
            Console.WriteLine("1. Display Pokemon list");
            Console.WriteLine("2. Add Pokemon");
            Console.WriteLine("3. Add attack");
            Console.WriteLine("4. Change Pokemon status");
            Console.WriteLine("5. Change weather");
            Console.WriteLine("6. Calculate attack power");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
        }
    }
}