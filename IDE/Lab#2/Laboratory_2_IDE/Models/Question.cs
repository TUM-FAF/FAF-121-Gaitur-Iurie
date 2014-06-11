using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Models
{
    public class Question
    {

        public Question()
        {
            Answers = new string[4];
        }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer { get; set; }


        public List<Question> GetListQuestions()
        {
            List<Question> questionsList = new List<Question>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Quiz.xml");
            XmlNode node = doc.SelectSingleNode("quiz");
            XmlNodeList questions = node.SelectNodes("question");
            foreach (XmlNode question in questions)
            {
                Question _question = new Question();
                _question.QuestionText = question.FirstChild.InnerText;

                for (int i = 0; i < question.LastChild.ChildNodes.Count; i++)
                {

                    _question.Answers[i] = question.LastChild.ChildNodes[i].InnerText;
                    if (question.LastChild.ChildNodes[i].Name == "correctAnswer")
                        _question.CorrectAnswer = i+1;

                }
                questionsList.Add(_question);
            }


            return questionsList;
        }

    }
}
