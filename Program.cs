// Задача со звёздочкой 2: Напишите программу, которая выводит монотонную последовательность из N элементов в виде равностороннего треугольника с помощью рекурсии

Console.Clear();
Console.WriteLine("Программа выводит монотонную последовательность из N элементов в виде равностороннего треугольника с помощью рекурсии");

int number = AskForInput();

System.Console.WriteLine($"\nМонотонный треугольник из {number} строк: \n");
PrintTriangle(1, number);

//////////////////////////// функции ////////////////////////////////////////////////////


int AskForInput()
{
    while (true)
    {
        Console.Write($"\nНапишите число строк (> 1) монотонного треугольника:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 1) 
            {
                return number;
                break;
            }
            else Console.WriteLine($"Некорректно указано число строк монотонного треугольника!\n");
        }
        else Console.WriteLine($"Некорректно указано число строк монотонного треугольника!\n");
    }
}

void PrintTriangle(int startdigit, int num)
{
    if(startdigit > number) return;
    for(int i = 0; i < num - 1; i++)
    {
        System.Console.Write(" ");
    }
    for(int j = 1; j <= startdigit; j++)
    {
        System.Console.Write($"{startdigit} ");
    }
    System.Console.WriteLine();
    PrintTriangle(startdigit + 1, num - 1);
}