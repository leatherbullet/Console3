using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandConvertRublesInDollars = "1";
            const string CommandConvertRublesInEuro = "2";
            const string CommandConvertDollarsInRubles = "3";
            const string CommandConvertDollarsInEuro = "4";
            const string CommandConvertEuroInRubles = "5";
            const string CommandConvertEuroInDollars = "6";
            const string CommandEndSesson = "7";

            float rublesInDollar = 90;
            float rublesInEuro = 100;
            float dollarsInEuro = 0.9f;
            float euroInDollars = 1.1f;
            float dollarInRubles = 0.012f;
            float euroInRubles = 0.0098f;
            float walletInRubles;
            float walletInDollars;
            float walletInEuro;
            float userInput;

            string userChoice;

            bool canCycleWork = true;

            Console.WriteLine("введите количество рублей:");
            walletInRubles = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите количество долларов:");
            walletInDollars = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите количество евро:");
            walletInEuro = Convert.ToSingle(Console.ReadLine());

            while (canCycleWork == true)
            {
                Console.Clear();
                Console.WriteLine($"ваш баланс:\n{walletInRubles}рублей\n{walletInDollars}долларов\n{walletInEuro}евро\n");
                Console.WriteLine("выберете действие");
                Console.WriteLine($"{CommandConvertRublesInDollars}- поменять рубли на доллары");
                Console.WriteLine($"{CommandConvertRublesInEuro}- поменять рубли на евро");
                Console.WriteLine($"{CommandConvertDollarsInRubles}- поменять доллары на рубли");
                Console.WriteLine($"{CommandConvertDollarsInEuro}- поменять доллары на евро");
                Console.WriteLine($"{CommandConvertEuroInRubles}- поменять евро на рубли");
                Console.WriteLine($"{CommandConvertEuroInDollars}- поменять евро на доллары");
                Console.WriteLine($"{CommandEndSesson}- выход");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case CommandConvertRublesInDollars:
                        Console.WriteLine("сколько рублей вы хотите перевести в доллары");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInRubles)
                        {
                            walletInRubles -= userInput;
                            walletInDollars += userInput * dollarInRubles;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertRublesInEuro:
                        Console.WriteLine("сколько рублей вы хотите перевести евро");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInRubles)
                        {
                            walletInRubles -= userInput;
                            walletInEuro += userInput * euroInRubles;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertDollarsInRubles:
                        Console.WriteLine("сколько долларов вы хотите перевести в рубли");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInDollars)
                        {
                            walletInDollars -= userInput;
                            walletInRubles += userInput * rublesInDollar;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertDollarsInEuro:
                        Console.WriteLine("сколько долларов вы хотите перевести в евро");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInDollars)
                        {
                            walletInDollars -= userInput;
                            walletInEuro += userInput * dollarsInEuro;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertEuroInRubles:
                        Console.WriteLine("сколько евро вы хотите перевести в рубли");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInEuro)
                        {
                            walletInEuro -= userInput;
                            walletInRubles += userInput * rublesInEuro;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertEuroInDollars:
                        Console.WriteLine("сколько евро вы хотите перевести в доллары");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInEuro)
                        {
                            walletInEuro -= userInput;
                            walletInDollars += userInput * euroInDollars;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandEndSesson:
                        canCycleWork = false;
                        break;

                    default:
                        Console.WriteLine("неверный ввод");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
