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
    public partial class QuestionSearch : Form
    {
        private BindingList<Question> currentList;
        private BindingList<Question> searchResult;

        public QuestionSearch()
        {
            InitializeComponent();
        }

        //overloaded constructor for the search form, takes the question list as a parameter
        public QuestionSearch(BindingList<Question> questionList)
        {
            InitializeComponent();
            currentList = questionList;
        }

        //event handler for the search Button
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchWord = searchTextBox.Text;
            searchResult = new BindingList<Question>();
            
            //loop through all the questions in the list, and find out which ones contain the search word
            foreach(Question q in currentList)
            {
                if (q.Title.Contains(searchWord) || q.ChoiceOne.Contains(searchWord) || q.ChoiceTwo.Contains(searchWord) ||
                    q.ChoiceThree.Contains(searchWord) || q.ChoiceFour.Contains(searchWord) || q.CorrectAnswer.Contains(searchWord) ||
                    q.Feedback.Contains(searchWord))
                {
                    searchResult.Add(q);
                }
            }

            questionListBox.DataSource = searchResult;
        }

        //button that closes the form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
