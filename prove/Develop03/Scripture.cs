using System.Diagnostics;

public class Scripture {

    private Reference _reference = new Reference("Proverbs",3,5,6);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){
            //Pega a referencia
            _reference = reference;
            //Adiciona as palavras na lista "_words" em Word
            List<string>words = text.Split(' ').ToList();
            foreach (string word in words){
                Word word1 = new Word(word);
                _words.Add(word1);
            }
    }
    public void HideRandomWords(int numberToHide = 0){
        //Vai esconder o numero de palavras em "numberToHide"
        for (int i = 0; i < numberToHide; i++){
            //Cheka se esta tudo escondido
            bool isCompletelyHidden = IsCompletelyHidden();
            //Se não estiver vai esconder mais um numero
            if (isCompletelyHidden == false){
                //Pega uma palavra aleatoria da lista
                Random randomGenerator = new Random();
                int random = randomGenerator.Next(0, _words.Count);
                //Se a palavra nao esta escondida vai esconder
                if (_words[random].IsHidden() == false){
                    _words[random].Hide();
                }
                //Se não vai repetir o processo
                else{
                    i--;
                }
            }
            //Se estiver vai encerrar o loop
            else{
                i += numberToHide;
            }
        }
    }
    public string GetDisplayText(){

        List<string>textList = new List<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            textList[i] = _words[i].GetDisplayText();
        }
        string textDisplay = string.Join(" ", textList);
        string referenceDisplay = _reference.GetDisplayText();
        return $"{referenceDisplay} {textDisplay}";
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
