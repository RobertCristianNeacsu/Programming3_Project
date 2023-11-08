using PIIIProject.Models;
using System;
using System.IO;
using System.Windows;

namespace PIIIProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int ANSWERNUMBER = 5; //Answer is the 5th line after the question

        private int _rightAnswers = 0;
        private int _numQuestions = 0;
        private string[] _questions;
        private int _answerIndex = 0; //When added with ANSWERNUMBER you'll get the index of the answer for the question EX:question 1 --> 5, question 2 --> 10

        Question question; //Create the Question object now but don't give it values;


        public MainWindow()
        {
            InitializeComponent();
            
        }

        public int GetRightAnswers()
        {
            return _rightAnswers;
        }

        public string[] GetQuestions()
        {
            return _questions;
        }

        public int GetNumOfQuestions()
        {
            return _numQuestions;
        }

       

        //Load the questions and answers from the file and save them to _questions
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            //Hide button
            btnLoad.Visibility = Visibility.Collapsed;
            

            //Reset all of these
            _rightAnswers = 0;
            _answerIndex = 0;
            _numQuestions = 0;

            //Open the file dialog window
            string newFile = "";
            Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                openFile.Filter = "Text files (*.txt)|*.txt";
                newFile = openFile.FileName;
                
            }

            //Load the file
            if (VerifyFile(newFile) != true)
            {
                MessageBox.Show("File is not the right length. Should be 6 lines or more for: Question, Choices x 4, Right Answer", "Problem with file", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                _questions = GetQuestions(newFile);
                LoadAnswers();
                lblQuestion.Visibility = Visibility.Visible;
                spChoice.Visibility = Visibility.Visible;
                btnNext.Visibility = Visibility.Visible;
                btnEndQuiz.Visibility = Visibility.Visible;
            }
        }

        //Validate answer and go to next question
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer();
            _answerIndex += ANSWERNUMBER + 1; //Changes answerIndex to be + 6 for the next question
            if (_answerIndex < _questions.Length) //If there's still questions left
            {
                LoadAnswers(); //Load the next answers
            }
            else //No more questions
            {
                MessageBox.Show("You have answered all questions!", "Finished", MessageBoxButton.OK, MessageBoxImage.None);
                QuizResults resultsWindow = new QuizResults(_rightAnswers, _numQuestions/*,_answers,_questions*/);

                resultsWindow.ShowDialog();
                this.Close();
            }
        }

        //Brings you to the result page
        private void btnEndQuiz_Click(object sender, RoutedEventArgs e)
        {
            QuizResults resultsWindow = new QuizResults(_rightAnswers, _numQuestions/*,_answers,_questions*/);

            resultsWindow.ShowDialog();
            this.Close();
        }

        //Verifies if the file is the appropriate length
        public static bool VerifyFile(string source)
        {
            if (File.Exists(source))
            {
                try
                {
                    string[] allLines = File.ReadAllLines(source);
                    if (allLines.Length > ANSWERNUMBER) //More than 5 lines for Questions, answers and right answer
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }

            return false;
        }


        //Saves text from questions.txt
        public static string[] GetQuestions(string source)
        {
            if (File.Exists(source))
            {
                try
                {
                    return File.ReadAllLines(source);
                }
                catch (Exception)
                {

                    return null;
                }
            }

            return null;
        }


        //Fills the question and answers with the right values
        public void LoadAnswers()
        {
            //The indexes for the answer values
            const int INDEXA = 1;
            const int INDEXB = 2;
            const int INDEXC = 3;
            const int INDEXD = 4;
            const int INDEX_RIGHT = 5;

            //Add 1 to the number of questions answered
            _numQuestions++;

            //Create a question object and send the data from the file
            question = new Question(_questions[_answerIndex], _questions[_answerIndex + INDEXA], _questions[_answerIndex + INDEXB], _questions[_answerIndex + INDEXC], _questions[_answerIndex + INDEXD], _questions[_answerIndex + INDEX_RIGHT]);

            //Fill the info
            txbQuestion.Text = question.TheQuestion;
            rdbChoiceOne.Content = question.AnswerA;
            rdbChoiceTwo.Content = question.AnswerB;
            rdbChoiceThree.Content = question.AnswerC;
            rdbChoiceFour.Content = question.AnswerD;

           
        }


        //Verifies the answer. If it's equal to the answer index's value then it's right
        public void CheckAnswer()
        {

            if (rdbChoiceOne.IsChecked.Value)
            {
                question.UserAnswer = question.AnswerA;
                
                if (question.Result())
                {
                    _rightAnswers++;

                    MessageBox.Show("Your answer was correct!", "Right Answer", MessageBoxButton.OK, MessageBoxImage.None);
                    return;
                }

                else
                {
                    MessageBox.Show("Your answer was not correct...", "Wrong Answer", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                }
            }
            else if (rdbChoiceTwo.IsChecked.Value)
            {
                question.UserAnswer = question.AnswerB;

                if (question.Result())
                {
                    _rightAnswers++;
                    MessageBox.Show("Your answer was correct!", "Right Answer", MessageBoxButton.OK, MessageBoxImage.None);
                    return;
                }
                else
                {
                    MessageBox.Show("Your answer was not correct...", "Wrong Answer", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                }
            }
            else if (rdbChoiceThree.IsChecked.Value)
            {
                question.UserAnswer = question.AnswerC;

                if (question.Result())
                {
                    _rightAnswers++;
                    MessageBox.Show("Your answer was correct!", "Right Answer", MessageBoxButton.OK, MessageBoxImage.None);
                    return;
                }
                else
                {
                    MessageBox.Show("Your answer was not correct...", "Wrong Answer", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                }
            }
            else if (rdbChoiceFour.IsChecked.Value)
            {
                question.UserAnswer = question.AnswerD;

                if (question.Result())
                {
                    _rightAnswers++;
                    MessageBox.Show("Your answer was correct!", "Right Answer", MessageBoxButton.OK, MessageBoxImage.None);
                    return;
                }
                else
                {
                    MessageBox.Show("Your answer was not correct...", "Wrong Answer", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                }

            }
        }
    }
}
