using System;

class Word
{
    private string _wordText = "";
    private int _length = 0;
    private bool _hidden;

    public Word(string wordText){
        _wordText = wordText;
        _length = _wordText.Length;
        _hidden = false;
    }

    public string getWordText(){
        return _wordText;
    }

    public bool getPrivacy(){
        return _hidden;
    }

    public string hideWord(){
        _wordText = "";
        for (int letter = 0; letter < _length; letter ++){
            _wordText += "_";
        }
        _hidden = true;
        return _wordText;
    }
}