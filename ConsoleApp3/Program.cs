using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        //Задача№1
        //enum Mounth { Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь }

        //Заача№2
        //enum MathOperation
        //{
        //    Add = 1,
        //    Subtract,
        //    Multiply,
        //    Divide
        //}

        //Задача№4
        //enum UserRole
        //{
        //    Администратор,
        //    Модератор,
        //    Пользователь,
        //    Гость
        //}


        static void Main(string[] args)
        {
            //Задача№1
            //    Mounth i;
            //    for (i = Mounth.Январь; i <= Mounth.Декабрь; i++)
            //    {
            //        Console.WriteLine((int)i + "            " + i);
            //    }
            //    Console.Read();

            //Задача№2
            //    bool continueProgram = true;

            //    while (continueProgram)
            //    {
            //        Console.Clear(); // Очистка экрана перед каждым новым действием

            //        Console.WriteLine("Введите первое число:");
            //        if (!double.TryParse(Console.ReadLine(), out double num1))
            //        {
            //            Console.WriteLine("Ошибка: введено неверное значение.");
            //            Pause();
            //            continue;
            //        }

            //        Console.WriteLine("Введите второе число:");
            //        if (!double.TryParse(Console.ReadLine(), out double num2))
            //        {
            //            Console.WriteLine("Ошибка: введено неверное значение.");
            //            Pause();
            //            continue;
            //        }

            //        Console.WriteLine("\nВыберите операцию:");
            //        Console.WriteLine("1 - Сложение");
            //        Console.WriteLine("2 - Вычитание");
            //        Console.WriteLine("3 - Умножение");
            //        Console.WriteLine("4 - Деление");

            //        if (!int.TryParse(Console.ReadLine(), out int operationChoice) ||
            //            !Enum.IsDefined(typeof(MathOperation), operationChoice))
            //        {
            //            Console.WriteLine("Ошибка: неверный выбор операции.");
            //            Pause();
            //            continue;
            //        }

            //        MathOperation operation = (MathOperation)operationChoice;
            //        double result;

            //        switch (operation)
            //        {
            //            case MathOperation.Add:
            //                result = num1 + num2;
            //                break;
            //            case MathOperation.Subtract:
            //                result = num1 - num2;
            //                break;
            //            case MathOperation.Multiply:
            //                result = num1 * num2;
            //                break;
            //            case MathOperation.Divide:
            //                if (num2 == 0)
            //                {
            //                    Console.WriteLine("Ошибка: деление на ноль.");
            //                    Pause();
            //                    continue;
            //                }
            //                result = num1 / num2;
            //                break;
            //            default:
            //                Console.WriteLine("Неизвестная операция.");
            //                Pause();
            //                continue;
            //        }

            //        Console.WriteLine($"\nРезультат: {result}");

            //        Console.WriteLine("\nХотите выполнить ещё одну операцию? (д/н):");
            //        string answer = Console.ReadLine()?.Trim().ToLower();
            //        continueProgram = (answer == "д" || answer == "y");
            //    }

            //    Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу для выхода...");
            //    Console.ReadKey();
            //}

            //static void Pause()
            //{
            //    Console.WriteLine("Нажмите любую клавишу для продолжения...");
            //    Console.ReadKey();
            //}

            //Задача№4
            //    Console.WriteLine("Выберите вашу роль, введя букву:");
            //    Console.WriteLine("A) Администратор");
            //    Console.WriteLine("B) Модератор");
            //    Console.WriteLine("C) Пользователь");
            //    Console.WriteLine("D) Гость");

            //    string input = Console.ReadLine();
            //    if (input != null)
            //        input = input.Trim().ToUpper();

            //    UserRole? role = null;

            //    switch (input)
            //    {
            //        case "A":
            //            role = UserRole.Администратор;
            //            break;
            //        case "B":
            //            role = UserRole.Модератор;
            //            break;
            //        case "C":
            //            role = UserRole.Пользователь;
            //            break;
            //        case "D":
            //            role = UserRole.Гость;
            //            break;
            //    }

            //    if (role.HasValue)
            //    {
            //        switch (role.Value)
            //        {
            //            case UserRole.Администратор:
            //                Console.WriteLine("Вы зарегистрированы как администратор.");
            //                break;
            //            case UserRole.Модератор:
            //                Console.WriteLine("Вы зарегистрированы как модератор.");
            //                break;
            //            case UserRole.Пользователь:
            //                Console.WriteLine("Вы зарегистрированы как пользователь.");
            //                break;
            //            case UserRole.Гость:
            //                Console.WriteLine("Вы зарегистрированы как гость.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка: введено некорректное значение.");
            //    }

            //    Console.WriteLine("Нажмите любую клавишу для выхода...");
            //    Console.ReadKey();
            //}

            //Задача№5
            Accountant accountant = new Accountant();
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.Clear();

                Console.WriteLine("Доступные должности:");
                foreach (var postName in Enum.GetNames(typeof(Post)))
                    Console.WriteLine($"- {postName}");

                Console.Write("\nВведите должность сотрудника: ");
                string inputPost = Console.ReadLine();

                bool validPost = Enum.TryParse<Post>(inputPost, true, out Post position);
                if (!validPost)
                {
                    Console.WriteLine("Ошибка: введена некорректная должность.");
                    PauseAndContinuePrompt(ref continueProgram);
                    continue;
                }

                int hoursWorked = ReadIntegerFromConsole("Введите количество отработанных часов за месяц: ");

                if (hoursWorked < 0)
                {
                    Console.WriteLine("Ошибка: количество часов не может быть отрицательным.");
                    PauseAndContinuePrompt(ref continueProgram);
                    continue;
                }

                bool bonus = accountant.AskForBonus(position, hoursWorked);

                Console.WriteLine($"\nСотруднику {(bonus ? "положена" : "не положена")} премия.");

                PauseAndContinuePrompt(ref continueProgram);
            }

            Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static int ReadIntegerFromConsole(string prompt)
        {
            Console.Write(prompt);
            StringBuilder inputBuilder = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    if (int.TryParse(inputBuilder.ToString(), out int result))
                        return result;
                    else
                    {
                        Console.WriteLine("Ошибка: введите корректное число.");
                        inputBuilder.Clear();
                        Console.Write(prompt);
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (inputBuilder.Length > 0)
                    {
                        inputBuilder.Remove(inputBuilder.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else if (char.IsDigit(keyInfo.KeyChar))
                {
                    inputBuilder.Append(keyInfo.KeyChar);
                    Console.Write(keyInfo.KeyChar);
                }
                // Другие символы игнорируем
            }
        }

        static void PauseAndContinuePrompt(ref bool continueFlag)
        {
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить, или 'Y' для выхода...");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Y)
                continueFlag = false;
        
            }
        }
    }




