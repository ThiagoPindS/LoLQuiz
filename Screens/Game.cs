using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueQuests.Classes;

namespace LeagueQuests.Screens
{
    public partial class Game : Form
    {
        public static Game? instance;

        public List<Question> SelectedQuestions = new List<Question>();

        public int pontuation;

        Random random = new Random();

        public int selectedQuestion;

        public int selectedOption;

        public Game()
        {
            InitializeComponent();

            instance = this;

            LoadQuestions();

            UpdateQuestion();
        }

        public void UpdateQuestion()
        {
            selectedQuestion = random.Next(0, SelectedQuestions.Count);

            txtQuestion.Text = SelectedQuestions[selectedQuestion].Description;

            selectedOption = random.Next(0, SelectedQuestions[selectedQuestion].Answers.Count);

            txtOptionA.Text = SelectedQuestions[selectedQuestion].Answers[selectedOption];

            SelectedQuestions[selectedQuestion].Answers.Remove(SelectedQuestions[selectedQuestion].Answers[selectedOption]);

            selectedOption = random.Next(0, SelectedQuestions[selectedQuestion].Answers.Count);

            txtOptionB.Text = SelectedQuestions[selectedQuestion].Answers[selectedOption];

            SelectedQuestions[selectedQuestion].Answers.Remove(SelectedQuestions[selectedQuestion].Answers[selectedOption]);

            selectedOption = random.Next(0, SelectedQuestions[selectedQuestion].Answers.Count);

            txtOptionC.Text = SelectedQuestions[selectedQuestion].Answers[selectedOption];

            SelectedQuestions[selectedQuestion].Answers.Remove(SelectedQuestions[selectedQuestion].Answers[selectedOption]);

            selectedOption = random.Next(0, SelectedQuestions[selectedQuestion].Answers.Count);

            txtOptionD.Text = SelectedQuestions[selectedQuestion].Answers[selectedOption];

            SelectedQuestions[selectedQuestion].Answers.Remove(SelectedQuestions[selectedQuestion].Answers[selectedOption]);

            selectedOption = random.Next(0, SelectedQuestions[selectedQuestion].Answers.Count);

            txtOptionE.Text = SelectedQuestions[selectedQuestion].Answers[selectedOption];

            SelectedQuestions[selectedQuestion].Answers.Remove(SelectedQuestions[selectedQuestion].Answers[selectedOption]);
        }

        public void LoadQuestions()
        {
            SelectedQuestions = Question.questions;
        }

        private void txt_Click(object sender, EventArgs e)
        {
            if (this.Text == SelectedQuestions[selectedQuestion].RigthAwnser)
            {
                pontuation++;
            }

            SelectedQuestions.Remove(SelectedQuestions[selectedQuestion]);

            UpdateQuestion();
        }
    }
}
