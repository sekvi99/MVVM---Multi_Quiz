using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_04_niestacjonarne.View
{

    public partial class QuizControl : UserControl
    {
        public QuizControl()
        {
            InitializeComponent();
        }

        //Dependencja Pytania
        public static readonly DependencyProperty questionDP = DependencyProperty.Register(
            nameof(QuestionContent),
            typeof(string),
            typeof(QuizControl)
            );
        
        public string QuestionContent 
        {
            get { return (string)GetValue(questionDP); }
            set { SetValue(questionDP,value); }
        }

        //Dependencja Numeru Pytania
        public static readonly DependencyProperty numerDP = DependencyProperty.Register(
            nameof(questionNumberContent),
            typeof(string),
            typeof(QuizControl)
            );

        public string questionNumberContent
        {
            get { return (string)GetValue(numerDP); }
            set { SetValue(numerDP, value); }
        }

        //Dependencja Odpowiedzi A

        public static readonly DependencyProperty answerADP = DependencyProperty.Register(
            nameof(answerAContent),
            typeof(string),
            typeof(QuizControl)
            );

        public string answerAContent
        {
            get { return (string)GetValue(answerADP); }
            set { SetValue(answerADP, value); }
        }


        //Dependencja odpowiedzi B
        public static readonly DependencyProperty answerBDP = DependencyProperty.Register(
            nameof(answerBContent),
            typeof(string),
            typeof(QuizControl)
            );

        public string answerBContent
        {
            get { return (string)GetValue(answerBDP); }
            set { SetValue(answerBDP, value); }
        }

        //Dependencja odpowiedzi C

        public static readonly DependencyProperty answerCDP = DependencyProperty.Register(
            nameof(answerCContent),
            typeof(string),
            typeof(QuizControl)
            );

        public string answerCContent
        {
            get { return (string)GetValue(answerCDP); }
            set { SetValue(answerCDP, value); }
        }

        //Dependencja sprawdzonego Pytania

        public static readonly DependencyProperty checkedAnswerDP = DependencyProperty.Register(

            nameof(CheckedAnswer),
            typeof(int),
            typeof(QuizControl),
            new PropertyMetadata(new PropertyChangedCallback(CheckeSelection))
            );


        public int CheckedAnswer
        {
            get { return (int)GetValue(checkedAnswerDP); }
            set { SetValue(checkedAnswerDP, value); }
        }

        //Case'y radio buttonów

        private static void CheckeSelection(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            QuizControl quizControl = d as QuizControl;


            switch(e.NewValue)
            {
                case 0:
                    quizControl.rb_1.IsChecked = false;
                    quizControl.rb_2.IsChecked = false;
                    quizControl.rb_3.IsChecked = false;
                    break;
                case 1:
                    quizControl.rb_1.IsChecked = true;
                    break;
                case 2:
                    quizControl.rb_2.IsChecked = true;
                    break;
                case 3:
                    quizControl.rb_3.IsChecked = true;
                    break;
            }

            
        }

        //Sprawdzenie Radio Buttona

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton checkedRB = sender as RadioButton;
            
            if (checkedRB != null && int.TryParse(checkedRB.Tag.ToString(), out int number))
            {
                CheckedAnswer = number;
            }

        }
    }
}
