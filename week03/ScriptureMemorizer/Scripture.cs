public class Scripture
{
    Reference _reference = new Reference("",0,0);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        //fazer loop para guardar escritura na lista _words
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word addWord = new Word(word);
            _words.Add(addWord);
        }
    }

    public  void HideRandomWords(int numberToHide)
    {
        while(numberToHide > 0)
        {
            Random randomGenerator = new Random();
            int i = randomGenerator.Next(0, _words.Count);

            _words[i].Hide();

            numberToHide--;
        }
    }
    public string GetDisplayText()
    {
        // Criar lista de string para printa depois
        List<string> scriptureText = new List<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            scriptureText.Add(_words[i].GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", scriptureText)}";
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;
    }

}