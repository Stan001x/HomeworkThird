Console.Clear();

Console.WriteLine("Введите число больше 2");

int a = Convert.ToInt32(Console.ReadLine()), count = 2;


while (a < 2)
    {Console.WriteLine("Ошибка. Требуется число больше 2\nВведите число больше 2");
    a = Convert.ToInt32(Console.ReadLine());};

    while(count < a)  
    {Console.Write($"{count} ");
        count = count + 2;};