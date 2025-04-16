using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueQuests.Classes
{
    public class Question
    {
        static public List<Question> questions = new List<Question>();

        public string Description { get; set; }

        public string RigthAwnser { get; set; }

        public List<string> Answers { get; set; }

        public Question(string description, string rigthAwnser, List<String> answers)
        {
            Description = description;
            RigthAwnser = rigthAwnser;
            Answers = answers;
        }

        static public void AddToList(string description, string rigthAwnser, List<String> answers)
        {
            questions.Add(new Question(description, rigthAwnser, answers));
        }
    }
}
