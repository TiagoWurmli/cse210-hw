public class PromptGenerator {
    
    public List<string> _prompts;

    public string GetRamomPrompt(){

        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, _prompts.Count);
        return _prompts[i];
    }
}