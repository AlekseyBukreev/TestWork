namespace TaskBukreev
{
    public class Task1
    {
        private int value = 0;
        private int chekCout = 0;

        private string outWord = "компьютер";
        private string[] wordComputer = new string[]
                {
                "компьютер",
                "компьютера",
                "компьютеров"
                };

        public void WorkTask1()
        {

            Console.Write("Введите число компьютеров: ");

            value = Convert.ToInt32(Console.ReadLine());

            if (value > 100)
            {
                chekCout = value % 100;
                outWord = Declension(chekCout, 10, outWord, wordComputer[0], wordComputer[1], wordComputer[2]);
            }
            else
            {
                outWord = Declension(value, 10, outWord, wordComputer[0], wordComputer[1], wordComputer[2]);
            }

            Console.WriteLine($"\n\n{value} {outWord}");
            Console.WriteLine("\n\n");


        }
        string Declension(int number, int devider, string outText, string firtVariation, string secondVariation, string lastVariation)
        {
            if (number % devider == 1 && number != 11)
            {
                outText = firtVariation;
            }
            else if (number % devider > 1 && number % 10 < 5 && number > 20 || number > 1 && number < 5)
            {
                outText = secondVariation;
            }
            else
            {
                outText = lastVariation;
            }
            return outText;
        }
    }
}
