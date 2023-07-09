class Pokemon
{
    protected string _pokemonName;
    // protected List<Attack> _attackList;
    protected Status _status;
    protected string _pokemonType;

    public Pokemon(string pokemonName, string pokemonType){
        _pokemonName = pokemonName;
        _pokemonType = pokemonType;
    }

    public string GetPokemonName(){
        return _pokemonName;
    }

    public void SetPokemonName(string pokemonName){
        _pokemonName = pokemonName;
    }

    public string GetPokemonType(){
        return _pokemonType;
    }

    public void SetPokemonType(string pokemonType){
        _pokemonType = pokemonType;
    }

    public Status GetStatus(){
        return _status;
    }

    public void SetStatus(string statusName){
        _status = new Status(statusName);
    }

    public virtual float CalculateAttackSubtotal(Attack attack){
        float attack_subtotal = attack.GetPower();
        if (attack.GetAttackType() == _pokemonType){
            attack_subtotal = attack_subtotal * Convert.ToSingle(1.5);
        }
        attack_subtotal = attack_subtotal * _status.GetPowerDecrease();
        return attack_subtotal;
    }
}