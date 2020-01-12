//Hong Li, CIS 345, Project Final, T TH 10:30 am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public delegate void QuestionEventHandler(object sender, Question q);

    public partial class QuestionEntry : Form
    {
        public event QuestionEventHandler NewQuestionCreated;
        Question newQuestion;

        private string title;
        private string choiceOne;
        private string choiceTwo;
        private string choiceThree;
        private string choiceFour;
        private string feedback;
        private int questionCount;
        private int remaining;

        public QuestionEntry()
        {
            InitializeComponent();
        }

        private void QuestionEntry_Load(object sender, EventArgs e)
        {
            titleTextBox.Enabled = false;
            answerOneTextBox.Enabled = false;
            answerTwoTextBox.Enabled = false;
            answerThreeTextBox.Enabled = false;
            answerFourTextBox.Enabled = false;
            answerOneButton.Enabled = false;
            answerTwoButton.Enabled = false;
            answerThreeButton.Enabled = false;
            answerFourButton.Enabled = false;
            feedbackTextBox.Enabled = false;
            addButton.Enabled = false;
            closeButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            title = titleTextBox.Text;
            choiceOne = answerOneTextBox.Text;
            choiceTwo = answerTwoTextBox.Text;
            choiceThree = answerThreeTextBox.Text;
            choiceFour = answerFourTextBox.Text;
            feedback = feedbackTextBox.Text;

            if (titleTextBox.Text != null && answerOneTextBox.Text !=null && answerTwoTextBox.Text != null
                && answerThreeTextBox.Text != null && answerFourTextBox.Text != null && feedbackTextBox.Text != null)
            {

                if (answerOneButton.Checked && remaining > 0 && remaining <= questionCount)
                {
                    newQuestion = new Question(title, answerOneTextBox.Text, choiceOne, choiceTwo, choiceThree, choiceFour, feedback);
                    NewQuestionCreated(this, newQuestion);
                    remaining--;
                    numberOfQuestionsLabel.Text = $"{remaining}";
                }

                else if (answerTwoButton.Checked && remaining > 0 && remaining <= questionCount)
                {
                    newQuestion = new Question(title, answerTwoTextBox.Text, choiceOne, choiceTwo, choiceThree, choiceFour, feedback);
                    NewQuestionCreated(this, newQuestion);
                    remaining--;
                    numberOfQuestionsLabel.Text = $"{remaining}";
                }

                else if (answerThreeButton.Checked && remaining > 0 && remaining <= questionCount)
                {
                    newQuestion = new Question(title, answerThreeTextBox.Text, choiceOne, choiceTwo, choiceThree, choiceFour, feedback);
                    NewQuestionCreated(this, newQuestion);
                    remaining--;
                    numberOfQuestionsLabel.Text = $"{remaining}";
                }

                else if (answerFourButton.Checked && remaining > 0 && remaining <= questionCount)
                {
                    newQuestion = new Question(title, answerFourTextBox.Text, choiceOne, choiceTwo, choiceThree, choiceFour, feedback);
                    NewQuestionCreated(this, newQuestion);
                    remaining--;
                    numberOfQuestionsLabel.Text = $"{remaining}";
                }

                else
                {
                    MessageBox.Show("Correct answer was not chosen or you have entered enough questions.");
                    return;
                }
            }

            else
            {
                MessageBox.Show("Please fill in all the text boxes.");
                return;
            }

            titleTextBox.Clear();
            answerOneTextBox.Clear();
            answerTwoTextBox.Clear();
            answerThreeTextBox.Clear();
            answerFourTextBox.Clear();
            feedbackTextBox.Clear();

            titleTextBox.Focus();


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (remaining != 0)
            {
                MessageBox.Show("You haven't finished entering all the questions.");
                return;
            }

            else
            {
                this.Close();
            }
            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numberOfQuestionTextBox.Text, out questionCount) && questionCount > 0)
            {
                remaining = questionCount;
                numberOfQuestionsLabel.Text = $"{remaining}";
                titleTextBox.Enabled = true;
                answerOneTextBox.Enabled = true;
                answerTwoTextBox.Enabled = true;
                answerThreeTextBox.Enabled = true;
                answerFourTextBox.Enabled = true;
                answerOneButton.Enabled = true;
                answerTwoButton.Enabled = true;
                answerThreeButton.Enabled = true;
                answerFourButton.Enabled = true;
                feedbackTextBox.Enabled = true;
                addButton.Enabled = true;
                closeButton.Enabled = true;

                numberOfQuestionTextBox.Enabled = false;
                confirmButton.Enabled = false;
            }

            else
            {
                MessageBox.Show("Please enter valid number.");
                return;
            }
        }
    }
}
