using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace Laboratory_2_IDE
{
    public partial class KnowledgeControl : UserControl
    {
        private List<Question> questions;
        private Question currentQuestion;
        private int question_nr = 0;
        private int nr_correct_answers = 0;

        public KnowledgeControl()
        {
            InitializeComponent();
            questions = LoadAllQuestion();
        }

        private void specialButton2_Click(object sender, EventArgs e)
        {
            CheckQuestion();
            GotoNextQuestion();
        }


        private void specialButton1_Click(object sender, EventArgs e)
        {
            CheckQuestion();
            Form1.Instance.firstClick = true;
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Add(new MainControl())));
            Invoke((MethodInvoker)(() => Form1.Instance.panel.Controls.Remove(this)));
        }
        void GotoNextQuestion()
        {
            if (question_nr >= questions.Count - 1)
            {
                this.specialButton1.Enabled = true;
                this.specialButton2.Enabled = false;
            }

            currentQuestion = LoadQuestions(question_nr);
            this.r1.Text = currentQuestion.Answers[0];
            this.r2.Text = currentQuestion.Answers[1];
            this.r3.Text = currentQuestion.Answers[2];
            this.r4.Text = currentQuestion.Answers[3];
            this.richTextBox1.Text = currentQuestion.QuestionText;

            question_nr++;
        }
        Question LoadQuestions(int question_nr)
        {
            return questions[question_nr];
        }

        private List<Question> LoadAllQuestion()
        {
            Question question = new Question();
            return question.GetListQuestions();

        }
        void CheckQuestion()
        {
            var checkedRadio = this.groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            if (checkedRadio.Contains(currentQuestion.CorrectAnswer.ToString()))
            {
                nr_correct_answers++;
            }
        }

        private void KnowledgeControl_Load(object sender, EventArgs e)
        {
            GotoNextQuestion();
        }
    }
}
