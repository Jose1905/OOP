using System;

class Scripture
{
    private List<Word> _scriptureText = new List<Word>();
    private int _activeWords = 0;

    public Scripture(string scriptureText){
        string[] words = scriptureText.Split(" ");
        foreach (string word in words){
            Word newWord = new Word(word);
            _scriptureText.Add(newWord);
            _activeWords ++;
        }
    }

    public string GetScriptureText(){
        string result = "";
        foreach(Word word in _scriptureText){
            result += word.getWordText();
            result += " ";
        }
        Console.WriteLine();
        return result;
    }

    public void HideWords(int amount){
        if (_activeWords < amount){
            amount = _activeWords;
        }
        int i = 0;
        while (i < amount){
            Random rnd = new Random();
            int num = rnd.Next(_scriptureText.Count());
            if (_scriptureText[num].getPrivacy() == false){
                _scriptureText[num].hideWord();
                i++;
                _activeWords --;
            }                           
        }
    }

    public int GetActiveWords(){
        return _activeWords;
    }

}

// And now it came to pass that the burdens which were laid upon Alma and his brethren were made light; yea, the Lord did strengthen them that they could bear up their burdens with ease, and they did submit cheerfully and with patience to all the will of the Lord.