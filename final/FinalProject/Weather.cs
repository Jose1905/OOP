class Weather
{
    private string _weatherName;
    private int _turnsLeft;

    public Weather(string weatherName){
        _weatherName = weatherName;
        _turnsLeft = 5;
    }

    public string GetWeatherName(){
        return _weatherName;
    }

    public void SetWeatherName(string weatherName){
        _weatherName = weatherName;
    }

    public int GetturnsLeft(){
        return _turnsLeft;
    }

    public void DecreaseTurn(){
        _turnsLeft -= 1;
    }
}