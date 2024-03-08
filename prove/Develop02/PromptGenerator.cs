    using System;
    using JournalApp;
    class PromptGenerator
    {
        private List<string> _prompts;

        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What did you do today to serve someone?",
                "What did you ponder over in your scriptures today?",
                "How were you helped today and by who?",
                "What outside event did you witness or ponder today?",
                "What did you do today, that was enjoyable?",
                "What did you learn today?",
                "What did you improve in your life today?",
            };
        }

        public string GetRandomPrompt()
        {
            Random rand = new();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
    }
