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
    public partial class QuestionEdit : Form
    {
        //create custom event
        public event QuestionEventHandler QuestionUpdated;


        Question tmpQuestion;

        //load the info of the selected question into the form when the form was loaded
        public QuestionEdit(Question q)
        {
            InitializeComponent();

            tmpQuestion = q;

            titleTextBox.Text = q.Title;

            answerOneTextBox.Text = tmpQuestion.ChoiceOne;
            answerTwoTextBox.Text = tmpQuestion.ChoiceTwo;
            answerThreeTextBox.Text = tmpQuestion.ChoiceThree;
            answerFourTextBox.Text = tmpQuestion.ChoiceFour;
            feedbackTextBox.Text = tmpQuestion.Feedback;

            if (tmpQuestion.CorrectAnswer == answerOneTextBox.Text)
            {
                answerOneButton.Checked = true;
            }

            else if(tmpQuestion.CorrectAnswer == answerTwoTextBox.Text)
            {
                answerTwoButton.Checked = true;
            }

            else if(tmpQuestion.CorrectAnswer == answerTwoTextBox.Text)
            {
                answerThreeButton.Checked = true;
            }

            else
            {
                answerFourButton.Checked = true;
            }
        }

        // check all the fields and finish updating the seleced question
        private void finishButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != null && answerOneTextBox.Text != null && answerTwoTextBox.Text != null
                && answerThreeTextBox.Text != null && answerFourTextBox.Text != null && feedbackTextBox.Text != null)
            {
                tmpQuestion.Title = titleTextBox.Text;
                tmpQuestion.ChoiceOne = answerOneTextBox.Text;
                tmpQuestion.ChoiceTwo = answerTwoTextBox.Text;
                tmpQuestion.ChoiceThree = answerThreeTextBox.Text;
                tmpQuestion.ChoiceFour = answerFourTextBox.Text;
                tmpQuestion.Feedback = feedbackTextBox.Text;

                if (answerOneButton.Checked == true)
                {
                    tmpQuestion.CorrectAnswer = answerOneTextBox.Text;
                }

                else if (answerTwoButton.Checked == true)
                {
                    tmpQuestion.CorrectAnswer = answerTwoTextBox.Text;
                }

                else if (answerThreeButton.Checked == true)
                {
                    tmpQuestion.CorrectAnswer = answerThreeTextBox.Text;
                }

                else if (answerFourButton.Checked == true)
                {
                    tmpQuestion.CorrectAnswer = answerFourTextBox.Text;
                }

                Question replacementQuestion = new Question(tmpQuestion.Title, tmpQuestion.CorrectAnswer, tmpQuestion.ChoiceOne, 
                                                            tmpQuestion.ChoiceTwo, tmpQuestion.ChoiceThree, tmpQuestion.ChoiceFour,
                                                            tmpQuestion.Feedback);

                if (QuestionUpdated != null)
                {
                    QuestionUpdated(this, replacementQuestion);
                }

                this.Close();
            }

            else
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            
        }
    }
}
