using System.Diagnostics;

public class Scripture {

    private Reference _reference = new Reference("Proverbs",3,5,6);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){

            _reference = reference;

            List<string>words = text.Split(' ').ToList();
            foreach (string word in words){
                Word word1 = new Word(word);
                _words.Add(word1);
            }
    }
    public void HideRandomWords(int numberToHide = 0){

        for (int i = 0; i < numberToHide; i++){

            bool isCompletelyHidden = IsCompletelyHidden();
            if (isCompletelyHidden == false){

                Random randomGenerator = new Random();
                int random = randomGenerator.Next(0, _words.Count);

                if (_words[random].IsHidden() == false){
                    _words[random].Hide();
                }
                else{
                    i = i - 1;
                }
            }
            else{
                i += numberToHide;
            }
        }
    }
    public string GetDisplayText(){
        return"";
    }
    public bool IsCompletelyHidden(){
        //Cria lista de bool
        List<bool>hidden = new List<bool>();
        for (int i = 0; i < _words.Count; i++){

            hidden[i] = _words[0].IsHidden();
        }
        //Ver se é tudo true
        bool anyFalse = hidden.Any(element => element == false);

        if (anyFalse)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
