using System.IO;

class Battle
{
    private List<Pokemon> _pokemonList;
    private Weather _weather;

    public Battle(){
        _pokemonList = new List<Pokemon>();
        _weather = new Weather("None");
    }

    public List<Pokemon> GetPokemonList(){
        return _pokemonList;
    }

    public void AddPokemon(string name, string type){
        if (type == "Fire"){
            FirePokemon newPokemon = new FirePokemon(name);
            _pokemonList.Add(newPokemon);
        }
        else if (type == "Grass"){
            GrassPokemon newPokemon = new GrassPokemon(name);
            _pokemonList.Add(newPokemon);
        }
        else if (type == "Water"){
            WaterPokemon newPokemon = new WaterPokemon(name);
            _pokemonList.Add(newPokemon);
        }
        else {
            Console.WriteLine("Please enter a valid type (Fire/Water/Grass)");
        }
    }

    public void DisplayPokemonList(){
        Console.WriteLine();
        if (_pokemonList.Count() == 0){
            Console.WriteLine("There are still no Pokemon added");
        }
        else {        
            for (int i = 0; i < _pokemonList.Count(); i++){
                Console.WriteLine($"{i+1}. {_pokemonList[i].DisplayPokemon()}");
            }
        }
    }

    public Weather GetWeather(){
        return _weather;
    }

    public void SetWeather(string name){
        _weather = new Weather(name);
    }

    public void CalculateAttackTotal(Pokemon attacking, Pokemon deffending, Attack attack){
        float power = attacking.CalculateAttackSubtotal(attack, _weather);
        if (attacking.GetPokemonType() == "Fire"){
            if (deffending.GetPokemonType() == "Fire"){
                power = power * Convert.ToSingle(0.5);
            }
            else if (deffending.GetPokemonType() == "Water"){
                power = power * Convert.ToSingle(0.5);
            }
            else if (deffending.GetPokemonType() == "Grass"){
                power = power * Convert.ToSingle(1.5);
            }
        }

        else if (attacking.GetPokemonType() == "Water"){
            if (deffending.GetPokemonType() == "Grass"){
                power = power * Convert.ToSingle(0.5);
            }
            else if (deffending.GetPokemonType() == "Water"){
                power = power * Convert.ToSingle(0.5);
            }
            else if (deffending.GetPokemonType() == "Fire"){
                power = power * Convert.ToSingle(1.5);
            }
        }

        else if (attacking.GetPokemonType() == "Grass"){
            if (deffending.GetPokemonType() == "Grass"){
                power = power * Convert.ToSingle(0.5);
            }
            else if (deffending.GetPokemonType() == "Fire"){
                power = power * Convert.ToSingle(0.5);
            }
            else if (deffending.GetPokemonType() == "Water"){
                power = power * Convert.ToSingle(1.5);
            }
        }

        _weather.DecreaseTurn();
        Console.WriteLine($"The total power of the attack is {power}");
    }
}