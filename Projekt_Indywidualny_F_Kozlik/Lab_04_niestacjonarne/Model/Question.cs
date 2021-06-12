using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_niestacjonarne.Model
{
    public class Question
    {
        //Treść z pliku tekstowego składa się z Odpowiedzi A, Odpowiedzi B, Odpowiedzi C, Pytania oraz Poprawnej Odpowiedzi
        public string answerA, answerB, answerC, question;
        public string corrected;

        //Odpowiedź wybrana przez użytkownika
        public string choosenAnswer;
        
        //Initzalizowanie zmiennych, za pomocą wartości pochodzących z pliku .txt
        public Question(string question, string answerA, string answerB, string answerC, string corrected)
        {
            this.question = question;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.corrected = corrected;
        }

    }
}
