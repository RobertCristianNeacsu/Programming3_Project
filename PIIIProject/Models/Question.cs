namespace PIIIProject.Models
{
    public class Question
    {
        #region Fields

        private string _theQuestion;
        private string _answerA;
        private string _answerB;
        private string _answerC;
        private string _answerD;

        private string _rightAnswer;
        private string _userAnswer;


        #endregion

        #region Properties

        public string TheQuestion
        {
            get
            {
                return _theQuestion;
            }
            private set
            {
                _theQuestion = value;
            }
        }

        public string RightAnswer
        {
            get
            {
                return _rightAnswer;
            }
            private set
            {
                _rightAnswer = value;
            }
        }

        public string AnswerA
        {
            get
            {
                return _answerA;
            }
            private set
            {
                _answerA = value;
            }
        }

        public string AnswerB
        {
            get
            {
                return _answerB;
            }
            private set
            {
                _answerB = value;
            }
        }

        public string AnswerC
        {
            get
            {
                return _answerC;
            }
            private set
            {
                _answerC = value;
            }
        }

        public string AnswerD
        {
            get
            {
                return _answerD;
            }
            private set
            {
                _answerD = value;
            }
        }

        public string UserAnswer
        {
            get
            {
                return _userAnswer;
            }
            set
            {
                _userAnswer = value.ToString();
            }
        }

        #endregion

        #region Methods

        public bool Result()
        {

            if (_userAnswer == _rightAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Constructors

        public Question(string theQuestion_, string answerA_, string answerB_, string answerC_, string answerD_, string rightAnswer_)
        {
            TheQuestion = theQuestion_;

            AnswerA = answerA_;
            AnswerB = answerB_;
            AnswerC = answerC_;
            AnswerD = answerD_;

            RightAnswer = rightAnswer_;
        }

        #endregion


    }
}
