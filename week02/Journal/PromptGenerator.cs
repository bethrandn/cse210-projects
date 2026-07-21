public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What made you smile today?",
            "Describe a challenge you overcame recently.",
            "What is something you are grateful for?",
            "Write about a person who inspires you.",
            "What is a goal you are working toward?",
            "What lesson did you learn today?",
            "What act of kindness did you witness today?",
            "What is something you wish to improve tomorrow?",
            "What made today unique?",
            "How did you help someone today?"
        };
        
    }
    
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }

}