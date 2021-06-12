
using System.Windows.Input;

using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.IO;
using Microsoft.Expression.Interactivity.Core;

namespace Lab_04_niestacjonarne.ViewModel
{
    using BaseClass;
    using System.Windows.Input;
    using Model;

    class QuizViewModel : ViewModelBase
    {
        //Utworzenie Obserwowowalnej Kolekcji Quizów
        public ObservableCollection<Quiz> quizList { get; set; } = new ObservableCollection<Quiz>();

        //Utworzenie instancji modelu we ViewModelu
        private Quiz currentQuiz = new Quiz("pytania.txt");
        #region Wlasciwosci

        //Zmiana pytania na odpowiednią wartość podpiętą pod odpowiedź tj. odp A -> 1, odp B -> 2, odp C -> 3
        public int CheckedAnswer
        {
            get 
            {
                if (currentQuiz.currentQuestion.choosenAnswer == currentQuiz.currentQuestion.answerA) return 1;
                if (currentQuiz.currentQuestion.choosenAnswer == currentQuiz.currentQuestion.answerB) return 2;
                if (currentQuiz.currentQuestion.choosenAnswer == currentQuiz.currentQuestion.answerC) return 3;
                return 0;
            }
               
                
            set {
                switch(value)
                {
                    case 1:
                        currentQuiz.currentQuestion.choosenAnswer = currentQuiz.currentQuestion.answerA;
                        break;
                    case 2:
                        currentQuiz.currentQuestion.choosenAnswer = currentQuiz.currentQuestion.answerB;
                        break;
                    case 3:
                        currentQuiz.currentQuestion.choosenAnswer = currentQuiz.currentQuestion.answerC;
                        break;
                }
                onPropertyChanged(nameof(CheckedAnswer));
            }
        }

        //Pobranie Numeru pytania z modeli

        public string QuestionNumber
        {
            get
            {
                return "Lp: " + (currentQuiz.questionList.IndexOf(currentQuiz.currentQuestion) + 1);
            }
        }

        //Pobranie Treści pytania z modelu

        public string QuestionContent
        {
            get => currentQuiz.currentQuestion.question.ToString();
        }

        //Pobranie Odpowiedzi A z modeli

        public string GetAnswerA
        {
            get => currentQuiz.currentQuestion.answerA.ToString();
        }

        //Pobranie Odpowiedzi B z modeli

        public string GetAnswerB
        {
            get => currentQuiz.currentQuestion.answerB.ToString();
        }

        //Pobranie Odpowiedzi C z modeli

        public string GetAnswerC
        {
            get => currentQuiz.currentQuestion.answerC.ToString();
        }

        #endregion

        #region Polecenia

        //Polecenie wykonujące się podczas ładowania Okna
        private ICommand windowsLoaded;

        public ICommand WindowsLoaded => windowsLoaded ?? (windowsLoaded = new RelayCommand(

            p=>{

                string[] files = Directory.GetFiles(".", "*.txt");
                foreach (string file in files)
                {
                    quizList.Add(new Quiz(file));
                   
                }
                UpdateView();
            }
            ,
            p=>true
            )
            
            );

        //Polecenie wykonujące się podczas klikania na przycisk następnego pytania

        private ICommand nextQuestion;

        public ICommand NextQuestion => nextQuestion ?? (nextQuestion = new RelayCommand(

            p => {
                currentQuiz.nextQuestion();
                UpdateView();

            }
            ,
            p => true
            )
                
            );

        //Polecenie wykonujące się podczas klikania na przycisk poprzedniego pytania

        private ICommand previousQuestion;

        public ICommand PreviousQuestion => previousQuestion ?? (previousQuestion = new RelayCommand(

            p => {
                currentQuiz.previousQuestion();
                UpdateView();

            }
            ,
            p => true
            )

            );

        //Polecenie wykonujące się podczas klikania na przycisk sprawdzenia wyniku

        private ICommand checkScore;

        public ICommand ChceckScore => checkScore ?? (checkScore = new RelayCommand(

            p => {
                int score = currentQuiz.returnScore();
                MessageBox.Show("Ilość zdobytych punktów: " + score.ToString(), "Zdobyte Punkty");

            }
            ,
            p => true
            )

            );

        //Polecenie do zmiany wyswietlanego quizu
        private ICommand quizSelectionCHanged;
        public ICommand QuizSelectionChanged => quizSelectionCHanged ?? (quizSelectionCHanged =  new RelayCommand(
                selected_quiz => {
                    currentQuiz = (Quiz)selected_quiz;
                    UpdateView();
                },
                p => true)
            );


        //Metoda do updateowania widoku

        private void UpdateView()
        {
            onPropertyChanged(
                nameof(currentQuiz.currentQuestion),
                nameof(QuestionContent),
                nameof(GetAnswerA),
                nameof(GetAnswerB),
                nameof(GetAnswerC),
                nameof(CheckedAnswer),
                nameof(QuestionNumber),
                nameof(quizList)
 
            );
        }



        #endregion


    }
}
