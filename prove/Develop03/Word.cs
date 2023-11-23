using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

public class Word {

    private string _text;
    private bool _isHidden;

    public Word(string text, bool notHidden = false){
        _text = text;
        _isHidden = notHidden;
    }
    public void Hide(){
        _text = new string('_', _text.Length);
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool IsHidden(){
        if (_isHidden == true){
            return true;
        }
        else{
            return false;
        }
    }
    public string GetDisplayText(){
        return _text;
    }
}