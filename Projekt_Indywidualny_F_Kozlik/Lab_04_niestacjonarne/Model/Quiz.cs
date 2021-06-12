using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_niestacjonarne.Model
{
    class Quiz
    {
        //Lista pytań
        public List<Question> questionList;
        //Obecne pytanie występujące w Quizie
        public Question currentQuestion;
        //Tytuł Quizu
        public string title { get; set; }

        //Przeciążenie operatora []
        public Question this[int n]
        {
            get => questionList[n];
        }

        //Konstruktor
        //Initzalizuje Liste<Quiz> pytaniami z pliku tekstowego
        //Ustawienie Obecnego pytania na pierwsze z listy
        //Przypisanie tytułu
        public Quiz(string fileName)
        {
            questionList = FileHandler.readFile(fileName);
            currentQuestion = questionList[0];
            title = fileName;
        }

        //Metoda odpowiedzialna za zwracanie wyniku 
        public int returnScore()
        {
            int score = 0;
            foreach (Question question in questionList)
            {
                if (question.corrected == question.choosenAnswer)
                {
                    score++;
                }
            }

            return score;
        }

        //Metoda odpowiedzialna za przejście do następnego pytania
       public void nextQuestion()
        {
            if (currentQuestion == questionList[questionList.Count - 1]) return;
            else
            {
                currentQuestion = questionList[questionList.IndexOf(currentQuestion) + 1];
                
            }
        }

        //Metoda odpowiedzialna za przejście do poprzedniego pytania
        public void previousQuestion()
        {
            if (currentQuestion == questionList[0]) return;
            else
            {
                currentQuestion = questionList[questionList.IndexOf(currentQuestion) - 1];
                
            }
        }

    }
}
