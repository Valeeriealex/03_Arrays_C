using System;

namespace Tasks_IJunior
{
   internal class _03_Arrays
   {
       static void Main(string[] args)
       {
           //Дан двумерный массив.
           //Вычислить сумму второй строки и произведение первого столбца. Вывести исходную матрицу и результаты вычислений. 

           int[,] array = new int[3, 3] {
            {1, 2, 3}, // 0
            {1, 2, 3}, // 1
            {2, 2, 3} // 2
            //0//1 //2
            };

           int rowNumber = 1; // номер строки для суммы
           int columnNumber = 0; //номер столбца для произведения

           int resultSumRow = 0;
           int resultMultiplyColumn = 1;

           for (int i = 0; i < array.GetLength(0); i++)
           {
               for (int j = 0; j < array.GetLength(1); j++)
               {
                   Console.Write(array[i, j] + " ");
               }
               Console.WriteLine();
           }

           for (int i = 0; i < array.GetLength(1); i++)
           {
               resultSumRow = resultSumRow + array[rowNumber, i];
           }

           for (int i = 0; i < array.GetLength(0); i++)
           {
               resultMultiplyColumn = resultMultiplyColumn * array[i, columnNumber];
           }

           Console.WriteLine($"Сумма чисел во второй строке: {resultSumRow}");
           Console.WriteLine($"Произведение чисел в первом столбце: {resultMultiplyColumn}");
            
           //Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки, где он находятся. Вывести наибольший элемент, исходную и полученную матрицу. 
           //Массив под измененную версию не нужен.

           int numberLineInMatrix = 10;
           int numberColumnInMatrix = 10;
           int[,] array = new int[numberLineInMatrix, numberColumnInMatrix];
           int maxElementMartix = int.MinValue;
           Random random = new Random();

           for (int i = 0; i < array.GetLength(0); i++)
           {
               for (int j = 0; j < array.GetLength(1); j++)
               {
                   int minimumElementMatrix = 0;
                   int maximumElementMatrix = 101;
                   array[i, j] = random.Next(minimumElementMatrix, maximumElementMatrix);
                   Console.Write(array[i, j] + " ");

                   if (maxElementMartix < array[i, j])
                   {
                       maxElementMartix = array[i, j];
                   }
               }
           }

           Console.WriteLine("\n");
           Console.WriteLine($"Наибольший элемент матрицы: {maxElementMartix}");
           Console.WriteLine("\n");

           int replacingMaxElementMatrix = 0;

           for (int i = 0; i < array.GetLength(0); i++)
           {
               for (int j = 0; j < array.GetLength(1); j++)
               {
                   if (array[i, j] == maxElementMartix)
                   {
                       array[i, j] = replacingMaxElementMatrix;
                   }

                   Console.Write(array[i, j] + " ");
               }
           }
           //Дан одномерный массив целых чисел из 30 элементов.
           //Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он больше своих соседей)

           int[] array = new int[30];

           Random random = new Random();

           for (int i = 0; i < array.Length; i++)
           {
               int minimumElementArray = 0;
               int maximumElementArray = 101;
               array[i] = random.Next(minimumElementArray, maximumElementArray);
               Console.Write(array[i] + " ");
           }

           Console.WriteLine();

           if (array[0] > array[1])
           {
               Console.WriteLine($"Крайний элемент является локальным максимумом = {array[0]}");
           }

           for (int i = 1; i < array.Length - 1; i++)
           {
               if (array[i] > array[i - 1] && array[i] > array[i + 1])
               {
                   Console.WriteLine("Локальный максимум = " + array[i]);
               }
           }

           int secondToLastElement = 2;

           if (array[array.Length - 1] > array[array.Length - secondToLastElement])
           {
               Console.WriteLine($"Крайний элемент является локальным максимумом = {array[array.Length - 1]}");
           }

           //Пользователь вводит числа, и программа их запоминает. 
           //Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
           //Выход из программы должен происходить только в том случае, если пользователь введет команду exit.

           bool isWorking = true;

           int lengthArray = 0;
           int[] array = new int[lengthArray];

           while (isWorking)
           {
               const string MenuNumber = "1";
               const string MenuSum = "2";
               const string MenuExit = "3";

               Console.WriteLine($"{MenuNumber} Ввести число {MenuSum} Почтитать сумму {MenuExit} Выйти");
               string userInput = Console.ReadLine();

               if (userInput == MenuNumber)
               {
                   Console.WriteLine("Введите число: ");
                   int userNumber = Convert.ToInt32(Console.ReadLine());
                   int[] tempArray = new int[array.Length + 1];

                   for (int i = 0; i < array.Length; i++)
                   {
                       tempArray[i] = array[i];
                   }

                   tempArray[tempArray.Length - 1] = userNumber;
                   array = tempArray;
               }
               else if (userInput == MenuSum)
               {
                   int arraySum = 0;

                   for (int i = 0; i < array.Length; i++)
                       arraySum += array[i];

                   Console.WriteLine($"Сумму всех веденных чисел: {arraySum} ");
               }
               else if (userInput == MenuExit)
               {
                   isWorking = false;
               }
               else
               {
                   Console.WriteLine("Введины неверные данные");
               }
           }

           //Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы, от меньшего до большего.

           int[] array = new int[10];
           Random random = new Random();
           int minimumElementArray = 0;
           int maximumElementArray = 11;
           int tempArray;

           Console.WriteLine("Изначальный массив: ");

           for (int i = 0; i < array.Length; i++)
           {
               array[i] = random.Next(minimumElementArray, maximumElementArray);
               Console.Write(array[i] + " ");
           }

           for (int i = 0; i < array.Length; i++)
           {
               for (int j = i + 1; j < array.Length; j++)
               {
                   if (array[i] > array[j])
                   {
                       tempArray = array[i];
                       array[i] = array[j];
                       array[j] = tempArray;
                   }
               }
           }

           Console.WriteLine("\nОтсортированный массив: ");

           for (int i = 0; i < array.Length; i++)
           {
               Console.Write(array[i] + " ");
           }
           //Дана строка с текстом, используя метод строки String.Split() получить массив слов,
           //которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.

           string stringText = "Hello, World!";
           char spaceInText = ' ';
           string[] arrayWords = stringText.Split(spaceInText);

           foreach (var word in arrayWords)
           {
               Console.WriteLine($"\n{word}");
           }

           //Дан массив чисел.Нужно его сдвинуть циклически на указанное пользователем значение позиций влево,
           //не используя других массивов.Пример для сдвига один раз: { 1, 2, 3, 4} => { 2, 3, 4, 1}

           int[] arrayNumbers = { 1, 2, 3, 4, 5 };
           int numberOfPossibleShifts = 5;
           int userInput;
           int numberOfShifts;
           int tempArray;

           Console.WriteLine("Изначальный массив");

           for (int i = 0; i < arrayNumbers.Length; i++)
           {
               Console.Write(arrayNumbers[i] + " ");
           }

           Console.WriteLine("\nНа сколько позиций циклически сдвинуть массив влево?");
           userInput = Convert.ToInt32(Console.ReadLine());

           if (userInput <= numberOfPossibleShifts)
           {
               numberOfShifts = userInput % arrayNumbers.Length;

               for (int i = 0; i < numberOfShifts; i++)
               {
                   for (int j = 0; j < arrayNumbers.Length - 1; j++)
                   {
                       tempArray = arrayNumbers[j];
                       arrayNumbers[j] = arrayNumbers[j + 1];
                       arrayNumbers[j + 1] = tempArray;
                   }
               }

               Console.WriteLine("Новый массив");

               for (int i = 0; i < arrayNumbers.Length; i++)
               {
                   Console.Write(arrayNumbers[i] + " ");
               }
           }
           else
           {
               Console.WriteLine("Количество позиций превышено");
           }
       }
   }
}
