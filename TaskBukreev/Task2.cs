namespace TaskBukreev
{
    public class Task2
    {
        private List<int> arrayInput = new List<int>();
        private List<int> baseArray = new List<int>();
        private List<int> chekDivision = new List<int>();
        public List<int> arrayCommonDivison{ get; private set; } = new List<int>();

        private int count = 0;
        private int minValue = int.MaxValue;

        private string[] numberElement =
                {
                    "первое",
                    "второе",
                    "третье",
                    "четвертое",
                    "пятое"
                };

        public void WorkTask2()
        {
            Console.Write("Введите величину массива (min: 2, max: 5): ");

            int sizeArray = Convert.ToInt32(Console.ReadLine());

            if (sizeArray > 5)
            {
                sizeArray = 5;
            }
            else if (sizeArray <= 1)
            {
                sizeArray = 2;
            }

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write($"Введите {numberElement[i]} число массива: ");
                arrayInput.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < arrayInput.Count; i++)
            {
                if (arrayInput[i] < minValue && arrayInput[i] > 1)
                {
                    minValue = arrayInput[i];
                }
            }

            for (int j = 2; j <= minValue; j++)
            {
                for (int i = 0; i < arrayInput.Count; i++)
                {
                    if (arrayInput[i] % j == 0)
                    {
                        count++;
                    }
                }

                if (count >= arrayInput.Count)
                {
                    arrayCommonDivison.Add(j);
                }

                count = 0;
            }

            Console.WriteLine("\n");
            Console.Write("Общие делители: ");

            for (int i = 0; i < arrayCommonDivison.Count; i++)
            {
                Console.Write(arrayCommonDivison[i] + " ");
            }

            Console.WriteLine("\n\n");

        }
    }
}

