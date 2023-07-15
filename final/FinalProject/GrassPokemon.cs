class GrassPokemon : Pokemon
{
   public GrassPokemon(string pokemonName) : base(pokemonName){
        _pokemonType = "Grass";
    }

    public override float CalculateAttackSubtotal(Attack attack, Weather weather){
        float subtotal = attack.GetPower();
        if (attack.GetAttackType() == _pokemonType){
            subtotal = subtotal * Convert.ToSingle(1.5);
        }
        subtotal = subtotal * _status.GetPowerDecrease();
        return subtotal;
    }
}