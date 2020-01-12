//Hong Li, CIS 345, Project Final, T TH 10:30 am
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class Main : Form
    {

        QuestionEntry entryForm;
        QuestionSearch searchForm;
        GameForm playGame;
        BindingList<Question> listOfQuestions;


        public Main()
        {
            InitializeComponent();
        }

        //pull out a form that adds a question
        private void createButton_Click(object sender, EventArgs e)
        {
            entryForm = new QuestionEntry();
            entryForm.NewQuestionCreated += new QuestionEventHandler(this.QuestionEntry_NewQuestionCreated);
            entryForm.Show();
        }

        private void QuestionEntry_NewQuestionCreated(object sender, Question q)
        {
            listOfQuestions.Add(q);
        }

        private void QuestionEdit_NewQuestionUpdated(object sender, Question q)
        {
            listOfQuestions.ResetBindings();
            timer.Enabled = true;
            statusLabel.Text = "Selected question edited successfully.";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            listOfQuestions = new BindingList<Question>();
            questionListBox.DataSource = listOfQuestions;
        }

        //pull out a form that adds a question
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryForm = new QuestionEntry();
            entryForm.NewQuestionCreated += new QuestionEventHandler(this.QuestionEntry_NewQuestionCreated);
            entryForm.Show();
        }

        //open button to open saved file that contains list of questions
        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                DialogResult dr = openFileDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;

                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    BinaryFormatter bf = new BinaryFormatter();
                    listOfQuestions = (BindingList<Question>)bf.Deserialize(file);

                    questionListBox.DataSource = listOfQuestions;
                    statusLabel.Text = "Data loaded successfully.";
                    timer.Enabled = true;
                }
            }

            catch
            {
                statusLabel.Text = "Failed to load data.";
                timer.Enabled = true;
            }
        }

        //save button to save the current list of questions
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;

                try
                {

                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, listOfQuestions);

                    file.Close();
                    statusLabel.Text = "File saved successfully";
                    timer.Enabled = true;
                }

                catch
                {
                    statusLabel.Text = "Failed to save file";
                    timer.Enabled = true;
                }
            }
        }

        //timer for the status label
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            statusLabel.Text = "Trivia Game!";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // need to add a form to ask the users if they really want to exit
            Environment.Exit(0);
        }

        //Remove button, select a quesiton from the listBox, then click this button
        //to remove the selected question
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem != null)
            {
                Question selectedQuestion = new Question();
                selectedQuestion = (Question)questionListBox.SelectedItem;
                listOfQuestions.Remove(selectedQuestion);
            }

            else
            {
                MessageBox.Show("Please select a question you want to remove from this game.");
                return;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem != null)
            {
                Question selectedQuestion = new Question();
                QuestionEdit editForm;

                selectedQuestion = (Question)questionListBox.SelectedItem;
                editForm = new QuestionEdit(selectedQuestion);

                editForm.QuestionUpdated += new QuestionEventHandler(this.QuestionEdit_NewQuestionUpdated);

                editForm.Show();
            }

            else
            {
                MessageBox.Show("Please select a question to edit.");
                return;
            }
        }

        private void searchQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchForm = new QuestionSearch(listOfQuestions);
            searchForm.Show();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playGame = new GameForm(listOfQuestions);
            playGame.Show();
            return;
        }
    }
}
