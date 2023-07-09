class Attack
{
    private string _attackName;
    private string _attackType;
    private float _power;

    public Attack(string attackName, string attackType, float power){
        _attackName = attackName;
        _attackType = attackType;
        _power = power;
    }

    public string GetAttackName(){
        return _attackName;
    }

    public void SetAttackName(string attackName){
        _attackName = attackName;
    }

    public string GetAttackType(){
        return _attackType;
    }

    public void SetAttackType(string attackType){
        _attackType = attackType;
    }

    public float GetPower(){
        return _power;
    }

    public void SetPower(float power){
        _power = power;
    }
}