class WaterPokemon : Pokemon
{
   public WaterPokemon(string pokemonName) : base(pokemonName){
        _pokemonType = "Water";
    }

    public override float CalculateAttackSubtotal(Attack attack, Weather weather){
        float subtotal = attack.GetPower();
        if (attack.GetAttackType() == _pokemonType){
            subtotal = subtotal * Convert.ToSingle(1.5);
        }
        if (weather.GetWeatherName() == "Raining"){
            subtotal = subtotal * Convert.ToSingle(1.5);
        }
        else if (weather.GetWeatherName() == "Sunny"){
            subtotal = subtotal * Convert.ToSingle(0.5);
        }
        subtotal = subtotal * _status.GetPowerDecrease();
        return subtotal;
    }
}