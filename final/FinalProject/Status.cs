class Status
{
    private string _statusName;
    private float _powerDecrease;

    public Status(string statusName){
        _statusName = statusName;
        SetPowerDecrease();
    }

    public string GetStatusName(){
        return _statusName;
    }

    public void SetStatusName(string statusName){
        _statusName = statusName;
    }

    public float GetPowerDecrease(){
        return _powerDecrease;
    }

    public void SetPowerDecrease(){
        if (_statusName == "Poisoned" || _statusName == "Burned"){
            _powerDecrease = Convert.ToSingle(0.5);
        }
        else if (_statusName == "Frozen" || _statusName == "Asleep"){
            _powerDecrease = Convert.ToSingle(0);
        }
        else if (_statusName == "Paralyzed"){
            _powerDecrease = Convert.ToSingle(1);
        }
    }
}