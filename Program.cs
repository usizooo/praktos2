using System;

Console.WriteLine("Выберете программу: \n1.Угадай число \n2.Таблица умножения \n3.Вывод делителей числа \n4.Выход из меню");
int operation;
do
{
    operation = Convert.ToInt32(Console.ReadLine());

    if (operation == 1)
    {
        Random RandomClass = new Random();
        int i = RandomClass.Next(1, 100);

        Console.WriteLine("Угадай число от 1 до 100:");
        Console.WriteLine("Введите число:");
        int a;
        do
        {
            a = Convert.ToInt32(Console.ReadLine());

            if (a > i)
            {
                Console.WriteLine("Надо число меньше");
                Console.WriteLine("Введите другое число:");
            }
            if (a < i)
            {
                Console.WriteLine("Надо число больше");
                Console.WriteLine("Введите другое число:");
            }

        } while (a != i);

        if (a == i)
        {
            Console.WriteLine("Молодец! Ты угадал число!");
        }

        Console.WriteLine("Выберете программу заново: \n1.Угадай число \n2.Таблица умножения \n3.Вывод делителей числа \n4.Выход из меню");
    }

    else if (operation == 2)
    {
        int[,] tab_um = new int[10, 10];
        for (int i = 0; i <= 9; i++)
            for (int j = 0; j <= 9; j++)
                tab_um[i, j] = (i + 1) * (j + 1);

        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
                Console.Write((i == 0 ? j : (j == 0 ? i : i * j)) + "\t");
            Console.WriteLine("\n");
        }

        Console.WriteLine("Выберете программу заново: \n1.Угадай число \n2.Таблица умножения \n3.Вывод делителей числа \n4.Выход из меню");
    }

    else if (operation == 3)
    {
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int a = 1; a <= num; a++)
        {
            if (num % a == 0) Console.Write("{0} ", a);
        }
        
        Console.WriteLine("\n");
        Console.WriteLine("Выберете программу заново: \n1.Угадай число \n2.Таблица умножения \n3.Вывод делителей числа \n4.Выход из меню");
    }
} while (operation < 4);

