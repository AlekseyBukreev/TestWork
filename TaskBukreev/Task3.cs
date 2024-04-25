namespace TaskBukreev
{
    public class Task3
    {
        public int minValue { get; private set; }
        public int maxValue { get; private set; }
        private int cheak = 0;

        public List<int> simpleValue { get; private set; } = new List<int>();

        public void WorkTask3()
        {

            Console.Write("Введите нижнюю границу диапазона поиска простых чисел: ");

            minValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите верхнюю границу диапазона поиска простых чисел: ");

            maxValue = Convert.ToInt32(Console.ReadLine());

            for (int i = minValue; i <= maxValue; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cheak++;
                    }
                }

                if (cheak < 2 && i > 1)
                {
                    simpleValue.Add(i);
                }

                cheak = 0;
            }


            Console.Write($"\nПростые числа из диапазона ({minValue} - {maxValue}): ");

            for (int i = 0; i < simpleValue.Count; i++)
            {
                if (i < simpleValue.Count - 1)
                {
                    Console.Write(simpleValue[i] + ", ");
                }
                else
                {
                    Console.Write(simpleValue[i] + ".\n\n\n");
                }
            }
        }
    }
}
