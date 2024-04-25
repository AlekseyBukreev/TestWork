namespace TaskBukreev
{
    public class Task4
    {
        private int sizeTable = 0;

        private string _indentation = " ";

        public void WorkTask4()
        {
            Console.Write("Укажите число до которого необходимо вывести таблицу умножения: ");

            sizeTable = Convert.ToInt32(Console.ReadLine());

            int _maxLenght = Convert.ToString(sizeTable * sizeTable).Length;

            int[,] _tableMultiplication = new int[sizeTable + 1, sizeTable + 1];

            string[,] _tableInfo = new string[sizeTable + 1, sizeTable + 1];

            string[,] _tableMult = new string[sizeTable + 1, sizeTable + 1];


            Console.WriteLine();

            for (int i = 0; i <= sizeTable; i++)
            {
                for (int j = 0; j <= sizeTable; j++)
                {
                    if (i == 0)
                    {
                        _tableInfo[i, j] = $"{j}";
                    }
                    if (j == 0 && i != 0)
                    {
                        _tableInfo[i, j] = $"{i}";
                    }
                }
            }

            for (int i = 0; i <= sizeTable; ++i)
            {
                for (int j = 0; j <= sizeTable; ++j)
                {
                    if (i > 0 && j > 0)
                    {
                        _tableMultiplication[i, j] = i * j;
                    }
                    else
                    {
                        _tableMultiplication[i, j] = 0;
                    }
                }
            }


            for (int i = 0; i <= sizeTable; i++)
            {
                for (int j = 0; j <= sizeTable; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (i >= 10)
                        {
                            for (int k = 0; k <= (_maxLenght - Convert.ToString(i * j).Length - 1); k++)
                                Console.Write(_indentation);

                            Console.Write(_tableInfo[i, j]);
                        }
                        else if (j >= 10)
                        {
                            for (int k = 0; k <= (_maxLenght - Convert.ToString(i * j).Length - 1); k++)
                                Console.Write(_indentation);

                            Console.Write(_tableInfo[i, j]);
                        }
                        else
                        {
                            for (int k = 0; k <= (_maxLenght - Convert.ToString(i * j).Length); k++)
                                Console.Write(_indentation);

                            Console.Write(_tableInfo[i, j]);
                        }
                    }
                    if (i > 0 && j > 0)
                    {
                        for (int k = 0; k <= (_maxLenght - Convert.ToString(i * j).Length); k++)
                            Console.Write(_indentation);

                        Console.Write($"{_tableMultiplication[i, j]}");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }

}
