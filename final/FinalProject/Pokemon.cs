class Pokemon
{
    protected string _pokemonName;
    protected List<Attack> _attackList;
    protected Status _status;
    protected string _pokemonType;

    public Pokemon(string pokemonName){
        _pokemonName = pokemonName;
        _attackList = new List<Attack>();
        _status = new Status("Ok");
    }

    public string GetPokemonName(){
        return _pokemonName;
    }

    public void SetPokemonName(string pokemonName){
        _pokemonName = pokemonName;
    }

    public List<Attack> GetAttackList(){
        return _attackList;
    }

    public void AddAttack(string name, string type, float power){
        Attack attack = new Attack(name, type, power);
        _attackList.Add(attack);
    }

    public string GetPokemonType(){
        return _pokemonType;
    }

    public void SetPokemonType(string pokemonType){
        _pokemonType = pokemonType;
    }

    public string GetStatus(){
        return _status.GetStatusName();
    }

    public void SetStatus(string statusName){
        _status = new Status(statusName);
    }

    public virtual float CalculateAttackSubtotal(Attack attack, Weather weather){
        return attack.GetPower();
    }

    public string DisplayPokemon(){
        return $"{_pokemonName}: Type = {_pokemonType}, Status = {_status.GetStatusName()}";
    }

    public void DisplayAttackList(){
        Console.WriteLine();
        if (_attackList.Count() == 0){
            Console.WriteLine("There are still no attacks added");
        }
        else {        
            for (int i = 0; i < _attackList.Count(); i++){
                Console.WriteLine($"{i+1}. {_attackList[i].DisplayAttack()}");
            }
        }
    }
}