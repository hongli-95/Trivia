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
using System.Media;

namespace TriviaNow
{
    public partial class GameForm : Form
    {
        private BindingList<Question> currentList;
        private BindingList<Question> playList;
        SoundPlayer sound;
        Random x = new Random();
        private int questionCount = 0;
        private int correctCount = 0;

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(BindingList<Question> listOfQuestion)
        {
            InitializeComponent();

            currentList = new BindingList<Question>();

            for (int i = 0; i < listOfQuestion.Count; i++)
            {
                currentList.Add(listOfQuestion[i]);
            }

            playList = new BindingList<Question>();

            for (int i = 0; i < currentList.Count + playList.Count; i++)
            {
                playList.Add(currentList[x.Next(0, (currentList.Count) - 1)]);
                currentList.Remove(playList[i]);
            }

            questionLabel.Text = playList[questionCount].Title;
            answerOneButton.Text = playList[questionCount].ChoiceOne;
            answerTwoButton.Text = playList[questionCount].ChoiceTwo;
            answerThreeButton.Text = playList[questionCount].ChoiceThree;
            answerFourButton.Text = playList[questionCount].ChoiceFour;
            answerOneButton.Checked = true;

            questionCountLabel.Text = playList.Count.ToString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            
                if (playList[questionCount].CorrectAnswer == answerOneButton.Text && answerOneButton.Checked == true)
                {
                    MessageBox.Show($"Nice! {playList[questionCount].Feedback}");
                    sound = new SoundPlayer(@".\ProjectBeta\ProjectBeta\bin\quite-impressed.wav");
                    questionCountLabel.Text = $"{(playList.Count - questionCount -1)}";
                    questionCount++;
                    correctCount++;
                }

                else if (playList[questionCount].CorrectAnswer == answerTwoButton.Text && answerTwoButton.Checked == true)
                {
                    MessageBox.Show($"Nice! {playList[questionCount].Feedback}");
                    sound = new SoundPlayer(@".\ProjectBeta\ProjectBeta\bin\quite-impressed.wav");
                    questionCountLabel.Text = $"{(playList.Count - questionCount -1)}";
                    questionCount++;
                    correctCount++;
                }

                else if (playList[questionCount].CorrectAnswer == answerThreeButton.Text && answerThreeButton.Checked == true)
                {
                    MessageBox.Show($"Nice! {playList[questionCount].Feedback} ");
                    sound = new SoundPlayer(@".\ProjectBeta\ProjectBeta\bin\quite-impressed.wav");
                    questionCountLabel.Text = $"{(playList.Count - questionCount -1)}";
                    questionCount++;
                    correctCount++;
                }

                else if (playList[questionCount].CorrectAnswer == answerFourButton.Text && answerFourButton.Checked == true)
                {
                    MessageBox.Show($"Nice! {playList[questionCount].Feedback} ");
                    sound = new SoundPlayer(@".\ProjectBeta\ProjectBeta\bin\quite-impressed.wav");
                    questionCountLabel.Text = $"{(playList.Count - questionCount -1)}";
                    questionCount++;
                    correctCount++;
                }

                else
                {
                    MessageBox.Show($"Feels bad man... {playList[questionCount].Feedback}");
                    sound = new SoundPlayer(@".\ProjectBeta\ProjectBeta\bin\dun_dun_dun-.wav");
                    questionCountLabel.Text = $"{(playList.Count - questionCount -1)}";
                    questionCount++;
                }

                if (questionCount < playList.Count)
                {
                    questionLabel.Text = playList[questionCount].Title;
                    answerOneButton.Text = playList[questionCount].ChoiceOne;
                    answerTwoButton.Text = playList[questionCount].ChoiceTwo;
                    answerThreeButton.Text = playList[questionCount].ChoiceThree;
                    answerFourButton.Text = playList[questionCount].ChoiceFour;
                    answerOneButton.Checked = true;
                }

                else
                {
                    MessageBox.Show($"Your Score is {correctCount} / {playList.Count} ! ");
                    this.Close();
                }
                
            
            
        }
    }
}
