using System;
using System.Collections.Generic;
public class PromptGenerator
{

    public List<string> _prompts = new List<string>()
    {
        "What did you feel as your read your scriptures?", 
        "Who did you talk to today?", 
        "What was the most beautiful thing you saw?",
        "Where was the favorite place you went?",
        "How did you spend your morning?",
        "What blessing did you see today?",
        "How are the goals that you're working on coming?"
    };

    
    


    public string GetRandomPrompt()
    {   
        Random randomGenerator = new Random();

        int j = randomGenerator.Next(_prompts.Count);

        return _prompts[j];

    }
}