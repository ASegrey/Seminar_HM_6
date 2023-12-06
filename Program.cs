namespace Tasks
{
    static class Program
    {
        public static void Main (string [] args)
        {
            Console.Clear();
            string stringLoad = "Введите номер задачи (от 1 до 4) => ";
            System.Console.Write(stringLoad);
            Tasks(NumberInTerminal(4,stringLoad));
        }
        static void Tasks(int num)
        {
            switch (num)
            {
                case 1:
                {
                    System.Console.WriteLine("Задача 1: Задайте двумерный массив символов (тип char [,]).");
                    System.Console.WriteLine("Создать строку из символов этого массива.");
                    char [,] array = CreateCharArray(); 
                    System.Console.WriteLine("Исходный массив:");
                    PrintArray(array);
                    System.Console.WriteLine("Строка из символов массива:");
                    PrintArrayInLine(array);
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.");
                    System.Console.WriteLine("Сформируйте строку, в которой все заглавные буквы заменены на строчные.");
                    string newRandomString = CreateStringChar(); 
                    System.Console.WriteLine($"Исходная строка => {newRandomString}");
                    System.Console.WriteLine($"Измененная строка => {ModString(newRandomString)}");
                    break;
                }
            }
        }

        public static string ModString(string inputString)
        {
            int length = inputString.Length;
            string outputString = "";
            for (int i = 0; i < length; i++)
            {
                if ((int)inputString[i] > 64 && (int)inputString[i] < 91)
                {
                    int ascii = (int)inputString[i] + 32;
                    outputString += (char)ascii;
                }
                    else{outputString += inputString[i];}
            }
            return outputString;
        }
        /*Функция ввода чисел в терминале*/
        public static int NumberInTerminal(int numberDigits, string repeatString)
        {
            string ? numString = Console.ReadLine();
            int numInt = 0;
            while ((!Int32.TryParse(numString,out numInt)) 
                    || !(numInt > 0) 
                    || !(numInt <= numberDigits)
                  )
            {
                System.Console.WriteLine("Ошибка ввода, повторите");
                System.Console.Write(repeatString);
                numString = Console.ReadLine(); 
            }
            return numInt;
        }
        public static char [,] CreateCharArray(int rows = 5, int cols = 5)
        {
            char [,] array = new char [rows,cols];
            Random rand = new();
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            int length = chars.Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i,j] = chars[rand.Next(0,length)];
                }
            }
            return array;
        }  
        public static string CreateStringChar(int length = 20)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789!-+*/.:;'?&^%$#@";
            string charString = "";
            Random rand = new();
            int lengthConst = chars.Length;
            for (int i = 0; i < length; i++)
            {
                charString += chars[rand.Next(0,lengthConst)];
            }
            return charString;

        }
        public static void PrintArray(char [,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string output = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    output += array[i,j] + " ";
                }
                System.Console.WriteLine($"[ {output}]");
                output = "";
            }
        }
        public static void PrintArrayInLine(char [,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += array[i,j];
                }
            }
            System.Console.WriteLine($"\"{result}\"");
        }
    }
}