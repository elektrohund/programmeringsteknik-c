using System;
//Int, double, char, string, bool
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] chessBoard = new int[8, 8];

            int width = 128;
            int height = 128;

            byte[,] blackWhiteImage = new byte[128, 128];
            
            for (var y = 0; y < height; y++)
            {
                Console.WriteLine(y);
                for (var x = 0; x < width; x++)
                {
                    byte currentPixelValue = blackWhiteImage[x, y];
                    Console.Write(x);
                    Console.Write(' ');
                    
                }
            }
            Console.WriteLine(blackWhiteImage);

            //bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            //bool inputIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(inputData);
            //Trimma och ta bort mellanslag
            //string trimmedSentence = sentence.Trim();

            //Det går att ange ett speciellt tecken som skall tas bort
            //string.punctuationTrimmedSentence = endTrimmedSentence.TrimEnd('.');

            //string.searchForWord = "text";
            //int indexOfText = trimmedSentence.IndexOf(searchForWord);

        }
        
    }
}
