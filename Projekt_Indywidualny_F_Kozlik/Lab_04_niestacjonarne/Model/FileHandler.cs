using System.Collections.Generic;

namespace Lab_04_niestacjonarne.Model
{
    public static class FileHandler
    {
        //Klasa statyczna
        //Metoda statyczna zwracająca listę pytań wczytanych z pliku tekstowego

        public static List<Question> readFile(string fileName)
        {

            string[] lines = System.IO.File.ReadAllLines(fileName);
            List<Question> questionList = new List<Question>();

            int i = 1;

            while (i + 4 < lines.Length)
            {
                Question q = new Question(
                    lines[i],
                    lines[i + 1],
                    lines[i + 2],
                    lines[i + 3],
                    lines[i + 4]
                    );
                questionList.Add(q);
                i += 5;
            }
            return questionList;


        }
    }
}
