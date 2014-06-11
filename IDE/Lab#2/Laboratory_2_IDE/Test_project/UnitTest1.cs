using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Test_project
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void QuizReturnNotNullTest()
        {
            Question question = new Question();
            List<Question> questions = question.GetListQuestions();
            
            Assert.IsNotNull(questions);
        }
    }
}
