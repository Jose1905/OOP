class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _startingVerse = 0;
    private int _endingVerse = 0;
    private Scripture _text;
    private int _wordsPerTurn;

    public Reference(string scripture, string text, int words){
        string[] bookName = scripture.Split(" ");
        SetBook(bookName[0]);
        string[] chapterNum = bookName[1].Split(":");
        SetChapter(Int32.Parse(chapterNum[0]));
        string[]  startVerse = chapterNum[1].Split("-");
        SetStartingVerse(Int32.Parse(startVerse[0]));
        if (startVerse.Count() == 2){
            SetEndingVerse(Int32.Parse(startVerse[1]));    
        }
        _text = new Scripture(text);
        _wordsPerTurn = words;
    }
    
    public string GetBook(){
        return _book;
    }

    private void SetBook(string book){
        _book = book;
    }

    public string GetChapter(){
        return _chapter.ToString();
    }

    private void SetChapter(int chapter){
        _chapter = chapter;
    }

    public string GetStartingVerse(){
        return _startingVerse.ToString();
    }

    private void SetStartingVerse(int startingVerse){
        _startingVerse = startingVerse;
    }

    public string GetEndingVerse(){
        return _endingVerse.ToString();
    }

    private void SetEndingVerse(int endingVerse){
        _endingVerse = endingVerse;
    }

    public string GetReference(){
        if (_endingVerse == 0){
            return $"{_book} {_chapter}:{_startingVerse}";
        }
        return $"{_book} {_chapter}:{_startingVerse}-{_endingVerse}";
    }

    public string GetText(){
        return _text.GetScriptureText();
    }

    public void HideWords(){
        _text.HideWords(+_wordsPerTurn);
    }

    public bool CheckEmptyText(){
        bool isEmpty = false;
        if (_text.GetActiveWords() == 0){
            isEmpty = true;
        }
        return isEmpty;
    }
}