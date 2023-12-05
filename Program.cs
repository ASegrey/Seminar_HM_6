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
                    break;
                }
            }
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
    }
}