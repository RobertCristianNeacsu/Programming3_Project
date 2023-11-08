using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace PIIIProject
{
    /// <summary>
    /// Interaction logic for QuizResults.xaml
    /// </summary>
    public partial class QuizResults : Window
    {
        private int _finalResults = 0;
        private int _questionNumbers = 0;
        

        public QuizResults(int results, int numQuestions)
        {
            InitializeComponent();
            _finalResults = results;
            _questionNumbers = numQuestions;

            FillResults();

        }

        //Saves file
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string fileText = "Correct Answers: " + _finalResults + " Questions Answered: " + _questionNumbers;


            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt"
            };
            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);


                MessageBox.Show("Results file saved", "File Saved", MessageBoxButton.OK, MessageBoxImage.None);

            }
        }

        //Closes window
        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using the quiz", "Thank you", MessageBoxButton.OK, MessageBoxImage.None);
            DialogResult = true;
        }

        //Adds the results to the textbox
        public void FillResults()
        {

            txbResults.Text = "Correct Answers: " + _finalResults + " Questions Answered: " + _questionNumbers;
           

        }
    }
}
