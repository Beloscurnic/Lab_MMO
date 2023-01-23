using System;

namespace Lab_MMO
{
    class Program
    {
        static void Main(string[] args)
        {

            Input_Data input = new Input_Data();

            while (true)
            {
                Console.WriteLine("1. Задача линейного программирования");
                Console.WriteLine("2. Транспортная задача");
                Console.WriteLine("3. Матричная игра");
                Console.WriteLine("4. Портфель марковица (Не доработан) ");
                Console.WriteLine("5. Выход их программы");

                Console.Write("Введите номер пункта на выполнение:");
                string key = Console.ReadLine();
                Console.WriteLine();
                switch (key)
                {

                    case "1":
                        Console.WriteLine("1. Задача линейного программирования на Min");
                        Console.WriteLine("2. Задача линейного программирования на Max");
                        Console.Write("Введите номер пункта на выполнение:");
                        string key1 = Console.ReadLine();
                        Console.WriteLine();
                        if (key1 == "1")
                        {
                            Linear_Programming simplex_Metod = new Linear_Programming(input.Input_Linear_Programming());
                            break;
                        }
                        else
                        {
                            Linear_Programming simplex_Metod = new Linear_Programming(input.Input_Linear_Programming_2());
                            break;
                        }
                    case "2":
                        Console.WriteLine("1. Сбалансированая транспортная задача");
                        Console.WriteLine("2. Не сбалансированная транспортная задача");
                        Console.Write("Введите номер пункта на выполнение:");
                        string key2 = Console.ReadLine();
                        Console.WriteLine();
                        if (key2 == "1")
                        {
                            Transportation_Problem transportation_Problem = new Transportation_Problem(input.Input_Transportation_Problem());
                            break;
                        }
                        else
                        {
                            Transportation_Problem transportation_Problem = new Transportation_Problem(input.Input_Transportation_Problem_2());
                            break;
                        }
                    case "3":
                        Console.WriteLine("1. Матричная игра в смешаных стратегиях");
                        Console.WriteLine("2. Матричная игра в чистых стратегиях");
                        Console.Write("Введите номер пункта на выполнение:");
                        string key3 = Console.ReadLine();
                        Console.WriteLine();
                        if (key3 == "1")
                        {
                            Matrix_Game matix_game = new Matrix_Game(input.Input_Matrix_Game_Problem_2());
                            break;
                        }
                        else
                        {
                            Matrix_Game matix_game = new Matrix_Game(input.Input_Matrix_Game_Problem());
                            break;
                        }
                    case "4":
                        Markowitz_Portfolio markowitz_Portfolio = new Markowitz_Portfolio(input.Input_Markowitz_Portfolio());
                        break;
                    case "5":
                        return;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Нажмите любую кнопку для выхода в меню");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
